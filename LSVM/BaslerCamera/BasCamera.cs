using Basler.Pylon;
using Device;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaslerCamera
{
    class BasCamera : Device.ICamera
    {
        private bool isOpen;
        private bool isGrab;
        private string id;
        private string name;
        private string ip;
        private string mac;
        private double exposuretime;
        private double acquisitionfrequency;
        private double triggerdelay;
        private double gain;
        private bool gainauto;

        private TriggerSources triggersource;
        private TriggerSwitchs triggerswitchs;
        private TriggerModes triggermodes;
        private TriggerEdges triggeredges;

        //set window event
        private event CaptureDelegate EventCapture;
        //set get image event
        public static List<Device.ICamera> allCamera = null;

        public Camera myCamera;
        private readonly PixelDataConverter converter = new PixelDataConverter();

        public static List<Device.ICamera> AllCamera
        {
            get { return allCamera; }
            set { allCamera = value; }
        }

        public bool IsOpen
        {
            get { return isOpen; }
            set { isOpen = value; }
        }
        public bool IsGrab
        {
            get { return isGrab; }
            set { isGrab = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }

        public string Mac
        {
            get { return mac; }
            set { mac = value; }
        }

        public double ExposureTime
        {
            get { return exposuretime; }
            set { exposuretime = value; }
        }

        public double Gain
        {
            get { return gain; }
            set { gain = value; }
        }

        public double AcquisitionFrequency
        {
            get { return acquisitionfrequency; }
            set { acquisitionfrequency = value; }
        }

        public double TriggerDelay
        {
            get { return triggerdelay; }
            set { triggerdelay = value; }
        }

        public bool GainAuto
        {
            get { return gainauto; }
            set { gainauto = value; }
        }

        public TriggerSources TriggerSource
        {
            get { return triggersource; }
            set { triggersource = value; }
        }

        public TriggerModes TriggerMode
        {
            get { return triggermodes; }
            set { triggermodes = value; }
        }

        public TriggerEdges TriggerEdge
        {
            get { return triggeredges; }
            set { triggeredges = value; }
        }

        public TriggerSwitchs TriggerSwitch
        {
            get { return triggerswitchs; }
            set { triggerswitchs = value; }
        }

        public bool OpenCamera()
        {
            Environment.SetEnvironmentVariable("PYLON_GIGE_HEARTBEAT", "3000" /*ms*/);
            List<ICameraInfo> allCameras = CameraFinder.Enumerate();
            foreach (ICameraInfo tempinfo in allCameras)
            {
                if (tempinfo[CameraInfoKey.UserDefinedName] == name)
                {
                    myCamera = new Camera(tempinfo);
                    if (myCamera.IsOpen)
                        return false;
                    //连续拍摄模式
                    myCamera.CameraOpened += Configuration.AcquireContinuous;
                    //断开连接事件：如果相机意外丢失，关闭数据流抓取，释放相机
                    myCamera.ConnectionLost += Camera_ConnectionLost;
                    //抓取图片事件
                    myCamera.StreamGrabber.ImageGrabbed += StreamGrabber_ImageGrabbed;
                    //打开相机
                    myCamera.Open();
                    isOpen = true;
                }
            }
            return true;
        }



        private void Camera_ConnectionLost(object sender, EventArgs e)
        {
            myCamera.StreamGrabber.Stop();
            CloseCamera();
        }
        private void StreamGrabber_ImageGrabbed(object sender, ImageGrabbedEventArgs e)
        {
            // Get the grab result.
            IGrabResult grabResult = e.GrabResult;
            // Check if the image can be displayed.
            if (grabResult.IsValid)
            {
                Bitmap bitmap = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format32bppRgb);
                // Lock the bits of the bitmap.
                BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
                // Place the pointer to the buffer of the bitmap.
                converter.OutputPixelFormat = PixelType.BGRA8packed;
                IntPtr ptrBmp = bmpData.Scan0;
                converter.Convert(ptrBmp, bmpData.Stride * bitmap.Height, grabResult);
                bitmap.UnlockBits(bmpData);
                Bitmap temp = (Bitmap)bitmap.Clone();
                CallFunction(this.Name, temp);

                if (bitmap != null)
                    bitmap.Dispose();

                GC.Collect();
            }
        }

        public bool CloseCamera()
        {
            if (myCamera == null)
            {
                return false;
            }
            myCamera.Close();
            myCamera.Dispose();
            myCamera = null;
            isOpen = false;
            return true;
        }

        public bool OpenStream()
        {
            TriggerConfiguration();
            SetExposureTime();
            
            if (!myCamera.IsOpen)
            {
                return false;
            }
            if (myCamera.StreamGrabber.IsGrabbing)
            {
                myCamera.StreamGrabber.Stop();
            }
            if (TriggerMode == TriggerModes.Continuous)
            {
                myCamera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.Continuous);
                myCamera.StreamGrabber.Start(GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
            }
            if (TriggerMode == TriggerModes.SoftWare || TriggerMode == TriggerModes.Unknow)
            {
                myCamera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.SingleFrame);
                myCamera.StreamGrabber.Start(1, GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
            }
            isGrab = true;
            return true;
        }

        public bool CloseStream()
        {
            if (!myCamera.StreamGrabber.IsGrabbing)
            {
                return false; 
            }
            myCamera.StreamGrabber.Stop();
            isGrab = false;
            return true;
        }

        public void RegisterCaptureCallback(CaptureDelegate delCaptureFun)
        {
            EventCapture += delCaptureFun;
        }

        public void CallFunction(object obj, Bitmap bmp)
        {
            EventCapture(obj, bmp);
        }

        public void TriggerSoftware()
        {

            bool isWaitingFrameStart = myCamera.Parameters[PLCamera.AcquisitionStatus].GetValue();
            if (isWaitingFrameStart)
            {
                myCamera.Parameters[PLCamera.TriggerSoftware].Execute();
            }
        }

        public void TriggerConfiguration()
        {
            switch (TriggerMode)
            {
                case TriggerModes.Continuous:
                    myCamera.Parameters[PLCamera.TriggerMode].SetValue(PLCamera.TriggerMode.Off);
                    break;
                case TriggerModes.SoftWare:
                    myCamera.Parameters[PLCamera.TriggerMode].SetValue(PLCamera.TriggerMode.On);
                    myCamera.Parameters[PLCamera.TriggerSource].SetValue(PLCamera.TriggerSource.Software);
                    break;
                case TriggerModes.HardWare:
                    myCamera.Parameters[PLCamera.TriggerMode].SetValue(PLCamera.TriggerMode.On);
                    myCamera.Parameters[PLCamera.TriggerSource].SetValue(PLCamera.TriggerSource.Line1);
                    break;
                case TriggerModes.Unknow:
                    myCamera.Parameters[PLCamera.TriggerMode].SetValue(PLCamera.TriggerMode.On);
                    myCamera.Parameters[PLCamera.TriggerSource].SetValue(PLCamera.TriggerSource.Software);
                    break;
            }
        }

        



        public void SetExposureTime()
        {
            if (myCamera.Parameters.Contains(PLCamera.ExposureTimeAbs))
            {
                double exposuremintime = myCamera.Parameters[PLCamera.ExposureTimeAbs].GetMinimum();
                double exposuremaxtime = myCamera.Parameters[PLCamera.ExposureTimeAbs].GetMaximum();
                if ((exposuretime > exposuremintime) && (exposuretime < exposuremaxtime))
                    myCamera.Parameters[PLCamera.ExposureTimeAbs].SetValue(exposuretime);
            }
            else
            {
                double exposuremintime = myCamera.Parameters[PLCamera.ExposureTime].GetMinimum();
                double exposuremaxtime = myCamera.Parameters[PLCamera.ExposureTime].GetMaximum();
                if ((exposuretime > exposuremintime) && (exposuretime < exposuremaxtime))
                    myCamera.Parameters[PLCamera.ExposureTime].SetValue(exposuretime);
            }
        }
    }
}
