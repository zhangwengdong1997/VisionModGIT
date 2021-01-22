using LSVisionMod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSVisionMod.Common.模板步骤
{
    /// <summary>
    /// 创建匹配模板，测试匹配模板
    /// </summary>
    class MatchingStep
    {
        public static bool GetMatchingTypeList(out List<string> matchTypes)
        {
            return MyRun.GetMatchingTypeList(out matchTypes);
        }

        public static bool AddMatching(string matchName, string matchType, string camName, ref ProductModel model)
        {
            Matching matching = model.matchings.Find(x => x.Name == matchName);
            if (matching is null)
            {
                matching = new Matching()
                {
                    Name = matchName,
                    CamName = camName,
                    Type = matchType
                };
                model.matchings.Add(matching);
                return true;
            }
            else
            {
                matching.CamName = camName;
                matching.Type = matchType;
                return false;
            }
        }

    }
}
