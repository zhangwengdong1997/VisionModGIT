using LSVisionMod.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Common.模板步骤
{
    static class ProductModelStep
    {
        public static bool ReadCommonlyModel(out List<string> modelTypes)
        {
            modelTypes = null;
            return true;
        }

        public static bool AddModel(string modelName, ModelSteps modelSteps, ref ProductModel model)
        {
            model.modelName = modelName;
            model.ModelSteps = modelSteps;
            return true;
        }
    }
}
