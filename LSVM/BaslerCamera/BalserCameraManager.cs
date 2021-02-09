using Basler.Pylon;
using Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaslerCamera
{
    class BalserCameraManager: ICameraManager
    {
        readonly List<Device.ICamera> cameras = new List<Device.ICamera>();
        public List<Device.ICamera> GetCameras()
        {
            return cameras;
        }
        public bool Init()
        {
            List<ICameraInfo> allCameras = CameraFinder.Enumerate();
            cameras.Clear();
            foreach (ICameraInfo camerainfo in allCameras)
            {
                BasCamera camera = new BasCamera
                {
                    Name = camerainfo[CameraInfoKey.UserDefinedName],
                    Ip = camerainfo[CameraInfoKey.DeviceIpAddress],
                    //Id = camerainfo[CameraInfoKey.DeviceID],
                    Mac = camerainfo[CameraInfoKey.DeviceMacAddress]
                };
                cameras.Add(camera);
            }

            if (cameras.Count == 0)
                return false;

            BasCamera.allCamera = cameras;

            return true;
        }
        public void Uninit()
        {

        }
    }
}
