using Device;
using MvCamCtrl.NET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HikVisionCamera
{
    class HikCamera : ICamera
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

        private event CaptureDelegate EventCapture;
        
        public static List<ICamera> allCamera = null;
        public MyCamera getonecamera;
        private int nRet = MyCamera.MV_OK;
        public static MyCamera.cbOutputExdelegate ImageCallback;


        public static List<ICamera> AllCamera
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
            System.GC.Collect();
            getonecamera = new MyCamera();

            MyCamera.MV_CC_DEVICE_INFO_LIST stDevList = new MyCamera.MV_CC_DEVICE_INFO_LIST();
            nRet = MyCamera.MV_CC_EnumDevices_NET(MyCamera.MV_GIGE_DEVICE, ref stDevList);

            if (MyCamera.MV_OK != nRet)
            {
                Console.WriteLine("枚举设备失败", nRet);
                return false;
            }
            Console.WriteLine("设备数目：" + Convert.ToString(stDevList.nDeviceNum));

            if (0 == stDevList.nDeviceNum)
            {
                return false;
            }

            MyCamera.MV_CC_DEVICE_INFO stDevInfo;

            for (Int32 i = 0; i < stDevList.nDeviceNum; i++)
            {
                //赋值结构体的一种方式
                stDevInfo = (MyCamera.MV_CC_DEVICE_INFO)Marshal.PtrToStructure(stDevList.pDeviceInfo[i], typeof(MyCamera.MV_CC_DEVICE_INFO));

                //选择网口连接的相机
                if (MyCamera.MV_GIGE_DEVICE == stDevInfo.nTLayerType)
                {
                    MyCamera.MV_GIGE_DEVICE_INFO stGigEDeviceInfo = (MyCamera.MV_GIGE_DEVICE_INFO)MyCamera.ByteToStruct(stDevInfo.SpecialInfo.stGigEInfo, typeof(MyCamera.MV_GIGE_DEVICE_INFO));

                    //显示IP
                    UInt32 nIp1 = (stGigEDeviceInfo.nCurrentIp & 0xFF000000) >> 24;
                    UInt32 nIp2 = (stGigEDeviceInfo.nCurrentIp & 0x00FF0000) >> 16;
                    UInt32 nIp3 = (stGigEDeviceInfo.nCurrentIp & 0x0000FF00) >> 8;
                    UInt32 nIp4 = (stGigEDeviceInfo.nCurrentIp & 0x000000FF);
                    string tempCameraIp = nIp1.ToString() + "." + nIp2.ToString() + "." + nIp3.ToString() + "." + nIp4.ToString();

                    if (stGigEDeviceInfo.chUserDefinedName == this.Name || tempCameraIp == this.Ip)
                    {
                        nRet = getonecamera.MV_CC_CreateDevice_NET(ref stDevInfo);
                        if (MyCamera.MV_OK != nRet)
                        {
                            Console.WriteLine("创建相机失败:{0:x8}", nRet);
                            return false;
                        }
                        //打开设备
                        nRet = getonecamera.MV_CC_OpenDevice_NET();
                        if (MyCamera.MV_OK != nRet)
                        {
                            Console.WriteLine("打开相机失败:{0:x8}", nRet);
                            return false;
                        }

                        //探测网络最佳包大小
                        int nPacketSize = getonecamera.MV_CC_GetOptimalPacketSize_NET();
                        if (nPacketSize > 0)
                        {
                            nRet = getonecamera.MV_CC_SetIntValue_NET("GevSCPSPacketSize", (uint)nPacketSize);
                            if (nRet != MyCamera.MV_OK)
                            {
                                Console.WriteLine("相机设置数据包大小失败:{0:x8}", nRet);
                            }
                        }
                        else
                        {
                            Console.WriteLine("相机数据包最佳大小小于0:{ 0:x8}", nPacketSize);
                        }
                    }
                }
            }
            isOpen = true;
            return true;

        }

        public bool CloseCamera()
        {
            CloseStream();
            //关闭设备
            nRet = getonecamera.MV_CC_CloseDevice_NET();
            if (MyCamera.MV_OK != nRet)
            {
                Console.WriteLine("相机关闭失败:{0:x8}", nRet);
                return false;
            }

            //销毁设备
            nRet = getonecamera.MV_CC_DestroyDevice_NET();
            if (MyCamera.MV_OK != nRet)
            {
                Console.WriteLine("相机销毁失败:{0:x8}", nRet);
                return false;
            }
            isOpen = false;
            return true;
        }

        public bool OpenStream()
        {
            TriggerConfiguration();
            SetExposureTime();

            nRet = getonecamera.MV_CC_RegisterImageCallBackEx_NET(ImageCallback, IntPtr.Zero);
            if (MyCamera.MV_OK != nRet)
            {
                Console.WriteLine("注册回调函数失败:{0:x8}", nRet);
                return false;
            }

            //开启抓图
            nRet = getonecamera.MV_CC_StartGrabbing_NET();
            if (MyCamera.MV_OK != nRet)
            {
                Console.WriteLine("开始抓图失败:{0:x8}", nRet);
                return false;
            }
            isGrab = true;
            return true;
        }

        public bool CloseStream()
        {
            nRet = getonecamera.MV_CC_StopGrabbing_NET();
            if (MyCamera.MV_OK != nRet)
            {
                Console.WriteLine("停止抓图失败:{0:x8}", nRet);
                return false;
            }
            isGrab = false;
            return true;
        }

        public void TriggerConfiguration()
        {
            //设置采集连续模式
            getonecamera.MV_CC_SetEnumValue_NET("AcquisitionMode", (uint)MyCamera.MV_CAM_ACQUISITION_MODE.MV_ACQ_MODE_CONTINUOUS);

            switch (TriggerMode)
            {
                case TriggerModes.Continuous:
                    nRet = getonecamera.MV_CC_SetEnumValue_NET("TriggerMode", (uint)MyCamera.MV_CAM_TRIGGER_MODE.MV_TRIGGER_MODE_OFF);
                    if (MyCamera.MV_OK != nRet)
                    {
                        Console.WriteLine("设置连续模式失败!");

                    }
                    break;
                case TriggerModes.SoftWare:
                    nRet = getonecamera.MV_CC_SetEnumValue_NET("TriggerMode", (uint)MyCamera.MV_CAM_TRIGGER_MODE.MV_TRIGGER_MODE_ON);
                    if (MyCamera.MV_OK != nRet)
                    {
                        Console.WriteLine("设置触发模式失败!");

                    }
                    nRet = getonecamera.MV_CC_SetEnumValue_NET("TriggerSource", (uint)MyCamera.MV_CAM_TRIGGER_SOURCE.MV_TRIGGER_SOURCE_SOFTWARE);
                    if (MyCamera.MV_OK != nRet)
                    {
                        Console.WriteLine("设置软件触发模式失败!");

                    }
                    break;
                case TriggerModes.HardWare:
                    nRet = getonecamera.MV_CC_SetEnumValue_NET("TriggerMode", (uint)MyCamera.MV_CAM_TRIGGER_MODE.MV_TRIGGER_MODE_ON);
                    if (MyCamera.MV_OK != nRet)
                    {
                        Console.WriteLine("设置触发模式失败!");

                    }
                    nRet = getonecamera.MV_CC_SetEnumValue_NET("TriggerSource", (uint)MyCamera.MV_CAM_TRIGGER_SOURCE.MV_TRIGGER_SOURCE_LINE0);
                    if (MyCamera.MV_OK != nRet)
                    {
                        Console.WriteLine("设置硬件触发模式失败!");

                    }
                    break;
                case TriggerModes.Unknow:
                    nRet = getonecamera.MV_CC_SetEnumValue_NET("TriggerMode", (uint)MyCamera.MV_CAM_TRIGGER_MODE.MV_TRIGGER_MODE_ON);
                    if (MyCamera.MV_OK != nRet)
                    {
                        Console.WriteLine("设置触发模式失败!");

                    }
                    nRet = getonecamera.MV_CC_SetEnumValue_NET("TriggerSource", (uint)MyCamera.MV_CAM_TRIGGER_SOURCE.MV_TRIGGER_SOURCE_SOFTWARE);
                    if (MyCamera.MV_OK != nRet)
                    {
                        Console.WriteLine("设置软件触发模式失败!");

                    }
                    break; 
            }
            //注册回调函数
            ImageCallback = new MyCamera.cbOutputExdelegate(ImageCallbackFunc);
        }

        private void ImageCallbackFunc(IntPtr pData, ref MyCamera.MV_FRAME_OUT_INFO_EX pFrameInfo, IntPtr pUser)
        {
            IntPtr pImageBuf = IntPtr.Zero;
            int nImageBufSize = 0;
            IntPtr pTemp;
            if (IsColorPixelFormat(pFrameInfo.enPixelType))
            {
                if (pFrameInfo.enPixelType == MyCamera.MvGvspPixelType.PixelType_Gvsp_RGB8_Packed)
                {
                    pTemp =pData;
                }
                else
                {
                    if (IntPtr.Zero == pImageBuf || nImageBufSize < (pFrameInfo.nWidth * pFrameInfo.nHeight * 3))
                    {
                        if (pImageBuf != IntPtr.Zero)
                        {
                            Marshal.FreeHGlobal(pImageBuf);
                        }

                        pImageBuf = Marshal.AllocHGlobal((int)pFrameInfo.nWidth * pFrameInfo.nHeight * 3);
                        if (IntPtr.Zero == pImageBuf)
                        {
                            return;
                        }
                        nImageBufSize = pFrameInfo.nWidth * pFrameInfo.nHeight * 3;
                    }

                    MyCamera.MV_PIXEL_CONVERT_PARAM stPixelConvertParam = new MyCamera.MV_PIXEL_CONVERT_PARAM
                    {
                        pSrcData =pData,//源数据
                        nWidth = pFrameInfo.nWidth,//图像宽度
                        nHeight = pFrameInfo.nHeight,//图像高度
                        enSrcPixelType = pFrameInfo.enPixelType,//源数据的格式
                        nSrcDataLen = pFrameInfo.nFrameLen,

                        nDstBufferSize = (uint)nImageBufSize,
                        pDstBuffer = pImageBuf,//转换后的数据
                        enDstPixelType = MyCamera.MvGvspPixelType.PixelType_Gvsp_RGB8_Packed
                    };
                    nRet = getonecamera.MV_CC_ConvertPixelType_NET(ref stPixelConvertParam);//格式转换
                    if (MyCamera.MV_OK != nRet)
                    {
                        return;
                    }
                    pTemp = pImageBuf;
                }


                Bitmap bmp = new Bitmap(pFrameInfo.nWidth, pFrameInfo.nHeight, pFrameInfo.nWidth * 3, PixelFormat.Format24bppRgb, pTemp);
                CallFunction(this.Name, bmp);
            }
            else if (IsMonoPixelFormat(pFrameInfo.enPixelType))
            {
                if (pFrameInfo.enPixelType == MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono8)
                {
                    pTemp =pData;
                }
                else
                {
                    if (IntPtr.Zero == pImageBuf || nImageBufSize < (pFrameInfo.nWidth * pFrameInfo.nHeight))
                    {
                        if (pImageBuf != IntPtr.Zero)
                        {
                            Marshal.FreeHGlobal(pImageBuf);
                        }

                        pImageBuf = Marshal.AllocHGlobal((int)pFrameInfo.nWidth * pFrameInfo.nHeight);
                        if (IntPtr.Zero == pImageBuf)
                        {
                            return;
                        }
                        nImageBufSize = pFrameInfo.nWidth * pFrameInfo.nHeight;
                    }

                    MyCamera.MV_PIXEL_CONVERT_PARAM stPixelConvertParam = new MyCamera.MV_PIXEL_CONVERT_PARAM
                    {
                        pSrcData =pData,//源数据
                        nWidth = pFrameInfo.nWidth,//图像宽度
                        nHeight = pFrameInfo.nHeight,//图像高度
                        enSrcPixelType = pFrameInfo.enPixelType,//源数据的格式
                        nSrcDataLen = pFrameInfo.nFrameLen,

                        nDstBufferSize = (uint)nImageBufSize,
                        pDstBuffer = pImageBuf,//转换后的数据
                        enDstPixelType = MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono8
                    };
                    nRet = getonecamera.MV_CC_ConvertPixelType_NET(ref stPixelConvertParam);//格式转换
                    if (MyCamera.MV_OK != nRet)
                    {
                        return;
                    }
                    pTemp = pImageBuf;
                }

                Bitmap bmp = new Bitmap(pFrameInfo.nWidth, pFrameInfo.nHeight, pFrameInfo.nWidth, PixelFormat.Format8bppIndexed, pTemp);

                ColorPalette cp = bmp.Palette;

                for (int i = 0; i < 256; i++)
                {
                    cp.Entries[i] = Color.FromArgb(i, i, i);
                }
                bmp.Palette = cp;
                CallFunction(this.Name, bmp);
            }
            if (pImageBuf != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(pImageBuf);
            }
        }

        public void CallFunction(object obj, Bitmap bmp)
        {
            EventCapture(obj, bmp);
        }

        public void SetExposureTime()
        {
            MyCamera.MVCC_FLOATVALUE stParam = new MyCamera.MVCC_FLOATVALUE();
            nRet = getonecamera.MV_CC_GetFloatValue_NET("ExposureTime", ref stParam);

            if ((float)ExposureTime > stParam.fMin && (float)ExposureTime < stParam.fMax)
            {
                nRet = getonecamera.MV_CC_SetFloatValue_NET("ExposureTime", (float)ExposureTime);
                if (nRet != MyCamera.MV_OK)
                {
                    Console.WriteLine("设置曝光值失败!");
                }
            }
        }
        private bool IsMonoPixelFormat(MyCamera.MvGvspPixelType enType)
        {
            switch (enType)
            {
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono8:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono10:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono10_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono12:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono12_Packed:
                    return true;
                default:
                    return false;
            }
        }

        private bool IsColorPixelFormat(MyCamera.MvGvspPixelType enType)
        {
            switch (enType)
            {
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_RGB8_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BGR8_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_RGBA8_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BGRA8_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_YUV422_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_YUV422_YUYV_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGR8:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerRG8:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGB8:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerBG8:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGB10:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGB10_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerBG10:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerBG10_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerRG10:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerRG10_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGR10:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGR10_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGB12:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGB12_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerBG12:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerBG12_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerRG12:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerRG12_Packed:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGR12:
                case MyCamera.MvGvspPixelType.PixelType_Gvsp_BayerGR12_Packed:
                    return true;
                default:
                    return false;
            }
        }

        public void RegisterCaptureCallback(CaptureDelegate delCaptureFun)
        {
            EventCapture += delCaptureFun;
        }

        public void TriggerSoftware()
        {
            if (TriggerMode == TriggerModes.Unknow|| TriggerMode == TriggerModes.SoftWare)
                nRet = getonecamera.MV_CC_SetCommandValue_NET("TriggerSoftware");
        }
    }
}
