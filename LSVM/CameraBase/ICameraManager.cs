using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    public interface ICameraManager
    {
        bool Init();
        void Uninit();
        List<ICamera> GetCameras();
    }
}
