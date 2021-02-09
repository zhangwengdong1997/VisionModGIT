using HalconDotNet;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectionBase
{
    public interface IDetection
    {
        bool Creat();
        bool Find();
        bool Read();
        bool Write();


        string Name { get; set; }
        string Type { get; set; }


        List<string> InImageName { get; set; }
        List<string> InRegionName { get; set; }
        List<string> InParameterName { get; set; }


        Dictionary<string, HObject> ImageDictionary { get; set; }
        Dictionary<string, HObject> RegionDictionary { get; set; }
        Dictionary<string, HTuple> ParameterDictionary { get; set; }

    }
}
