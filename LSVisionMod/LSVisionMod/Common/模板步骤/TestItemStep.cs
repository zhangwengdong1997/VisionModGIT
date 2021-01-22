using LSVisionMod.Model;
using LSVisionMod.View.检测功能;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Common.模板步骤
{
    /// <summary>
    /// 选择检测功能，选择检测区域，设置检测参数，添加检测项
    /// </summary>
    class TestItemStep
    {
        /// <summary>
        /// 获取检测功能名队列
        /// </summary>
        /// <param name="TestItemTypes"></param>
        /// <returns></returns>
        public static bool GetTestItemTypeList(out List<string> TestItemTypes)
        {
            return MyRun.GetTestItemTypeList(out TestItemTypes);
        }
        /// <summary>
        /// 获取检测功能参数设置的控件
        /// </summary>
        /// <param name="TestItemType"></param>
        /// <param name="ParameterSetControl"></param>
        /// <returns></returns>
        public static bool GetParameterSettingControl(string TestItemType, out I检测参数设置 ParameterSetControl)
        {
            return MyRun.GetParameterSettingControl(TestItemType, out ParameterSetControl);
        }

        public static bool AddTestItem(string TestItemName, string testItemType, List<Parameter> parameters, NowModel nowModel, ref ProductModel model)
        {
            TestItem testItem = model.testItems.Find(x => x.Name == TestItemName);
            if (testItem is null)
            {
                testItem = new TestItem
                {
                    Name = TestItemName,
                    CamName = nowModel.CamName,
                    MatchName = nowModel.MatchName,
                    Type = testItemType,
                    Parameters = parameters
                };
                model.testItems.Add(testItem);
                return true;
            }
            else
            {
                testItem.CamName = nowModel.CamName;
                testItem.MatchName = nowModel.MatchName;
                testItem.Type = testItemType;
                testItem.Parameters = parameters;
                return false;
            }
            
        }
    }
}
