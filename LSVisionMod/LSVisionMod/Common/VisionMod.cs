using HalconDotNet;
using LSVisionMod.Model;
using LSVisionMod.View;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSVisionMod.Common
{
    /// <summary>
    /// 管理外部程序可以调用的功能
    /// </summary>
    public class VisionMod
    {
        #region 初始化
        public static bool Connect()
        {
            if (MyRun.havInit) return true;
            if (!MyRun.Init())
            {
                StrErrorMsg = MyRun.StrErrorMsg;
                return false;
            }

            return true;
        }
        #endregion

        #region 异常
        /// <summary>
        /// 保存最后一次异常信息
        /// </summary>
        private static string strErrorMsg = "";
        /// <summary>
        /// 发生异常时会触发ErrorEvent
        /// </summary>
        public static string StrErrorMsg
        {
            get
            {
                return strErrorMsg;
            }
            private set
            {
                strErrorMsg = value;
                ErrorEvent?.Invoke(null, value);
            }
        }
        /// <summary>
        /// 视觉模块内部发生异常时触发
        /// </summary>
        public static event EventHandler<string> ErrorEvent;

        #endregion

        #region 事件

        /// <summary>
        /// 新建模板完成事件
        /// </summary>
        public static event EventHandler<string> CreateNewModelFinishEvent;

        /// <summary>
        /// 编辑模板完成事件
        /// </summary>
        public static event EventHandler<string> EditModelFinishEvent;
        /// <summary>
        /// 删除模板完成事件
        /// </summary>
        public static event EventHandler<string> DeleteModelFinishEvent;


        /// <summary>
        /// 拍照事件
        /// </summary>
        public event EventHandler<OutImage> SoftwareOnceEvent;
        /// <summary>
        /// 检测事件
        /// </summary>
        public event EventHandler<OutResult> DetectionOnceEvent;

        #endregion

        #region 模板

        public List<string> UseCamsName = new List<string>();
        public List<MatchingFun> UseMatchingFun = new List<MatchingFun>();
        public List<IdentifyFun> UseTestItems = new List<IdentifyFun>();

        /// <summary>
        /// 保存识别结果
        /// </summary>
        private List<OutResult> OutResults = new List<OutResult>();
        ProductModel UseModel;


        /// <summary>
        /// 切换型号模板
        /// </summary>
        /// <param name="modelName">模板名</param>
        /// <returns></returns>
        public bool PrepareModel(string modelName)
        {
            if (!MyRun.havInit)
            {
                StrErrorMsg = "视觉模块未初始化";
                return false;
            }
            UseModel = MyRun.ReadModelJS(modelName);
            if (UseModel is null)
            {
                StrErrorMsg = "模板" + modelName + "不存在";
                return false;
            }

            UseCamsName.Clear();
            foreach (var cam in UseModel.cams)
            {
                UseCamsName.Add(cam.CamName);
                if (!MyRun.IsCamConnect(cam.CamName))
                {
                    StrErrorMsg = "相机" + cam.CamName + "未连接";
                }
            }

            UseMatchingFun.Clear();
            foreach (var matching in UseModel.matchings)
            {
                MatchingFun matchingFun = MyRun.GetMatchingFun(matching.Type);
                matchingFun.Read(MyRun.appPath + "\\model\\" + UseModel.modelName, matching);
                UseMatchingFun.Add(matchingFun);
            }

            UseTestItems.Clear();
            foreach (var testItem in UseModel.testItems)
            {
                UseTestItems.Add(MyRun.GetTestItem(testItem));
            }

            return true;
        }

        #endregion

        #region 相机

        /// <summary>
        /// 查看相机是否连接
        /// </summary>
        /// <param name="camStatus">所以相机的连接状态列表</param>
        /// <returns>true表示所有的相机连接，false表示有相机未连接</returns>
        public static bool CamConnectStatus(out List<CamStatus> camStatus)
        {

            bool isConnect;
            bool isAllConnect = true;
            camStatus = new List<CamStatus>();
            if (!MyRun.havInit)
            {
                StrErrorMsg = "视觉模块未初始化";
                return false;
            }
            if (HKCameraCltr.GetListUserDefinedName().Count == 0)
            {
                return false;
            }
            foreach (var camName in HKCameraCltr.GetListUserDefinedName())
            {
                isConnect = MyRun.IsCamConnect(camName);
                isAllConnect = isAllConnect && isConnect;
                camStatus.Add(new CamStatus()
                {
                    CamName = camName,
                    IsConnect = isConnect
                });

            }
            return isAllConnect;
        }
        /// <summary>
        /// 重连相机
        /// </summary>
        /// <returns></returns>
        public static bool ReConnectCam()
        {
            if (!MyRun.havInit)
            {
                StrErrorMsg = "视觉模块未初始化";
                return false;
            }
            if (!MyRun.ReconnectCam())
            {
                StrErrorMsg = MyRun.StrErrorMsg;
                return false;
            }
            return true;

        }

        /// <summary>
        /// 切换到实时模式，使用实时模式时请设置好相机的帧率，防止画面撕裂
        /// </summary>
        /// <returns></returns>
        public static bool ContinuesMode()
        {
            if (!MyRun.havInit)
            {
                StrErrorMsg = "视觉模块未初始化";
                return false;
            }
            if (!MyRun.ContinuesMode())
            {
                StrErrorMsg = MyRun.StrErrorMsg;
                return false;
            }
            return true;
        }

        /// <summary>
        /// 切换到触发模式
        /// </summary>
        /// <returns></returns>
        public static bool TriggerMode()
        {
            if (!MyRun.havInit)
            {
                StrErrorMsg = "视觉模块未初始化";
                return false;
            }
            if (!MyRun.TriggerMode())
            {
                StrErrorMsg = MyRun.StrErrorMsg;
                return false;
            }
            return true;
        }

        /// <summary>
        /// 切换到硬件触发模式
        /// </summary>
        /// <returns></returns>
        public bool HardMode()
        {
            if (!MyRun.havInit)
            {
                StrErrorMsg = "视觉模块未初始化";
                return false;
            }
            if (!MyRun.HardMode())
            {
                StrErrorMsg = MyRun.StrErrorMsg;
                return false;
            }

            HKCameraCltr.HardTriggerEvent += HKCameraCltr_HardTriggerEvent;
            return true;
        }

        private void HKCameraCltr_HardTriggerEvent(object sender, HObject e)
        {
            string camName = (string)sender;
            HObject inImage = e;
            SoftwareOnceEvent?.Invoke(null, new OutImage(camName, inImage));
            foreach (var testItem in UseTestItems)
            {
                if (testItem.camName == camName)
                {
                    testItem.Find(inImage);
                    testItem.Show(inImage, out HObject resultImage);
                    OutResult outResult = new OutResult()
                    {
                        TestItemName = testItem.name,
                        CamName = testItem.camName,
                        IsOK = testItem.isOK,
                        ResultMessage = testItem.outMessage,
                        OriginalImage = new OutImage(testItem.camName, inImage),
                        EffectImage = new OutImage(testItem.camName, resultImage)
                    };
                    DetectionOnceEvent?.Invoke(null, outResult);
                }
            }
            inImage.Dispose();
        }

        /// <summary>
        /// 触发所有相机拍照
        /// </summary>
        /// <param name="imageType">存储与传输图片的格式</param>
        /// <returns></returns>
        public bool TriggerAllCamera(ImageType imageType = ImageType.HObject)
        {
            if (!MyRun.havInit)
            {
                StrErrorMsg = "视觉模块未初始化";
                return false;
            }

            if (UseCamsName.Count == 0)
            {
                StrErrorMsg = "未选择模板";
                return false;
            }
            foreach (var camName in UseCamsName.ToArray())
            {

                if (imageType == ImageType.HObject)
                {
                    MyRun.TriggerCamera(camName, out HObject outImage);
                    if (outImage != null)
                    {
                        SoftwareOnceEvent?.Invoke(null, new OutImage(camName, outImage));
                        outImage.Dispose();
                    }
                    else
                    {
                        StrErrorMsg = MyRun.StrErrorMsg;
                        return false;
                    }
                }
                if (imageType == ImageType.Bitmap)
                {
                    MyRun.TriggerCamera(camName, out Bitmap outImage);
                    if (outImage != null)
                    {
                        SoftwareOnceEvent?.Invoke(null, new OutImage(camName, outImage));
                        outImage.Dispose();
                    }
                    else
                    {
                        StrErrorMsg = MyRun.StrErrorMsg;
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 触发相机拍照
        /// </summary>
        /// <param name="camName">相机名</param>
        /// <param name="outHoImage">输出图片</param>
        /// <returns></returns>
        public static bool TriggerCamera(string camName, out HObject outHoImage)
        {
            if (!MyRun.havInit)
            {
                StrErrorMsg = "视觉模块未初始化";
                outHoImage = null;
                return false;
            }
            try
            {
                MyRun.TriggerCamera(camName, out outHoImage);
                if (outHoImage != null)
                {
                    return true;
                }
                else
                {
                    StrErrorMsg = MyRun.StrErrorMsg;
                    return false;
                }

            }
            catch (Exception ex)
            {
                StrErrorMsg = "图片获取失败" + ex.Message;
                outHoImage = null;
                return false;
            }

        }

        /// <summary>
        /// 触发相机拍照
        /// </summary>
        /// <param name="camName">相机名</param>
        /// <param name="outBitmap">输出图片</param>
        /// <returns></returns>
        public static bool TriggerCamera(string camName, out Bitmap outBitmap)
        {
            if (!MyRun.havInit)
            {
                StrErrorMsg = "视觉模块未初始化";
                outBitmap = null;
                return false;
            }
            try
            {
                MyRun.TriggerCamera(camName, out outBitmap);
                if (outBitmap != null)
                {
                    return true;
                }
                else
                {
                    StrErrorMsg = MyRun.StrErrorMsg;
                    return false;
                }

            }
            catch (Exception ex)
            {
                StrErrorMsg = "图片获取失败" + ex.Message;
                outBitmap = null;
                return false;
            }

        }

        public enum ImageType
        {
            HObject = 0,
            Bitmap = 1
        }

        #endregion

        #region 检测

        /// <summary>
        /// 手动控制停止检测的信号
        /// </summary>
        public EventWaitHandle stopDetectionSignal = new EventWaitHandle(false, EventResetMode.ManualReset);

        /// <summary>
        /// 检测线程
        /// </summary>
        private Thread DetectionThread;

        static object obj = new object();


        /// <summary>
        /// 触发检测，更具当前切换的型号模板进行拍照识别
        /// 该方法会开辟新线程
        /// 该方法不会返回识别结果，识别结果需要在调用WaitDetectionResult获取
        /// 同一时刻只能有一个TriggerDetection在运行
        /// </summary>
        /// <returns></returns>
        public bool TriggerDetection()
        {
            if (!MyRun.havInit)
            {
                StrErrorMsg = "视觉模块未初始化";
                return false;
            }
            if (DetectionThread != null && DetectionThread.IsAlive)
            {
                StrErrorMsg = "上一次拍照识别并未结束";
                return false;
            }
            DetectionThread = new Thread(() =>
            {
                //防止之前暂停的信号影响到这次检测
                stopDetectionSignal.Reset();
                OutResults.Clear();

                ConcurrentDictionary<string, HObject> camImages = new ConcurrentDictionary<string, HObject>();
                ConcurrentDictionary<string, HObject> matchImages = new ConcurrentDictionary<string, HObject>();
                ConcurrentDictionary<string, HTuple> matchHomMat2D = new ConcurrentDictionary<string, HTuple>();

                bool hav = true;
                while (true)
                {
                    Parallel.ForEach(UseCamsName.ToArray(), camName =>
                    {
                        if (MyRun.TriggerCamera(camName, out HObject camImage))
                        {
                            if (camImage != null)
                            {
                                //待升级:这里添加对图片质量的判断，如果图片模糊，撕裂则将图片丢弃

                                camImages.AddOrUpdate(camName, camImage, (k, v) => v = camImage);
                            }

                        }
                        else
                        {
                            StrErrorMsg = MyRun.StrErrorMsg;
                        }

                    });

                    //待升级:这里添加对产品是否到位的判断，通过特征检测的方式实现，不符合要求的则将图片丢弃

                    //待升级:这里添加模板匹配矫正图片的功能，检测项检测时使用的是矫正后的图片
                    //要将矫正的变换参数保存，界面显示的需要是把ROI区域等检测效果进行矫正的图片

                    Parallel.ForEach(UseMatchingFun.ToArray(), matchingFun =>
                    {
                        if (!matchingFun.matching.Name.Equals("无模板定位") && camImages.TryGetValue(matchingFun.matching.CamName, out HObject camImage))
                        {
                            int nRet = matchingFun.Find(camImage, out HObject matchImage);

                            if (nRet == 0)
                            {
                                matchImages.AddOrUpdate(matchingFun.matching.Name, matchImage, (k, v) => v = matchImage);
                                matchHomMat2D.AddOrUpdate(matchingFun.matching.Name, matchingFun.homMat2D, (k, v) => v = matchingFun.homMat2D);
                            }

                            SoftwareOnceEvent?.Invoke(null, new OutImage(matchingFun.matching.CamName, camImage));
                        }
                    });


                    Parallel.ForEach(UseTestItems.ToArray(), testItem =>
                    {
                        if (testItem.hav)
                            return;
                        HObject inImage = null;
                        if (testItem.matchName.Equals("无模板定位"))
                        {
                            if (camImages.TryGetValue(testItem.camName, out inImage))
                            {
                                testItem.Find(inImage);
                                testItem.Show(inImage, out HObject resultImage);
                                testItem.hav = true;
                                OutResult outResult = new OutResult()
                                {
                                    TestItemName = testItem.name,
                                    CamName = testItem.camName,
                                    IsOK = testItem.isOK,
                                    ResultMessage = testItem.outMessage,
                                    OriginalImage = new OutImage(testItem.camName, inImage),
                                    EffectImage = new OutImage(testItem.camName, resultImage)
                                };
                                DetectionOnceEvent?.Invoke(null, outResult);
                                OutResults.Add(outResult);
                            }
                        }
                        else
                        {
                            if (matchImages.TryGetValue(testItem.matchName, out inImage))
                            {
                                testItem.Find(inImage);
                                camImages.TryGetValue(testItem.camName, out inImage);
                                testItem.Show(inImage, matchHomMat2D[testItem.matchName], out HObject resultImage);
                                testItem.hav = true;
                                OutResult outResult = new OutResult()
                                {
                                    TestItemName = testItem.name,
                                    CamName = testItem.camName,
                                    IsOK = testItem.isOK,
                                    ResultMessage = testItem.outMessage,
                                    OriginalImage = new OutImage(testItem.camName, inImage),
                                    EffectImage = new OutImage(testItem.camName, resultImage)
                                };
                                DetectionOnceEvent?.Invoke(null, outResult);
                                OutResults.Add(outResult);
                            }

                        }
                    });

                    foreach (var camImage in camImages.Values)
                    {
                        camImage.Dispose();
                    }
                    hav = true;
                    foreach (var testItem in UseTestItems.ToArray())
                    {
                        hav &= testItem.hav;
                    }
                    if (hav)
                    {
                        foreach (var testItem in UseTestItems.ToArray())
                        {
                            testItem.hav = false;
                        }
                        break;
                    }
                    if (stopDetectionSignal.WaitOne(20))
                    {
                        break;
                    }
                    Thread.Sleep(20);
                }


            })
            {
                IsBackground = true
            };
            DetectionThread.Start();

            return true;
        }

        /// <summary>
        /// 阻塞线程直到拍照识别结束，返回TriggerDetection的结果
        /// </summary>
        /// <param name="outResult">TriggerDetection的结果</param>
        /// <returns></returns>
        public bool WaitDetectionResult(out List<OutResult> outResults)
        {
            outResults = OutResults;
            while (OutResults.Count < UseModel.testItems.Count)
            {
                if (stopDetectionSignal.WaitOne(20))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 阻塞线程直到拍照识别结束，返回TriggerDetection的结果
        /// 时间超时则返回部分结果
        /// </summary>
        /// <param name="outResults"></param>
        /// <param name="overTime">单位毫秒</param>
        /// <returns></returns>
        public bool WaitDetectionResult(out List<OutResult> outResults, int overTime)
        {
            DateTime time = DateTime.Now;
            //Thread.Sleep(50);
            while (OutResults.Count < UseModel.testItems.Count)
            {
                if ((DateTime.Now - time).TotalMilliseconds > overTime)
                {
                    DetectionThread = null;
                    outResults = new List<OutResult>(OutResults);
                    return false;
                }
                if (stopDetectionSignal.WaitOne(20))
                {
                    DetectionThread = null;
                    outResults = new List<OutResult>(OutResults);
                    return false;
                }
            }
            DetectionThread = null;
            outResults = new List<OutResult>(OutResults);
            OutResults.Clear();

            return true;
        }
        /// <summary>
        /// 触发检测，更具当前切换的型号模板进行拍照识别
        /// 阻塞线程直到拍照识别结束，返回TriggerDetection的结果
        /// 同一时刻只能有一个TriggerDetection在运行
        /// </summary>
        /// <param name="outResult"></param>
        /// <returns></returns>
        public bool TriggerDetection(out List<OutResult> outResults)
        {
            outResults = null;
            if (!MyRun.havInit)
            {
                StrErrorMsg = "视觉模块未初始化";
                return false;
            }
            if (DetectionThread != null && DetectionThread.IsAlive)
            {
                StrErrorMsg = "上一次拍照识别并未结束";
                return false;
            }

            OutResults.Clear();

            ConcurrentDictionary<string, HObject> camImages = new ConcurrentDictionary<string, HObject>();
            bool hav = true;
            while (true)
            {
                Parallel.ForEach(UseCamsName.ToArray(), camName =>
                {
                    if (MyRun.TriggerCamera(camName, out HObject camImage))
                    {
                        if (camImage != null)
                        {
                            //待升级:这里添加对图片质量的判断，如果图片模糊，撕裂则将图片丢弃

                            camImages.AddOrUpdate(camName, camImage, (k, v) => v = camImage);
                        }

                    }
                    else
                    {
                        StrErrorMsg = MyRun.StrErrorMsg;
                    }

                });

                //待升级:这里添加对产品是否到位的判断，通过特征检测的方式实现，不符合要求的则将图片丢弃

                //待升级:这里添加模板匹配矫正图片的功能，检测项检测时使用的是矫正后的图片，
                //要将矫正的变换参数保存，界面显示的需要是把ROI区域等检测效果进行矫正的图片


                Parallel.ForEach(UseTestItems.ToArray(), testItem =>
                {
                    if (camImages.TryGetValue(testItem.camName, out HObject camImage))
                    {
                        testItem.Find(camImage);
                        testItem.Show(camImage, out HObject resultImage);
                        testItem.hav = true;
                        OutResult outResult = new OutResult()
                        {
                            TestItemName = testItem.name,
                            CamName = testItem.camName,
                            IsOK = testItem.isOK,
                            ResultMessage = testItem.outMessage,
                            OriginalImage = new OutImage(testItem.camName, camImage),
                            EffectImage = new OutImage(testItem.camName, resultImage)
                        };
                        DetectionOnceEvent?.Invoke(null, outResult);
                        OutResults.Add(outResult);
                    }
                });

                foreach (var camImage in camImages.Values)
                {
                    camImage.Dispose();
                }
                hav = true;
                foreach (var testItem in UseTestItems.ToArray())
                {
                    hav &= testItem.hav;
                }
                if (hav)
                {
                    foreach (var testItem in UseTestItems.ToArray())
                    {
                        testItem.hav = false;
                    }
                    break;
                }
                if (stopDetectionSignal.WaitOne(20))
                {
                    break;
                }
                Thread.Sleep(20);
            }

            outResults = OutResults;
            return true;
        }

        /// <summary>
        /// 停止检测
        /// TriggerDetection内的循环会结束，返回识别结果
        /// </summary>
        /// <returns></returns>
        public bool StopDetection()
        {
            return stopDetectionSignal.Set();
        }

        #endregion

        #region 界面

        /// <summary>
        /// 获取型号模板列表
        /// </summary>
        /// <param name="productModels"></param>
        /// <returns></returns>
        public static bool GetProductModelList(out List<ProductModel> productModels)
        {
            productModels = new List<ProductModel>();
            if (!MyRun.havInit)
            {
                StrErrorMsg = "视觉模块未初始化";
                return false;
            }
            try
            {
                string path = MyRun.appPath + "\\model";
                Directory.CreateDirectory(path);
                DirectoryInfo theFolder = new DirectoryInfo(path);
                DirectoryInfo[] thedirectoryInfo = theFolder.GetDirectories();

                foreach (var directory in thedirectoryInfo)
                {
                    ProductModel model = MyRun.ReadModelJS(directory.Name);
                    if (model != null)
                    {
                        productModels.Add(model);
                    }
                }
            }
            catch (Exception e)
            {
                StrErrorMsg = "模板型号列表获取失败" + e.Message;
                return false;
            }
            return true;
        }

        /// <summary>
        /// 获取检测项预览图片
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="itemName"></param>
        /// <param name="bigImage"></param>
        /// <param name="smallImage"></param>
        /// <returns></returns>
        public static bool GetTemplateImage(string modelName, string itemName, out Bitmap bigImage, out Bitmap smallImage)
        {
            bigImage = null;
            smallImage = null;
            if (!MyRun.havInit)
            {
                StrErrorMsg = "视觉模块未初始化";
                return false;
            }
            ProductModel model = MyRun.ReadModelJS(modelName);
            if (model is null)
            {
                StrErrorMsg = "模板" + modelName + "不存在";
                return false;
            }
            if (MyRun.GetTemplateImage(modelName, itemName, out bigImage, out smallImage))
            {
                return true;
            }
            else
            {
                StrErrorMsg = MyRun.StrErrorMsg;
                return false;
            }
        }

        /// <summary>
        /// 添加型号模板
        /// 打开新的型号模板创建窗口
        /// </summary>
        /// <returns></returns>
        public static bool AddProductModel()
        {
            新建模板 createModelWindow = new 新建模板();
            createModelWindow.Show();
            return true;
        }

        /// <summary>
        /// 添加型号模板
        /// 打开新的型号模板创建窗口
        /// 新的型号模板名初始化为输入的型号模板名
        /// </summary>
        /// <param name="modelName"></param>
        /// <returns></returns>
        public static bool AddProductModel(string modelName)
        {
            新建模板 createModelWindow = new 新建模板();
            createModelWindow.SetModelName(modelName);
            createModelWindow.Show();
            return true;
        }

        /// <summary>
        /// 添加型号模板
        /// 输出控件,不打开新窗口
        /// </summary>
        /// <param name="AddProductModelWindow"></param>
        /// <returns></returns>
        public static bool AddProductModel(out UserControl AddProductModelWindow)
        {
            //功能还未实现
            AddProductModelWindow = null;
            return true;
        }

        /// <summary>
        /// 删除型号模板
        /// </summary>
        /// <returns></returns>
        public static bool DeleteProductModel(string modelName)
        {
            FileOperation.DelectDir(MyRun.appPath + "\\model\\" + modelName);
            DeleteModelFinishEvent?.Invoke(null, modelName);
            return true;
        }

        /// <summary>
        /// 修改型号模板
        /// 打开新的型号模板编辑窗口
        /// </summary>
        /// <returns></returns>
        public static bool EditProductModel(string modelName)
        {
            //功能还未实现
            新建模板 createModelWindow = new 新建模板();
            createModelWindow.SetModelName(modelName);
            createModelWindow.Show();
            createModelWindow.InitChooseModelTypeWindow(modelName);
            return true;
        }
        /// <summary>
        /// 修改型号模板
        /// 输出控件,不打开新窗口
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="EditProductModelWindow"></param>
        /// <returns></returns>
        public static bool EditProductModel(string modelName, out UserControl EditProductModelWindow)
        {
            EditProductModelWindow = null;
            return true;
        }

        #endregion

    }
}
