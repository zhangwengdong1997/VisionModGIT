using CameraModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisionMod
{
    class VisionControl
    {
        #region 初始化
        /// <summary>
        /// 关联相机
        /// </summary>
        /// <returns></returns>
        public static bool ConnectCam(CameraControl cameraControl)
        {
            return true;
        }


        #endregion

        #region 模板管理界面
        /// <summary>
        /// 获取模板名列表
        /// </summary>
        /// <param name="visionModelNameLists"></param>
        /// <returns></returns>
        public static bool GetVisionModelNameList(out List<string> visionModelNameLists)
        {
            visionModelNameLists = null;
            return true;
        }
        /// <summary>
        /// 打开新建模板窗口
        /// </summary>
        /// <returns></returns>
        public static bool AddVisionModel()
        {
            return true;
        }
        public static bool AddVisionModel(string modelName)
        {
            return true;
        }
        public static bool AddVisionModel(string modelName, string PredefinedModelName)
        {
            return true;
        }
        /// <summary>
        /// 输出新建模板窗口控件
        /// </summary>
        /// <param name="AddVisionModelWindow"></param>
        /// <returns></returns>
        public static bool AddVisionModel(out UserControl AddVisionModelWindow)
        {
            AddVisionModelWindow = null;
            return true;
        }
        public static bool EditVisionModel(string modelName)
        {
            return true;
        }

        public static bool EditVisionModel(out UserControl EditVisionModelWindow)
        {
            EditVisionModelWindow = null;
            return true;
        }

        public static bool DeleteVisionModel(string modelName)
        {
            return true;
        }

        #endregion

        #region 检测
        public static bool CreateVisionDetector(string modelName, out VisionDetector visionDetector)
        {
            VisionModel.Read(modelName, out VisionModel visionModel);
            visionModel.Subscribe(out visionDetector);
            return true;
        }

        public static bool CreateVisionDetector(VisionModel visionModel, out VisionDetector visionDetector)
        {
            visionModel.Subscribe(out visionDetector);
            return true;
        }
        #endregion
    }
}
