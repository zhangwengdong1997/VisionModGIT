using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserInfo
    {
        private string m_UserName;
        private string m_PassWord;
        private string m_Permission;

        public string UserName { get => m_UserName; set => m_UserName = value; }
        public string PassWord { get => m_PassWord; set => m_PassWord = value; }
        public string Permission { get => m_Permission; set => m_Permission = value; }
    }
}
