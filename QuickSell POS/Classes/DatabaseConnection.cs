using MySql.Data.MySqlClient;
using QuickSell_POS.Classes;
using System;
using System.Data;
using System.Windows.Forms;

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
            Employee currentEmployee = new Employee(0,uName,uPass,new Role());
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
                    currentEmployee.ID = Convert.ToInt32(reader["ID"]);
                    currentEmployee.Username = reader["Username"].ToString();
                    currentEmployee.Role.RoleName = reader["Userrole"].ToString();
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
            cmd.Parameters.AddWithValue("@roleid", newEmployee.Role.RoleID);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(string.Format("New Employee {0} added", newEmployee.Username), "Success");

            }
            catch(MySqlException ex) 
            {
                if(ex.Message.Contains("Duplicate")) 
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
        public void AddCategoryQuery(Category newCategory)
        {
            MySqlConnection conn = Connect();
            MySqlCommand cmd = new MySqlCommand("AddCategory", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@catname", newCategory.Name);
            cmd.Parameters.AddWithValue("@catdesc", newCategory.Description);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(string.Format("New Category {0} added", newCategory.Name), "Success");

            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Category already exists", "Duplicate Error");
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
        public void AddProductQuery(Product newProduct) 
        {
            MySqlConnection conn = Connect();
            MySqlCommand cmd = new MySqlCommand("AddProduct", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@prodname", newProduct.productName);
            cmd.Parameters.AddWithValue("@prodprice", newProduct.ProductPrice);
            cmd.Parameters.AddWithValue("@prodstock", newProduct.ProductStock);
            cmd.Parameters.AddWithValue("@prodcategory", newProduct.ProductCategory.ID);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(string.Format("New Product {0} added", newProduct.productName), "Success");

            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Product already exists", "Duplicate Error");
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
        public int CreateSaleQuery(Sale sale) 
        {
            long lastID = 0;
            MySqlConnection conn = Connect();
            MySqlCommand cmd = new MySqlCommand("CreateSale", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            //saleamount,salediscount,saledate,saletime,salecashier
            cmd.Parameters.AddWithValue("@saleamount", sale.SaleAmount);
            cmd.Parameters.AddWithValue("@salediscount", sale.DiscountPercent);
            cmd.Parameters.AddWithValue("@saledate", sale.SaleDateTime.Date);
            cmd.Parameters.AddWithValue("@saletime", DateTime.Parse(sale.SaleDateTime.ToString()).ToString("HH:mm"));
            cmd.Parameters.AddWithValue("@salecashier", sale.SaleCashier.ID);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sale Completed Successfully", "Success");
                cmd.CommandText = "select LAST_INSERT_ID()";
                cmd.CommandType = CommandType.Text;
                MySqlDataReader reader= cmd.ExecuteReader();
                while (reader.Read())
                {
                    lastID = reader.GetInt64(0);
                }

            }
            catch (MySqlException ex)
            {
                 MessageBox.Show(ex.Message);   
            }
            finally
            {
                CloseConnection(conn);
            }
            return Convert.ToInt32(lastID);
        }
        public void AddSaleProductQuery(int saleID,SaleLineItem lineItem)
        {
            MySqlConnection conn = Connect();
            MySqlCommand cmd = new MySqlCommand("CreateSaleProduct", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@sale",saleID);
            cmd.Parameters.AddWithValue("@product",lineItem.ProductID);
            cmd.Parameters.AddWithValue("@productquantity",lineItem.Quantity);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(string.Format("Sale Product {0} added", lineItem.productName), "Success");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection(conn);
            }
        }
        public DataTable SelectAllQuery(string table)
        {
            MySqlConnection conn = Connect();
            string query = string.Format("select * from {0}",table);
            MySqlCommand cmd = new MySqlCommand(query, conn) ;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            CloseConnection(conn);
            return dt;
        }
        public DataTable FilterQuery(string table,string column, string value)
        {
            MySqlConnection conn = Connect();
            string query = string.Format("select * from {0} where {1}='{2}'",table,column,value );
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            CloseConnection(conn);
            return dt;
        }

        public void UpdateProductQuery(Product updatedProduct)
        {
            MySqlConnection conn = Connect();
            MySqlCommand cmd = new MySqlCommand("UpdateProduct", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@prodid", updatedProduct.ProductID);
            cmd.Parameters.AddWithValue("@prodname", updatedProduct.productName);
            cmd.Parameters.AddWithValue("@prodprice", updatedProduct.ProductPrice);
            cmd.Parameters.AddWithValue("@prodstock", updatedProduct.ProductStock);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(string.Format("Product with ID {0} updated", updatedProduct.ProductID), "Success");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection(conn);
            }
        }
        public void UpdateEmployeeQuery(Employee updatedEmployee)
        {
            MySqlConnection conn = Connect();
            MySqlCommand cmd = new MySqlCommand("UpdateEmployee", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@uid", updatedEmployee.ID);
            cmd.Parameters.AddWithValue("@uname", updatedEmployee.Username);
            cmd.Parameters.AddWithValue("@upass", updatedEmployee.Password);
            cmd.Parameters.AddWithValue("@urole", updatedEmployee.Role.RoleID);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(string.Format("Employee with ID {0} updated", updatedEmployee.ID), "Success");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                CloseConnection(conn);
            }
        }
        public void DeleteProductQuery(Product delProduct) 
        {
            MySqlConnection conn = Connect();
            MySqlCommand cmd = new MySqlCommand("DeleteProduct", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@prodid", delProduct.ProductID);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(string.Format("Product with ID {0} deleted", delProduct.ProductID), "Success");

            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("foreign key constraint fails"))
                {
                    MessageBox.Show("This product has already been sold, it cannot be removed from the database");
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
    }
}
