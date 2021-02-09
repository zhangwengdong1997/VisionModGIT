using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    public interface ICamera
    {
        bool OpenCamera();
        bool CloseCamera();
        bool OpenStream();
        bool CloseStream();

        bool IsOpen { get; set; }
        bool IsGrab { get; set; }
        string Id { get; set; }
        string Name { get; set; }
        string Ip { get; set; }
        string Mac { get; set; }

        TriggerSources TriggerSource { get; set; }
        TriggerSwitchs TriggerSwitch { get; set; }
        TriggerModes TriggerMode { get; set; }
        TriggerEdges TriggerEdge { get; set; }

        double ExposureTime { get; set; }

        double AcquisitionFrequency { get; set; }

        double TriggerDelay { get; set; }

        double Gain { get; set; }

        bool GainAuto { get; set; }

        void RegisterCaptureCallback(CaptureDelegate delCaptureFun);

        void TriggerSoftware();
    }
}
