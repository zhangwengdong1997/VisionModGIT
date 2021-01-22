using HalconDotNet;
using LSVisionMod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Common
{
    class 无模板定位 : MatchingFun
    {
        public override void Create(HObject inImage, HObject inRegion)
        {
            Release();
            outContour = new HObject(inRegion);
            this.inRegion = new HObject(inRegion);
            this.inImage = new HObject(inImage);
        }

        public override int Find(HObject inImage, out HObject outImage)
        {
            HOperatorSet.CopyImage(inImage, out outImage);
            return 0;
        }

        public override int Find(HObject inImage, out HObject outImage, out double Score)
        {
            HOperatorSet.CopyImage(inImage, out outImage);
            Score = 1;
            return 0;
        }

        public override void Read(string sFolderPath, Matching matching)
        {
            this.matching = matching;
        }

        public override void Release()
        {
            if (outModelID != null)
            {
                HOperatorSet.ClearShapeModel(outModelID);
                outModelID = null;
            }
            if (outContour != null)
            {
                outContour.Dispose();
                outContour = null;
            }
            if (inRegion != null)
            {
                inRegion.Dispose();
                inRegion = null;
            }
            if (inImage != null)
            {
                inImage.Dispose();
                inImage = null;
            }
        }

        public override void Write(string sFolderPath, string matchingName)
        {
            
        }
    }
}
