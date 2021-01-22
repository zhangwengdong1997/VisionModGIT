using HalconDotNet;
using LSVisionMod.Model;

namespace LSVisionMod.Common
{
    public abstract class MatchingFun
    {
        /// <summary>
        /// 定位功能类型名称
        /// </summary>
        public string type;
        /// <summary>
        /// 输出的定位轮廓
        /// </summary>
        public HObject outContour;
        /// <summary>
        /// 输出的定位模板的ID
        /// </summary>
        public HTuple outModelID;
        /// <summary>
        /// 输入的区域
        /// </summary>
        public HObject inRegion;
        /// <summary>
        /// 输入的图片
        /// </summary>
        public HObject inImage;
        /// <summary>
        /// 最小匹配率
        /// </summary>
        public double minScore = -1;
        /// <summary>
        /// 仿射变换矩阵
        /// </summary>
        public HTuple homMat2D;
        /// <summary>
        /// 使用的模板
        /// </summary>
        public Matching matching;
        /// <summary>
        /// 创建定位模板
        /// </summary>
        /// <param name="inImage"></param>
        /// <param name="inRegion"></param>
        public abstract void Create(HObject inImage, HObject inRegion);

        /// <summary>
        /// 匹配定位模板，矫正图片位置
        /// </summary>
        /// <param name="inImage"></param>
        /// <param name="outImage"></param>
        /// <returns></returns>
        public abstract int Find(HObject inImage, out HObject outImage);

        /// <summary>
        /// 匹配定位模板，矫正图片位置
        /// </summary>
        /// <param name="inImage"></param>
        /// <param name="outImage"></param>
        /// <param name="Score"></param>
        /// <returns></returns>
        public abstract int Find(HObject inImage, out HObject outImage, out double Score);

        /// <summary>
        /// 释放定位模板
        /// </summary>
        public abstract void Release();
        /// <summary>
        /// 保存定位模板
        /// </summary>
        /// <param name="sFolderPath"></param>
        /// <param name="matchingName"></param>
        public abstract void Write(string sFolderPath, string matchingName);
        /// <summary>
        /// 读取定位模板
        /// </summary>
        /// <param name="sFolderPath"></param>
        /// <param name="mathing"></param>
        public abstract void Read(string sFolderPath, Matching matching);

    }
}
