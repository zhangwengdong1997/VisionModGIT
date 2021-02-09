using HalconDotNet;
using LSVisionMod.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Model
{
    public class OutResult
    {
        public string TestItemName { get; set; }
        public string CamName { get; set; }
        public bool IsOK { get; set; }
        public string ResultMessage { get; set; }//字典
        public OutImage OriginalImage { get; set; }
        public OutImage EffectImage { get; set; }


    }
}
