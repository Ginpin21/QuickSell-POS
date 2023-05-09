using QuickSell_POS.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSell_POS
{
    public class Employee
    {
        private int empID;
        private string empUName;
        private string empUPass;
        private Role empRole;

        public Employee()
        {
            empID = 0;
            empUName = "";
            empUPass = "";
            empRole = new Role();
        }

        public Employee(int id,string username, string password,Role role)
        {
            empID = id;
            empUName = username;
            empUPass = password;
            empRole = role;
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public string Username
        {
            get { return empUName; }
            set { empUName = value; }
        }

        public string Password
        {
            get { return empUPass; } 
            set { empUPass = value; }
        }
        public Role Role
        {
            get { return empRole; }
            set { empRole = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} \n {1} \n {2}",Username,Password,Role.RoleName);
        }
    }
}
