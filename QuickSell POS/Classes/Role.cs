using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSell_POS.Classes
{
    public class Role
    {
        private int roleID;
        private string roleName;

        public int RoleID
        {
            get { return roleID; }
            set { roleID = value; }
        }

        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }

        public Role() 
        {
            roleID = 0;
            roleName = "";
        }

        public Role(int id, string name) 
        {
            roleID = id;
            roleName = name;
        }
    }
}
