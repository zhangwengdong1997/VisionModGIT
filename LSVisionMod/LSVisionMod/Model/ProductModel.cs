using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Model
{
    public class ProductModel
    {
        /// <summary>
        /// 型号模板的名称
        /// </summary>
        public string modelName { get; set; }
        /// <summary>
        /// 调用的相机
        /// </summary>
        public List<Cam> cams { get; set; } = new List<Cam>();

        /// <summary>
        /// 定位模板
        /// </summary>
        public List<Matching> matchings { get; set; } = new List<Matching>();
        /// <summary>
        /// 检测项
        /// </summary>
        public List<TestItem> testItems { get; set; } = new List<TestItem>();

        /// <summary>
        /// 模板步骤
        /// </summary>
        public ModelSteps ModelSteps { get; set; }
    }
}
