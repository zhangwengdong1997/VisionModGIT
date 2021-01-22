using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Model
{
    public class ModelSteps
    {
        public string Name { get; set; }
        public List<Step> Steps { get; set; }

        public ModelSteps()
        {
            Steps = new List<Step>();
        }
    }

    public class Step
    {
        public int Index { get; set; }

        public int ParentIndex { get; set; }

        public string Type { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

    }
}
