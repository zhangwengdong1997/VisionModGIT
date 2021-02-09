using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserManager
    {
        /// <summary>
        /// 登录判断
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="res"></param>
        /// <returns></returns>
        public bool UserLogIn(Model.UserInfo userInfo, out int res)
        {
            //待实现：数据库根据用户名查找用户

            //待实现：比较密码




            //测试用*********************************************
            res = 0;
            //***************************************************

            return true;
        }

        /// <summary>
        /// 获取全部的用户名
        /// </summary>
        /// <param name="allUsersName"></param>
        /// <returns></returns>
        public bool GetAllUsersNameList(out List<string> allUsersName)
        {
            allUsersName = new List<string>();

            //待实现：数据库查询全部的用户名


            //测试用*********************************************
            allUsersName.Add("Administrator");
            allUsersName.Add("李四");
            allUsersName.Add("张三");
            //***************************************************

            return true;
        }

        /// <summary>
        /// 获取全部的用户权限
        /// </summary>
        /// <param name="allUsersPermission"></param>
        /// <returns></returns>
        public bool GetAllUsersPermissionList(out List<string> allUsersPermission)
        {
            allUsersPermission = new List<string>();

            //待实现：数据库查询全部的用户权限

            //测试用*********************************************
            allUsersPermission.Add("管理员");
            allUsersPermission.Add("工程师");
            allUsersPermission.Add("操作员");
            //***************************************************

            return true;
        }

    }
}
