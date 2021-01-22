using HalconDotNet;
using LSVisionMod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.View.检测功能
{
    interface I检测参数设置
    {
        HTuple hWindow { get; set; }
        HObject hImage { get; set; }
        HObject hROI { get; set; }
        void Save(ref List<Parameter> parameterList);

        string GetName();

        List<Parameter> initParameterList();

        void SetHalconWindow(HTuple hWindow);

        void SetHalconImage(HObject ho_image);

        void Find(HObject inImage, List<Parameter> inParameters, out string outMessage);

        void Create(TestItem testItem);

        void WriteSample(string path, string name);

        void Initial(List<Parameter> inParameters);
        bool HaveSet();
    }
}
