using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Model
{
    public class Matching
    {
        /// <summary>
        /// 定位模板的名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 定位模板的类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 对应的相机名
        /// </summary>
        public string CamName { get; set; }
    }
}
