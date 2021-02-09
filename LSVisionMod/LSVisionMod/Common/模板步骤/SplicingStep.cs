using HalconDotNet;
using LSVisionMod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Common.模板步骤
{
    static class SplicingStep
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
        /// 拼接图片
        /// </summary>
        /// <param name="ho_Image1"></param>
        /// <param name="ho_Image2"></param>
        /// <param name="hv_SigmaGrad"></param>
        /// <param name="hv_ThreshInhom"></param>
        /// <param name="hv_ThreshShape"></param>
        /// <param name="hv_MatchThreshold"></param>
        /// <param name="ho_SplicingImage"></param>
        /// <param name="hv_HomMat2D"></param>
        /// <returns></returns>
        public static bool SplicingImage(HObject ho_Image1, HObject ho_Image2, HTuple hv_SigmaGrad,
            HTuple hv_ThreshInhom, HTuple hv_ThreshShape, HTuple hv_MatchThreshold, 
            out HObject ho_SplicingImage, out HTuple hv_HomMat2D, out HTuple hv_Kappa)
        {
            HTuple hv_Rows1, hv_Columns1;
            HTuple hv_Rows2, hv_Columns2;

            HTuple hv_Width, hv_Height;
            HTuple hv_CamParDist, hv_CamPar;

            HObject ho_Image1Rect, ho_Image2Rect;
            HObject ho_ImagesRect;
            HOperatorSet.PointsFoerstner(ho_Image1, hv_SigmaGrad, 2, 3, hv_ThreshInhom, hv_ThreshShape, "gauss", "true",
                out hv_Rows1, out hv_Columns1, out _, out _, out _, out _, out _, out _, out _, out _);
            HOperatorSet.PointsFoerstner(ho_Image2, hv_SigmaGrad, 2, 3, hv_ThreshInhom, hv_ThreshShape, "gauss", "true",
                out hv_Rows2, out hv_Columns2, out _, out _, out _, out _, out _, out _, out _, out _);

            HOperatorSet.GetImageSize(ho_Image1, out hv_Width, out hv_Height);
            HOperatorSet.ProjMatchPointsDistortionRansac(ho_Image1, ho_Image2, hv_Rows1,
                hv_Columns1, hv_Rows2, hv_Columns2, "ncc", 10, 0, 0, hv_Height, hv_Width,
                0, hv_MatchThreshold, "gold_standard", 1, 42, out hv_HomMat2D, out hv_Kappa, out _,
                out _, out _);

            hv_CamParDist = new HTuple();
            hv_CamParDist[0] = 0.0;
            hv_CamParDist = hv_CamParDist.TupleConcat(hv_Kappa);
            hv_CamParDist = hv_CamParDist.TupleConcat(1.0);
            hv_CamParDist = hv_CamParDist.TupleConcat(1.0);
            hv_CamParDist = hv_CamParDist.TupleConcat(0.5 * (hv_Width - 1));
            hv_CamParDist = hv_CamParDist.TupleConcat(0.5 * (hv_Height - 1));
            hv_CamParDist = hv_CamParDist.TupleConcat(hv_Width);
            hv_CamParDist = hv_CamParDist.TupleConcat(hv_Height);

            HOperatorSet.ChangeRadialDistortionCamPar("fixed", hv_CamParDist, 0, out hv_CamPar);
            HOperatorSet.ChangeRadialDistortionImage(ho_Image1, ho_Image1, out ho_Image1Rect,
                hv_CamParDist, hv_CamPar);
            HOperatorSet.ChangeRadialDistortionImage(ho_Image2, ho_Image2, out ho_Image2Rect,
                hv_CamParDist, hv_CamPar);
            HOperatorSet.ConcatObj(ho_Image1Rect, ho_Image2Rect, out ho_ImagesRect);
            HOperatorSet.GenProjectiveMosaic(ho_ImagesRect, out ho_SplicingImage, 1, 1, 2,
                hv_HomMat2D, "default", "false", out _);
            return true;
        }


        public static bool CreateSplicingModel(HObject ho_Image1, HObject ho_Image2, HTuple hv_SigmaGrad, HTuple hv_ThreshInhom,
            HTuple hv_ThreshShape, HTuple hv_MatchThreshold, out HTuple hv_HomMat2D, out HTuple hv_Kappa)
        {
            HTuple hv_Rows1, hv_Columns1;
            HTuple hv_Rows2, hv_Columns2;

            HTuple hv_Width, hv_Height;
            
            HOperatorSet.PointsFoerstner(ho_Image1, hv_SigmaGrad, 2, 3, hv_ThreshInhom, hv_ThreshShape, "gauss", "true",
                out hv_Rows1, out hv_Columns1, out _, out _, out _, out _, out _, out _, out _, out _);
            HOperatorSet.PointsFoerstner(ho_Image2, hv_SigmaGrad, 2, 3, hv_ThreshInhom, hv_ThreshShape, "gauss", "true",
                out hv_Rows2, out hv_Columns2, out _, out _, out _, out _, out _, out _, out _, out _);

            HOperatorSet.GetImageSize(ho_Image1, out hv_Width, out hv_Height);
            HOperatorSet.ProjMatchPointsDistortionRansac(ho_Image1, ho_Image2, hv_Rows1,
                hv_Columns1, hv_Rows2, hv_Columns2, "ncc", 10, 0, 0, hv_Height, hv_Width,
                0, hv_MatchThreshold, "gold_standard", 1, 42, out hv_HomMat2D, out hv_Kappa, out _,
                out _, out _);

            return true;
        }

        public static bool SplicingImage(HObject ho_Image1, HObject ho_Image2, HTuple hv_HomMat2D, HTuple hv_Kappa, out HObject ho_SplicingImage)
        {

            HTuple hv_CamParDist, hv_CamPar;
            HTuple hv_Width, hv_Height;

            HObject ho_Image1Rect, ho_Image2Rect;
            HObject ho_ImagesRect;

            HOperatorSet.GetImageSize(ho_Image1, out hv_Width, out hv_Height);

            hv_CamParDist = new HTuple();
            hv_CamParDist[0] = 0.0;
            hv_CamParDist = hv_CamParDist.TupleConcat(hv_Kappa);
            hv_CamParDist = hv_CamParDist.TupleConcat(1.0);
            hv_CamParDist = hv_CamParDist.TupleConcat(1.0);
            hv_CamParDist = hv_CamParDist.TupleConcat(0.5 * (hv_Width - 1));
            hv_CamParDist = hv_CamParDist.TupleConcat(0.5 * (hv_Height - 1));
            hv_CamParDist = hv_CamParDist.TupleConcat(hv_Width);
            hv_CamParDist = hv_CamParDist.TupleConcat(hv_Height);

            HOperatorSet.ChangeRadialDistortionCamPar("fixed", hv_CamParDist, 0, out hv_CamPar);
            HOperatorSet.ChangeRadialDistortionImage(ho_Image1, ho_Image1, out ho_Image1Rect,
                hv_CamParDist, hv_CamPar);
            HOperatorSet.ChangeRadialDistortionImage(ho_Image2, ho_Image2, out ho_Image2Rect,
                hv_CamParDist, hv_CamPar);
            HOperatorSet.ConcatObj(ho_Image1Rect, ho_Image2Rect, out ho_ImagesRect);
            HOperatorSet.GenProjectiveMosaic(ho_ImagesRect, out ho_SplicingImage, 1, 1, 2,
                hv_HomMat2D, "default", "false", out _);
            return true;
        }


        public static bool Write(string sFolderPath, HTuple hv_HomMat2D, string splicingName)
        {
            HOperatorSet.WriteTuple(hv_HomMat2D, sFolderPath + "\\" + splicingName);
            return true;
        }
    }
}
