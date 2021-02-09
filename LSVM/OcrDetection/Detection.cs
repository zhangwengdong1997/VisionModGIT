using DetectionBase;
using HalconDotNet;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcrDetection
{
    class Detection : IDetection
    {
        private string name;
        private string type;
        private List<string> inImageName;
        private List<string> inRegionName;
        private List<string> inParameterName;
        private ConcurrentDictionary<string, HObject> imageDictionary;
        private ConcurrentDictionary<string, HObject> regionDictionary;
        private ConcurrentDictionary<string, HTuple> parameterDictionary;

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public List<string> InImageName { get => inImageName; set => inImageName = value; }
        public List<string> InRegionName { get => inRegionName; set => inRegionName = value; }
        public List<string> InParameterName { get => inParameterName; set => inParameterName = value; }
        public ConcurrentDictionary<string, HObject> ImageDictionary { get => imageDictionary; set => imageDictionary = value; }
        public ConcurrentDictionary<string, HObject> RegionDictionary { get => regionDictionary; set => regionDictionary = value; }
        public ConcurrentDictionary<string, HTuple> ParameterDictionary { get => parameterDictionary; set => parameterDictionary = value; }


        public bool Creat()
        {
            throw new NotImplementedException();
        }

        public bool Find()
        {
            throw new NotImplementedException();
        }

        public bool Read()
        {
            throw new NotImplementedException();
        }

        public bool Write()
        {
            throw new NotImplementedException();
        }
    }
}
