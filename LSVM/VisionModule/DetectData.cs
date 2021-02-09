using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionMod
{
    public class DetectData
    {
        Dictionary<string, HObject> hImagesDictionary = new Dictionary<string, HObject>();
        Dictionary<string, HObject> hRegionDictionary = new Dictionary<string, HObject>();
        Dictionary<string, HTuple> hTupleDictionary = new Dictionary<string, HTuple>();
    }
}
