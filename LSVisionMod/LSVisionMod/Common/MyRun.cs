using HalconDotNet;
using LSVisionMod.Model;
using LSVisionMod.View;
using LSVisionMod.View.检测功能;
using MvCamCtrl.NET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSVisionMod.Common
{
    class MyRun
    {
        public static ProductModel model;
        public static 模板配置 CreateModelWindow;
        private static HKCameraCltr cameraCltr;
        public static NowModel nowModel = new NowModel();

        public static bool havInit = false;
        public static string appPath = Application.StartupPath;
        public static string StrErrorMsg { get; set; }
        public static event EventHandler ModelNumberChangeEvent;
        public static int ModelNumber
        {
            get
            {
                int modelNumber = 0;
                List<String> modelNamelist = FileOperation.GetAllDirectoryName(appPath + "\\model");
                foreach (var modelName in modelNamelist)
                {
                    ProductModel model = ReadModelJS(modelName);
                    if (model != null) modelNumber++;
                }
                return modelNumber;
            }
            set
            {
                ModelNumberChangeEvent?.Invoke(null, null);
            }
        }

        public static bool Init()
        {
            HOperatorSet.SetSystem("clip_region", "false");
            havInit = true;
            //连接相机
            cameraCltr = new HKCameraCltr();
            new Thread(() =>
            {
                if (!cameraCltr.Connect())
                {
                    StrErrorMsg = "相机异常：" + cameraCltr.StrErrorMsg;
                }
            })
            { IsBackground = true }.Start();
            if (StrErrorMsg != null)
            {
                return false;
            }
            return true;
        }

        public static bool IsCamConnect(string camName)
        {
            return cameraCltr.IsDeviceConnected(camName);
        }

        public static void GetProductModelNameList(out List<string> modelNameList)
        {
            modelNameList = new List<string>();
            string path = MyRun.appPath + "\\model";
            Directory.CreateDirectory(path);
            DirectoryInfo theFolder = new DirectoryInfo(path);
            DirectoryInfo[] thedirectoryInfo = theFolder.GetDirectories();

            foreach (var directory in thedirectoryInfo)
            {
                ProductModel model = MyRun.ReadModelJS(directory.Name);
                if (model != null)
                {
                    modelNameList.Add(model.modelName);
                }
            }
        }

        public static bool ReconnectCam()
        {
            if (!cameraCltr.Connect())
            {
                StrErrorMsg = "相机异常：" + cameraCltr.StrErrorMsg;
                return false;
            }
            return true;
        }

        public static void WriteModelJS(ProductModel model)
        {
            IniManager.WriteToIni(model, appPath + "\\model\\" + model.modelName + "\\model.js");
        }

        public static ProductModel ReadModelJS(string modelName)
        {
            return IniManager.ReadFromIni<ProductModel>(appPath + "\\model\\" + modelName + "\\model.js");
        }

        public static List<string> GetCameraList()
        {
            return HKCameraCltr.GetListUserDefinedName();
        }

        public static bool GetCameraExposureTime(string camName, out float exposureTime, out float minLimit, out float maxLimit)
        {
            MyCamera.MVCC_FLOATVALUE ExposureTime = new MyCamera.MVCC_FLOATVALUE();
            MyCamera cam = cameraCltr.DicMyCamera(camName);
            if(cam is null)
            {
                StrErrorMsg = "相机" + camName + "连接失败";
                exposureTime = -1;
                minLimit = -1;
                maxLimit = -1;
                return false;
            }
            int nRet = cam.MV_CC_GetExposureTime_NET(ref ExposureTime);
            if (MyCamera.MV_OK != nRet)
            {
                StrErrorMsg = "相机曝光值参数获取失败";
                exposureTime = -1;
                minLimit = -1;
                maxLimit = -1;
                return false;
            }
            exposureTime = ExposureTime.fCurValue;
            minLimit = ExposureTime.fMin;
            maxLimit = ExposureTime.fMax;
            return true;
        }

        public static bool SetCameraExposureTime(string camName, float exposureTime)
        {
            string sParamName = "ExposureTime";
            MyCamera cam = cameraCltr.DicMyCamera(camName);
            if (cam is null)
            {
                StrErrorMsg = "相机" + camName + "连接失败";
                return false;
            }
            int nRet = cam.MV_CC_SetFloatValue_NET(sParamName, exposureTime);
            if (MyCamera.MV_OK != nRet)
            {
                //警告相机曝光设置失败
                StrErrorMsg = "相机异常：相机" + camName + "曝光设置失败";
                return false;
            }
            return true;
        }

        public static MatchingFun GetMatchingFun(string MatchingType)
        {
            switch (MatchingType)
            {
                case "形状模板定位":
                    return new 形状模板定位();
                case "可变形模板定位":
                    return new 可变形模板定位();
                case "无模板定位":
                    return new 无模板定位();
                default:
                    return new 无模板定位();
            }
        }

        public static IdentifyFun GetTestItem(TestItem testItem)
        {
             switch (testItem.Type)
            {
                case "字符识别":
                    return new 字符识别(testItem);
                case "区域筛选计数":
                    return new 区域筛选计数(testItem);
                default:
                    return null;
            }
        }

        public static bool ContinuesMode()
        {
            try
            {
                cameraCltr.ContinuesMode();
            }
            catch (Exception e)
            {
                StrErrorMsg = "相机异常：实时模式切换失败" + e.Message;
                return false;
            }
            return true;
        }

        public static bool TriggerMode()
        {
            try
            {
                cameraCltr.TriggerMode();
            }
            catch (Exception e)
            {
                StrErrorMsg = "相机异常：软件触发模式切换失败" + e.Message;
                return false;
            }
            return true;
        }

        
        public static bool HardMode()
        {
            try
            {
                cameraCltr.HardMode();
            }
            catch (Exception e)
            {
                StrErrorMsg = "相机异常：硬件触发模式切换失败" + e.Message;
                return false;
            }
            return true;
        }

        public static bool TriggerCamera(string camName, out HObject outImage)
        {
            if(!cameraCltr.Capture(camName, out outImage))
            {
                StrErrorMsg = "相机异常：触发拍照失败" + cameraCltr.StrErrorMsg;
                return false;
            }
            return true;
        }

        public static bool TriggerCamera(string camName, out Bitmap outImage)
        {
            if (!cameraCltr.Capture(camName, out outImage))
            {
                StrErrorMsg = "相机异常：触发拍照失败" + cameraCltr.StrErrorMsg;
                return false;
            }
            return true;
        }
        public static bool GetTemplateImage(string modelName, string itemName, out Bitmap bigImage, out Bitmap smallImage)
        {
            bigImage = null;
            smallImage = null;
            try
            {
                Bitmap empbigImage = new Bitmap(appPath + "\\model\\" + modelName + "\\b_" + itemName + ".bmp");
                Bitmap empsmallImage = new Bitmap(appPath + "\\model\\" + modelName + "\\s_" + itemName + ".bmp");

                bigImage = new Bitmap(empbigImage);
                smallImage = new Bitmap(empsmallImage);
                empbigImage.Dispose();
                empsmallImage.Dispose();
            }
            catch(Exception e)
            {
                StrErrorMsg = "模板读取异常：样本图片读取失败" + e.Message;

                return false;
            }
            
            return true;
        }

        public static bool GetCameraNameList(out List<string> CamNames)
        {
            CamNames = HKCameraCltr.GetListUserDefinedName();
            return true;
        }

        public static bool GetMatchingTypeList(out List<string> MatchingTypes)
        {
            MatchingTypes = new List<string>
            {
                "形状模板定位",
                "可变形模板定位",
                "无模板定位"
            };

            return true;
        }

        public static bool GetTestItemTypeList(out List<string> TestItemTypes)
        {
            //以后检测功能多了再说

            TestItemTypes = new List<string>
            {
                "字符识别",
                "区域筛选计数"
            };

            return true;
        }

        public static bool GetParameterSettingControl(string TestItemType, out I检测参数设置 ParameterSetControl)
        {
            ParameterSetControl = null;
            switch (TestItemType)
            {
                case "字符识别":
                    ParameterSetControl = new 字符识别参数设置();
                    return true;
                case "区域筛选计数":
                    return true;
                default:
                    return false;
            }
        }

    }
}
