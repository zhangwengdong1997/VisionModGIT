using LSVisionMod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Common.模板步骤
{
    /// <summary>
    /// 选择相机，设置相机参数，关联本地图片
    /// </summary>
    static class CamStep
    {
        public static event EventHandler ReconnectCamEvent;
        /// <summary>
        /// 获取相机名的队列
        /// </summary>
        /// <param name="CamNames"></param>
        /// <returns></returns>
        public static bool GetCameraNameList(out List<string> CamNames)
        {
            return MyRun.GetCameraNameList(out CamNames);
        }
        
        /// <summary>
        /// 重连相机
        /// 相机在连接视觉模块时就已经进行连接
        /// </summary>
        /// <returns></returns>
        public static bool ReconnectCam()
        {
            bool ret = MyRun.ReconnectCam();
            ReconnectCamEvent(null, null);
            return ret;
        }

        /// <summary>
        /// 获取相机曝光参数
        /// </summary>
        /// <param name="camName"></param>
        /// <param name="exposureTime"></param>
        /// <param name="minLimit"></param>
        /// <param name="maxLimit"></param>
        /// <returns></returns>
        public static bool GetCameraExposureTime(string camName, out float exposureTime, out float minLimit, out float maxLimit)
        {
            return MyRun.GetCameraExposureTime(camName, out exposureTime, out minLimit, out maxLimit);
        }

        /// <summary>
        /// 设置相机曝光参数
        /// </summary>
        /// <param name="camName"></param>
        /// <param name="exposureTime"></param>
        /// <returns></returns>
        public static bool SetCameraExposureTime(string camName, float exposureTime)
        {
            return MyRun.SetCameraExposureTime(camName, exposureTime);
        }

        /// <summary>
        /// 添加相机
        /// </summary>
        /// <param name="camName"></param>
        /// <param name="exposureTime"></param>
        /// <param name="model"></param>
        /// <returns>新建返回True，修改返回False</returns>
        public static bool AddCam(string camName, float exposureTime, ref ProductModel model)
        {
            Cam cam = model.cams.Find(x => x.CamName == camName);
            if (cam is null)
            {
                model.cams.Add(new Cam(camName, exposureTime));
                return true;
            }
            else
            {
                cam.ExposureTime = exposureTime;
                return false;
            }
            
            
        }
    }
}
