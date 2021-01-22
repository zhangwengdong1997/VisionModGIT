using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Model
{
    public class Cam
    {
        /// <summary>
        /// 相机用户自定义名称UserDefinedName
        /// </summary>
        public string CamName { get; set; }
        /// <summary>
        /// 曝光时间
        /// </summary>
        public float ExposureTime { get; set; }

        public Cam(string userDefinedName, float exposureTime)
        {
            CamName = userDefinedName;
            ExposureTime = exposureTime;
        }
    }
}
