using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVisionMod.Model
{
    /// <summary>
    /// 用于对外显示相机的实时状态
    /// </summary>
    public class CamStatus
    {
        public string CamName { get; set; }
        /// <summary>
        /// true表示连接，false表示未连接
        /// </summary>
        public bool IsConnect { get; set; }

    }
}
