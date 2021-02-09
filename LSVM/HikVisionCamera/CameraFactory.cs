using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    public class CameraFactory
    {
        static ICameraManager instance = null;

        static public ICameraManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HikVisionCamera.HikVisionCameraManager();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        static public ICameraManager GetInstance()
        {
            return Instance;
        }
    }
}
