﻿using HalconDotNet;
using LSVisionMod.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Common
{
    class 字符识别 : IdentifyFun
    {
        string ocrClassifier;
        string standardText;
        int charCount;
        int lightOnDark;
        float row1, column1, row2, column2;
        HObject ho_inRegion;
        string result;
        public 字符识别(TestItem testItem)
        {
            this.camName = testItem.CamName;
            this.matchName = testItem.MatchName;
            this.name = testItem.Name;
            Create(testItem.Parameters);
        }

        public override void Create(List<Parameter> inParameters)
        {
            ocrClassifier = MyRun.appPath + "\\OCR\\" + inParameters[0].value as string;
            standardText = inParameters[1].value as string;
            charCount = int.Parse(inParameters[2].value.ToString());
            lightOnDark = (bool)inParameters[3].value ? 1 : 0;
            JArray lists = inParameters[4].value as JArray;
            row1 = (float)lists[0];
            column1 = (float)lists[1];
            row2 = (float)lists[2];
            column2 = (float)lists[3];
            HOperatorSet.GenRectangle1(out ho_inRegion, row1, column1, row2, column2);
        }

        public override int Find(HObject inImage)
        {
            HTuple hv_Word;
            int nRet = myOcrSplit(inImage, ho_inRegion, ocrClassifier, standardText, charCount, 0, lightOnDark, out hv_Word);
            outMessage = hv_Word.S;
            isOK = nRet == 0 ? true : false;
            result = nRet == 0 ? "OK" : "NG";
            return nRet;
        }

        public override void Show(HObject inImage, out HObject resultImage)
        {
            HObject tmpImage;
            PaintOkNgRegion(inImage, ho_inRegion, out tmpImage, result, 11);
            HOperatorSet.HeightWidthRatio(ho_inRegion, out HTuple height, out HTuple width, out _);
            CutImage(tmpImage, ho_inRegion, out resultImage, height.D / 4, width.D / 4);
            tmpImage.Dispose();
        }
        public override void Show(HObject inImage, HTuple homMat2D, out HObject resultImage)
        {
            HObject tmpImage;
            HObject regionAffineTrans;
            HOperatorSet.AffineTransRegion(ho_inRegion, out regionAffineTrans, homMat2D, "nearest_neighbor");
            PaintOkNgRegion(inImage, regionAffineTrans, out tmpImage, result, 11);
            HOperatorSet.ShapeTrans(regionAffineTrans, out regionAffineTrans, "rectangle1");
            HOperatorSet.HeightWidthRatio(regionAffineTrans, out HTuple height, out HTuple width, out _);
            CutImage(tmpImage, regionAffineTrans, out resultImage, height.D / 4, width.D / 4);

            tmpImage.Dispose();
            regionAffineTrans.Dispose();
        }

        public static void PaintOkNgRegion(HObject ho_image, HObject ho_region, out HObject ho_outImage,
            HTuple hv_okNg, HTuple hv_lineWidth)
        {
            HObject ho_DupImage1, ho_DupImage2, ho_DupImage3;
            HObject ho_RegionErosion, ho_RegionDifference, ho_ComposeImage;
            HOperatorSet.CountChannels(ho_image, out HTuple hv_Channels);
            if (hv_Channels.D == 1)
            {
                HOperatorSet.CopyImage(ho_image, out ho_DupImage1);
                HOperatorSet.CopyImage(ho_image, out ho_DupImage2);
                HOperatorSet.CopyImage(ho_image, out ho_DupImage3);
            }
            else if (hv_Channels.D == 3)
            {
                HOperatorSet.Decompose3(ho_image, out ho_DupImage1, out ho_DupImage2, out ho_DupImage3);
            }
            else
            {
                throw new Exception("图片通道数异常");
            }

            HOperatorSet.ErosionRectangle1(ho_region, out ho_RegionErosion, hv_lineWidth, hv_lineWidth);
            HOperatorSet.Difference(ho_region, ho_RegionErosion, out ho_RegionDifference);

            if ((int)(new HTuple(hv_okNg.TupleEqual("OK"))) != 0)
            {
                HOperatorSet.PaintRegion(ho_RegionDifference, ho_DupImage1, out ho_DupImage1, 0, "fill");
                HOperatorSet.PaintRegion(ho_RegionDifference, ho_DupImage2, out ho_DupImage2, 255, "fill");
                HOperatorSet.PaintRegion(ho_RegionDifference, ho_DupImage3, out ho_DupImage3, 0, "fill");
            }
            else
            {
                HOperatorSet.PaintRegion(ho_RegionDifference, ho_DupImage1, out ho_DupImage1, 255, "fill");
                HOperatorSet.PaintRegion(ho_RegionDifference, ho_DupImage2, out ho_DupImage2, 0, "fill");
                HOperatorSet.PaintRegion(ho_RegionDifference, ho_DupImage3, out ho_DupImage3, 0, "fill");
            }

            HOperatorSet.Compose3(ho_DupImage1, ho_DupImage2, ho_DupImage3, out ho_ComposeImage);

            ho_outImage = ho_ComposeImage.CopyObj(1, -1);


            ho_ComposeImage.Dispose();
            ho_DupImage1.Dispose();
            ho_DupImage2.Dispose();
            ho_DupImage3.Dispose();

            ho_RegionErosion.Dispose();
            ho_RegionDifference.Dispose();
        }

        public static void CutImage(HObject ho_image, HObject ho_region, out HObject ho_outImage, HTuple hv_edgeHeight, HTuple hv_edgeWidth)
        {
            HOperatorSet.GenEmptyObj(out HObject ho_Image);
            HOperatorSet.GenEmptyObj(out HObject ho_RegionDilation);
            HOperatorSet.GenEmptyObj(out HObject ho_ImageReduced);

            ho_Image.Dispose();
            HOperatorSet.CopyImage(ho_image, out ho_Image);
            ho_RegionDilation.Dispose();
            HOperatorSet.DilationRectangle1(ho_region, out ho_RegionDilation, hv_edgeHeight, hv_edgeWidth);
            ho_ImageReduced.Dispose();
            HOperatorSet.ReduceDomain(ho_Image, ho_RegionDilation, out ho_ImageReduced);
            HOperatorSet.CropDomain(ho_ImageReduced, out ho_outImage);
            ho_Image.Dispose();
            ho_RegionDilation.Dispose();
            ho_ImageReduced.Dispose();
        }
        public int myOcrSplit(HObject ho_inImage, HObject ho_inRegion, HTuple hv_ocrClassifier,
            HTuple hv_standardText, HTuple hv_charCount, HTuple hv_returnPunctuation, HTuple hv_lightOnDark,
            out HTuple hv_Word)
        {

            // Local iconic variables 

            HObject ho_Timg1 = null, ho_ImageReduced, ho_Region = null;
            HObject ho_Characters = null;

            // Local control variables 

            HTuple hv_step = null, hv_stepMax = null, hv_useEnhanced = null;
            HTuple hv_TextModel = null, hv_OCRHandle = null, hv_RegularExpression = null;
            HTuple hv_UsedThreshold = new HTuple(), hv_Area = new HTuple();
            HTuple hv_Row = new HTuple(), hv_Column = new HTuple();
            HTuple hv_Area1 = new HTuple(), hv_Row1 = new HTuple();
            HTuple hv_Column1 = new HTuple(), hv_findText = new HTuple();
            HTuple hv_bufferCount = new HTuple(), hv_bufferMincontrast = new HTuple();
            HTuple hv_Index = new HTuple(), hv_add = new HTuple();
            HTuple hv_TextResultID = new HTuple(), hv_Class = new HTuple();
            HTuple hv_Confidence = new HTuple(), hv_Score = new HTuple();
            HTuple hv_Number = new HTuple(), hv_ScoreSum = new HTuple();
            HTuple hv_Index1 = new HTuple(), hv_Length = new HTuple();
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Timg1);
            HOperatorSet.GenEmptyObj(out ho_ImageReduced);
            HOperatorSet.GenEmptyObj(out ho_Region);
            HOperatorSet.GenEmptyObj(out ho_Characters);
            hv_Word = new HTuple();

            ho_Timg1.Dispose();
            ho_Timg1 = ho_inImage.CopyObj(1, -1);

            ho_ImageReduced.Dispose();
            HOperatorSet.ReduceDomain(ho_Timg1, ho_inRegion, out ho_ImageReduced);
            hv_step = 3;
            hv_stepMax = 25;
            hv_useEnhanced = 1;
            HOperatorSet.CreateTextModelReader("auto", hv_ocrClassifier, out hv_TextModel);
            HOperatorSet.ReadOcrClassCnn(hv_ocrClassifier, out hv_OCRHandle);
            HOperatorSet.SetTextModelParam(hv_TextModel, "separate_touching_chars", "enhanced");

            HOperatorSet.SetTextModelParam(hv_TextModel, "return_separators", "true");
            HOperatorSet.SetTextModelParam(hv_TextModel, "add_fragments", "true");
            HOperatorSet.SetTextModelParam(hv_TextModel, "return_punctuation", hv_returnPunctuation == 0 ? "false" : "true");
            //RegularExpression := ''

            //字符串转正则表达式
            myStringToRegular(hv_standardText, out hv_RegularExpression);
            hv_RegularExpression = ("(" + hv_RegularExpression) + ")";


            //判断是否需要反转颜色
            if ((int)(new HTuple(hv_lightOnDark.TupleEqual(1))) != 0)
            {

                HObject ExpTmpOutVar_0;
                HOperatorSet.InvertImage(ho_ImageReduced, out ExpTmpOutVar_0);
                ho_ImageReduced.Dispose();
                ho_ImageReduced = ExpTmpOutVar_0;

            }
            else if ((int)(new HTuple(hv_lightOnDark.TupleEqual(2))) != 0)
            {
                //自动判断是否反转颜色，金工之前的项目中并未使用该功能
                ho_Region.Dispose();
                HOperatorSet.BinaryThreshold(ho_ImageReduced, out ho_Region, "max_separability",
                    "dark", out hv_UsedThreshold);
                HOperatorSet.AreaCenter(ho_ImageReduced, out hv_Area, out hv_Row, out hv_Column);
                HOperatorSet.AreaCenter(ho_Region, out hv_Area1, out hv_Row1, out hv_Column1);
                if ((int)(new HTuple(hv_Area1.TupleGreater(hv_Area / 2))) != 0)
                {
                    {
                        HObject ExpTmpOutVar_0;
                        HOperatorSet.InvertImage(ho_ImageReduced, out ExpTmpOutVar_0);
                        ho_ImageReduced.Dispose();
                        ho_ImageReduced = ExpTmpOutVar_0;
                    }
                }
            }
            //以置信度最高为分割目标
            if ((int)(new HTuple(hv_charCount.TupleEqual(0))) != 0)
            {
                hv_findText = 0;
                hv_bufferCount = 0;
                hv_bufferMincontrast = 5;
                HTuple end_val52 = hv_stepMax;
                HTuple step_val52 = 1;
                for (hv_Index = 1; hv_Index.Continue(end_val52, step_val52); hv_Index = hv_Index.TupleAdd(step_val52))
                {

                    hv_add = hv_step * hv_Index;
                    HOperatorSet.SetTextModelParam(hv_TextModel, "min_contrast", hv_add);
                    HOperatorSet.FindText(ho_ImageReduced, hv_TextModel, out hv_TextResultID);
                    ho_Characters.Dispose();
                    HOperatorSet.GetTextObject(out ho_Characters, hv_TextResultID, "all_lines");
                    HOperatorSet.DoOcrWordCnn(ho_Characters, ho_ImageReduced, hv_OCRHandle, hv_RegularExpression,
                        3, 10, out hv_Class, out hv_Confidence, out hv_Word, out hv_Score);
                    HOperatorSet.CountObj(ho_Characters, out hv_Number);
                    HOperatorSet.TupleSum(hv_Confidence, out hv_ScoreSum);
                    HOperatorSet.TupleFindFirst(hv_Class, "\x1A", out hv_Index1);
                    if ((int)((new HTuple(hv_bufferCount.TupleLess(hv_ScoreSum))).TupleAnd(new HTuple(hv_Index1.TupleEqual(
                        -1)))) != 0)
                    {
                        hv_findText = 1;
                        hv_bufferCount = hv_ScoreSum.Clone();
                        hv_bufferMincontrast = hv_add.Clone();
                    }
                }
                HOperatorSet.SetTextModelParam(hv_TextModel, "min_contrast", hv_bufferMincontrast);
                HOperatorSet.FindText(ho_ImageReduced, hv_TextModel, out hv_TextResultID);
                ho_Characters.Dispose();
                HOperatorSet.GetTextObject(out ho_Characters, hv_TextResultID, "all_lines");
                HOperatorSet.DoOcrWordCnn(ho_Characters, ho_ImageReduced, hv_OCRHandle, hv_RegularExpression,
                    3, 10, out hv_Class, out hv_Confidence, out hv_Word, out hv_Score);

            }


            //以识别字符为固定长度为分割目标
            if ((int)(new HTuple(hv_charCount.TupleGreater(0))) != 0)
            {
                hv_findText = 0;
                hv_bufferCount = 0;
                hv_bufferMincontrast = 5;
                HTuple end_val86 = hv_stepMax;
                HTuple step_val86 = 1;
                for (hv_Index = 1; hv_Index.Continue(end_val86, step_val86); hv_Index = hv_Index.TupleAdd(step_val86))
                {

                    hv_add = hv_step * hv_Index;
                    HOperatorSet.SetTextModelParam(hv_TextModel, "min_contrast", hv_add);
                    HOperatorSet.FindText(ho_ImageReduced, hv_TextModel, out hv_TextResultID);
                    ho_Characters.Dispose();
                    HOperatorSet.GetTextObject(out ho_Characters, hv_TextResultID, "all_lines");

                    HOperatorSet.CountObj(ho_Characters, out hv_Number);

                    if ((int)(new HTuple(hv_charCount.TupleEqual(hv_Number))) != 0)
                    {
                        hv_findText = 1;
                        //
                        HOperatorSet.DoOcrWordCnn(ho_Characters, ho_ImageReduced, hv_OCRHandle,
                            hv_RegularExpression, 3, 10, out hv_Class, out hv_Confidence, out hv_Word,
                            out hv_Score);
                        HOperatorSet.TupleSum(hv_Confidence, out hv_ScoreSum);
                        HOperatorSet.TupleFindFirst(hv_Class, "\x1A", out hv_Index1);
                        if ((int)((new HTuple(hv_bufferCount.TupleLess(hv_ScoreSum))).TupleAnd(
                            new HTuple(hv_Index1.TupleEqual(-1)))) != 0)
                        {
                            hv_findText = 1;
                            hv_bufferCount = hv_ScoreSum.Clone();
                            hv_bufferMincontrast = hv_add.Clone();
                        }

                    }

                }
                //以置信度最高为分割目标 再识别一次
                //if (findText == 0)
                HOperatorSet.SetTextModelParam(hv_TextModel, "min_contrast", hv_bufferMincontrast);
                HOperatorSet.FindText(ho_ImageReduced, hv_TextModel, out hv_TextResultID);
                ho_Characters.Dispose();
                HOperatorSet.GetTextObject(out ho_Characters, hv_TextResultID, "all_lines");
                HOperatorSet.DoOcrWordCnn(ho_Characters, ho_ImageReduced, hv_OCRHandle, hv_RegularExpression,
                    3, 10, out hv_Class, out hv_Confidence, out hv_Word, out hv_Score);
                //endif
            }

            //使用标准文本对比
            if ((int)(new HTuple(hv_charCount.TupleLess(0))) != 0)
            {

                //判断是否和标准文本一致

                hv_findText = 0;
                hv_bufferCount = 0;
                hv_bufferMincontrast = 5;
                HTuple end_val130 = hv_stepMax;
                HTuple step_val130 = 1;
                for (hv_Index = 1; hv_Index.Continue(end_val130, step_val130); hv_Index = hv_Index.TupleAdd(step_val130))
                {
                    hv_add = hv_step * hv_Index;
                    HOperatorSet.SetTextModelParam(hv_TextModel, "min_contrast", hv_add);
                    HOperatorSet.FindText(ho_ImageReduced, hv_TextModel, out hv_TextResultID);
                    ho_Characters.Dispose();
                    HOperatorSet.GetTextObject(out ho_Characters, hv_TextResultID, "all_lines");
                    HOperatorSet.CountObj(ho_Characters, out hv_Number);
                    HOperatorSet.TupleStrlen(hv_standardText, out hv_Length);
                    if ((int)(new HTuple(hv_Length.TupleNotEqual(hv_Number))) != 0)
                    {
                        continue;
                    }
                    HOperatorSet.DoOcrWordCnn(ho_Characters, ho_ImageReduced, hv_OCRHandle, hv_RegularExpression,
                        5, 10, out hv_Class, out hv_Confidence, out hv_Word, out hv_Score);

                    if ((int)(new HTuple(hv_Word.TupleEqual(hv_standardText))) != 0)
                    {
                        hv_findText = 1;
                        break;
                    }

                    HOperatorSet.TupleSum(hv_Confidence, out hv_ScoreSum);
                    HOperatorSet.TupleFindFirst(hv_Class, "\x1A", out hv_Index1);
                    if ((int)((new HTuple(hv_bufferCount.TupleLess(hv_ScoreSum))).TupleAnd(new HTuple(hv_Index1.TupleEqual(
                        -1)))) != 0)
                    {

                        hv_bufferCount = hv_ScoreSum.Clone();
                        hv_bufferMincontrast = hv_add.Clone();
                    }
                }
                //以置信度最高为分割目标 再识别一次
                if ((int)(new HTuple(hv_findText.TupleEqual(0))) != 0)
                {
                    HOperatorSet.SetTextModelParam(hv_TextModel, "min_contrast", hv_bufferMincontrast);
                    HOperatorSet.FindText(ho_ImageReduced, hv_TextModel, out hv_TextResultID);
                    ho_Characters.Dispose();
                    HOperatorSet.GetTextObject(out ho_Characters, hv_TextResultID, "all_lines");
                    HOperatorSet.DoOcrWordCnn(ho_Characters, ho_ImageReduced, hv_OCRHandle, hv_RegularExpression,
                        5, 10, out hv_Class, out hv_Confidence, out hv_Word, out hv_Score);
                }
            }
            HOperatorSet.ClearTextModel(hv_TextModel);
            HOperatorSet.ClearOcrClassCnn(hv_OCRHandle);
            ho_Timg1.Dispose();
            ho_ImageReduced.Dispose();
            ho_Region.Dispose();
            ho_Characters.Dispose();

            int nRet = 1;
            if (hv_findText == 1) nRet = 0;
            return nRet;
        }

        public void myStringToRegular(HTuple hv_standardText, out HTuple hv_getRegular)
        {
            HTuple hv_regularModel = null, hv_Length = null;
            HTuple hv_Index2 = null, hv_Index3 = new HTuple(), hv_Selected = new HTuple();
            HTuple hv_Matches = new HTuple(), hv_Length2 = new HTuple();
            // Initialize local and output iconic variables 
            hv_getRegular = "";

            hv_regularModel = new HTuple();
            hv_regularModel[0] = "[0-9]";
            hv_regularModel[1] = "[A-Z]";
            hv_regularModel[2] = "[a-z]";
            hv_regularModel[3] = ".";
            HOperatorSet.TupleStrlen(hv_standardText, out hv_Length);

            HTuple end_val5 = hv_Length - 1;
            HTuple step_val5 = 1;
            for (hv_Index2 = 0; hv_Index2.Continue(end_val5, step_val5); hv_Index2 = hv_Index2.TupleAdd(step_val5))
            {
                for (hv_Index3 = 0; (int)hv_Index3 <= 3; hv_Index3 = (int)hv_Index3 + 1)
                {
                    HOperatorSet.TupleStrBitSelect(hv_standardText, hv_Index2, out hv_Selected);
                    HOperatorSet.TupleRegexpMatch(hv_Selected, hv_regularModel.TupleSelect(hv_Index3),
                        out hv_Matches);

                    HOperatorSet.TupleStrlen(hv_Matches, out hv_Length2);
                    if ((int)(new HTuple(hv_Length2.TupleEqual(1))) != 0)
                    {
                        if ((int)(new HTuple(((hv_regularModel.TupleSelect(hv_Index3))).TupleNotEqual("."))) != 0)
                        {
                            hv_getRegular = hv_getRegular + (hv_regularModel.TupleSelect(hv_Index3));
                            break;
                        }
                        else
                        {
                            hv_getRegular = hv_getRegular + hv_Selected;
                        }
                    }
                }
            }
            return;
        }
    }
}
