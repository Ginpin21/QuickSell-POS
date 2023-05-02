using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace QuickSell_POS
{
    public class DatabaseConnection
    {
        private string server;
        private string username;
        private string password;
        private string database;

        public string Server 
        {
            get { return server; }
            set { server = value; }
        }
        public string Username 
        { 
            get { return username; } 
            set { username = value; } 
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Database 
        {
            get { return database; }
            set { database = value; }
        }


        public DatabaseConnection(
            string server, 
            string uname, 
            string pass, 
            string db) 
        {
            Server = server;
            Username = uname;        
            Password = pass;
            Database = db;
        }
        public MySqlConnection Connect() {
            string connString = String.Format(
                "server={0};uid={1};pwd={2};database={3}",
                Server,Username,Password,Database);
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            return conn;
        }

        public void CloseConnection(MySqlConnection connection)
        {
            connection.Close();
        }

        public Employee UserAuthQuery(string uName,string uPass)
        {
            MySqlConnection conn = Connect();
            Employee currentEmployee = new Employee(uName,uPass);
            MySqlCommand cmd = new MySqlCommand("GetUserAuth", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@uname", uName);
            cmd.Parameters.AddWithValue("@upass", uPass);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    currentEmployee.Username = reader["Username"].ToString();
                    currentEmployee.Role = reader["Userrole"].ToString();

                }
                reader.Close();
                CloseConnection(conn);
                return currentEmployee;
            }
            else
            {
                MessageBox.Show("Invalid credentials","Login Error");
                reader.Close();
                CloseConnection(conn);
                return null;
            }           
        }

        public void AddEmployeeQuery(Employee newEmployee) 
        {
            MySqlConnection conn = Connect();
            MySqlCommand cmd = new MySqlCommand("AddEmployee", conn) 
            { 
                CommandType=CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@uname", newEmployee.Username);
            cmd.Parameters.AddWithValue("@upass", newEmployee.Password);
            cmd.Parameters.AddWithValue("@rolename", newEmployee.Role);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(string.Format("New Employee {0} added", newEmployee.Username), "Success");

            }
            catch(MySqlException ex) 
            {
                if(ex.Message.Contains("Duplicate Entry")) 
                {
                    MessageBox.Show("Employee Account already exists", "Duplicate Error");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                CloseConnection(conn);
            }
        }
 
        public ArrayList SelectAllQuery(string table)
        {
            MySqlConnection conn = Connect();
            String query = String.Format("select * from {0}",table);
            MySqlCommand cmd = new MySqlCommand(query, conn) ;
            MySqlDataReader reader = cmd.ExecuteReader();
            ArrayList l1 = new ArrayList();
            while (reader.Read())
            {
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    l1.Add(reader.GetString(i));
                }
            }
            Debug.WriteLine(l1[0]);
            return l1;
        }

    }
}
