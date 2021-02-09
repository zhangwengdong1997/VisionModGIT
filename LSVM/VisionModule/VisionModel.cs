using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VisionMod.VisionDetector;

namespace VisionMod
{
    class VisionModel
    {
        /// <summary>
        /// 禁止外部调用构造函数
        /// </summary>
        private VisionModel() { }
        public int StepsNumber { get; set; }
        public List<string> StepNames { get; set; }
        
        /// <summary>
        /// 根据模板名读取模板
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="visionModel"></param>
        /// <returns></returns>
        public static bool Read(string modelName, out VisionModel visionModel)
        {
            visionModel = new VisionModel();
            visionModel.StepsNumber = 3;
            visionModel.StepNames = new List<string>();
            visionModel.StepNames.Add("拍照");


            return true;
        }

        public bool Subscribe(out VisionDetector detector)
        {
            detector = new VisionDetector();
            foreach ()
            {
                detector.DetectDone += 

            }
            return true;
        }
    }
}
