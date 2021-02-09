using Device;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CameraModule
{
    public delegate void DelegateOnError(string ErrorMag);
    public delegate void DelegateOnBitmap(object camName, Bitmap bitmap);
    public class CameraControl
    {
        Bitmap _revBitmap = null;
        ICameraManager _cameraManager = null;

        List<Device.ICamera> _cameras = null;
        readonly List<string> _cameraNames = new List<string>();
        readonly Dictionary<string, int> _cameraNameToIndex = new Dictionary<string, int>();
        public Bitmap RevBitmap
        {
            get { return _revBitmap; }
            set { _revBitmap = value; }
        }
        /// <summary>
        /// 可连接的相机
        /// </summary>
        public List<string> CameraNames
        {
            get { return _cameraNames; }
        }
        /// <summary>
        /// 已连接的相机
        /// </summary>
        public List<string> HaveCameraNames
        {
            get { return _cameraNameToIndex.Keys.ToList(); }
        }

        private event DelegateOnError EventOnError;

        public event DelegateOnBitmap EventOnBitmap;

        public bool LoadCameraDLL(CameraBrand cameraBrand)
        {
            Assembly assem = Assembly.LoadFile(System.IO.Directory.GetCurrentDirectory() + "\\CamDLL\\" + cameraBrand + "Camera.dll");
            Type type = assem.GetType("Device.CameraFactory");
            MethodInfo mi = type.GetMethod("GetInstance");
            object obj = mi.Invoke(null, null);

            if (_cameraManager != null)
            {
                _cameraManager.Uninit();
            }
            _cameraManager = (ICameraManager)obj;
            _cameraManager.Init();
            _cameras = _cameraManager.GetCameras();
            _cameraNames.Clear();
            foreach (var camera in _cameras)
                _cameraNames.Add(camera.Name);
            return true;
        }

        public bool OpenOneCamera(string camName)
        {
            ICamera cam = _cameraManager.GetCameras().Find(x => x.Name == camName);
            if (cam is null)
            {
                EventOnError?.BeginInvoke("相机" + camName + "不存在", null, null);
                return false;
            }
            else if (cam.IsOpen)
            {
                return true;
            }
            else
            {
                cam.RegisterCaptureCallback(new CaptureDelegate(RecCapture));
                cam.OpenCamera();
                _cameraNameToIndex.Add(cam.Name, _cameraNameToIndex.Count);
            }
            return true;
        }

        public bool OpenAllCamera()
        {

            if (_cameras.Count == 0)
            {
                EventOnError?.BeginInvoke("无相机连接", null, null);
                return false;
            }
            for (int i = 0; i < _cameras.Count; i++)
            {
                if (_cameras[i].IsOpen) break;
                _cameras[i].RegisterCaptureCallback(new CaptureDelegate(RecCapture));
                _cameras[i].OpenCamera();
                _cameraNameToIndex.Add(_cameras[i].Name, i);
            }
            return true;
        }

        public bool CloseOneCamera(string camName)
        {
            ICamera cam = _cameraManager.GetCameras().Find(x => x.Name == camName);
            if (cam is null)
            {
                EventOnError?.BeginInvoke("相机" + camName + "不存在", null, null);
                return false;
            }
            else if (cam.IsOpen)
            {
                cam.CloseCamera();
            }
            return true;
        }

        public bool CloseAllCamera()
        {
            for (int i = 0; i < _cameras.Count; i++)
            {
                _cameras[i].CloseCamera();
            }
            _cameraNameToIndex.Clear();
            return true;
        }

        public bool OpenOneStream(string camName)
        {
            if (!_cameras[_cameraNameToIndex[camName]].IsOpen)
            {
                EventOnError?.BeginInvoke("相机" + camName + "未连接", null, null);
                return false;
            }
            if (!_cameras[_cameraNameToIndex[camName]].OpenStream())
            {
                EventOnError?.BeginInvoke("相机" + camName + "打开流失败", null, null);
                return false;
            }
            return true;
        }

        public bool CloseOneStream(string camName)
        {
            if (!_cameras[_cameraNameToIndex[camName]].IsOpen)
            {
                EventOnError?.BeginInvoke("相机" + camName + "未连接", null, null);
                return false;
            }
            if (!_cameras[_cameraNameToIndex[camName]].CloseStream())
            {
                EventOnError?.BeginInvoke("相机" + camName + "关闭流失败", null, null);
                return false;
            }
            return true;
        }

        public bool TriggerSoftware(string camName)
        {
            if (!_cameras[_cameraNameToIndex[camName]].IsGrab)
            {
                EventOnError?.BeginInvoke("相机" + camName + "未打开流", null, null);
                return false;
            }
            _cameras[_cameraNameToIndex[camName]].TriggerSoftware();

            return true;
        }

        public void ContinuesMode(string camName)
        {
            _cameras[_cameraNameToIndex[camName]].TriggerMode = TriggerModes.Continuous;
        }

        public void SoftwareMode(string camName)
        {
            _cameras[_cameraNameToIndex[camName]].TriggerMode = TriggerModes.SoftWare;
        }

        public void HardwareMode(string camName)
        {
            _cameras[_cameraNameToIndex[camName]].TriggerMode = TriggerModes.HardWare;
        }

        public void RecCapture(object camName, Bitmap bitmap)
        {
            RevBitmap = bitmap;
            EventOnBitmap(camName, bitmap);
        }
    }
}
