using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Common
{
    class ChangeImageType
    {
        public static Bitmap Honject2Bitmap(HObject hObject)
        {
            HOperatorSet.CopyImage(hObject, out HObject ho_image);

            HOperatorSet.CountChannels(ho_image, out HTuple hv_Channels);
            if (hv_Channels.D == 1)
            {
                HOperatorSet.Compose3(ho_image, ho_image, ho_image, out ho_image);
            }

            //获取图像尺寸
            HOperatorSet.GetImageSize(ho_image, out HTuple width0, out _);
            //创建交错格式图像
            HOperatorSet.InterleaveChannels(ho_image, out HObject InterImage, "rgb", 4 * width0, 0);
            //获取交错格式图像指针
            HOperatorSet.GetImagePointer1(InterImage, out HTuple Pointer, out _, out HTuple width, out HTuple height);
            IntPtr ptr = Pointer;
            ho_image.Dispose();
            Bitmap bitmap = new Bitmap(width / 4, height, width, PixelFormat.Format24bppRgb, ptr);

            //构建新Bitmap图像
            return new Bitmap(bitmap);

        }

        public static HObject Bitmap2Honject(Bitmap bitmap)
        {
            //暂时用不到，以后用到再写
            return null;
        }
    }
}
