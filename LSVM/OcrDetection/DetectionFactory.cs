using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectionBase
{
    public class DetectionFactory
    {
        static IDetection instance = null;

        static public IDetection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OcrDetection.Detection();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        static public IDetection GetInstance()
        {
            return Instance;
        }
    }

}
