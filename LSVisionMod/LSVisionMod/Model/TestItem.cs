using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Model
{
    public class TestItem
    {
        /// <summary>
        /// 检测项名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 对应相机
        /// </summary>
        public string CamName { get; set; }
        /// <summary>
        /// 对应定位模板
        /// </summary>
        public string MatchName { get; set; }
        /// <summary>
        /// 检测项的类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 检测项是否屏蔽
        /// </summary>
        public bool Enable { get; set; }
        /// <summary>
        /// 参数列表
        /// </summary>
        public List<Parameter> Parameters { get; set; }
    }
}
