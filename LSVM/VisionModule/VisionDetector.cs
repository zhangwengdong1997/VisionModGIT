using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VisionMod
{
    /// <summary>
    /// 读取模板，开辟线程，接收触发信号开始检测，返回检测结果
    /// </summary>
    public class VisionDetector
    {
        VisionModel m_visionModel;

        public delegate void DetectHandler(DetectData detectData);
        
        public event DetectHandler DetectDone;

        public delegate void ReturnResultHandler(DetectData detectData);

        public event ReturnResultHandler ReturnResultDone;

        ManualResetEvent m_triggerWaitHandle = new ManualResetEvent(false);

        Thread DetectorThread;

        public bool Start()
        {
            m_triggerWaitHandle.Set();
            return true;
        }

        public bool Stop(bool isForced = false)
        {
            m_triggerWaitHandle.Reset();
            if (isForced)
            {
                DetectorThread.Abort();
            }
            return true;
        }

        public void Work()
        {
            while (true)
            {
                m_triggerWaitHandle.WaitOne();
                DetectData detectData = new DetectData();
                DetectDone(detectData);
                ReturnResultDone(detectData);
                m_triggerWaitHandle.Reset();
            }
        }
    }
}
