using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Model
{
    public class Parameter
    {
        public string name { get; set; }
        /// <summary>
        /// 参数类型
        /// </summary>
        public ParameterType type { get; set; }
        /// <summary>
        /// 参数值
        /// </summary>
        public object value { get; set; }
        public Parameter(string name, ParameterType type)
        {
            this.name = name;
            this.type = type;
        }
    }
    public enum ParameterType
    {
        数字 = 0,
        文字 = 1,
        区域 = 2,
        图片 = 3,
        文件 = 4,
        是否 = 5,
        阈值 = 6
    }
}
