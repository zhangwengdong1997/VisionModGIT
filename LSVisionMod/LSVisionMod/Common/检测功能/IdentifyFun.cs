using HalconDotNet;
using LSVisionMod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Common
{
    public abstract class IdentifyFun
    {
        public string name;
        public string camName;
        public string matchName;
        public string outMessage;
        public bool isOK = false;
        public bool hav = false;
        public abstract void Create(List<Parameter> inParameters);
        public abstract int Find(HObject inImage);

        public abstract void Show(HObject inImage, out HObject resultImage);

        public abstract void Show(HObject inImage, HTuple homMat2D, out HObject resultImage);
    }
}
