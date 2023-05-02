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
        private string empUName;
        private string empUPass;
        private string empRole;

        public Employee()
        {
            empUName = "";
            empUPass = "";
            empRole = "";
        }

        public Employee(string username, string password)
        {
            empUName = username;
            empUPass = password;
        }
        public Employee(string username, string password,string role)
        {
            empUName = username;
            empUPass = password;
            empRole = role;
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
        public string Role
        {
            get { return empRole; }
            set { empRole = value; }
        }

        public bool Login(int count)
        {
            if( count == 1)
            { 
                return true;
            }
            else
            {
                return false;
            }
        }

        public override String  ToString()
        {
            return string.Format("{0} \n {1} \n {2}",Username,Password,Role);
        }
    }
}
