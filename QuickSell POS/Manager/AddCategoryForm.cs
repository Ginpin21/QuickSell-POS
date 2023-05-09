using QuickSell_POS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSell_POS.Manager
{
    public partial class AddCategoryForm : UserControl
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            if(CategoryNameTxtInput.Text!="" && CategoryDescriptionTxtInput.Text !="") 
            {
                Category newCategory = new Category(0,CategoryNameTxtInput.Text, CategoryDescriptionTxtInput.Text);
                DatabaseConnection dbCon = new DatabaseConnection("localhost", "root", "", "pos_system");
                dbCon.AddCategoryQuery(newCategory);
                CategoryNameTxtInput.Text = "";
                CategoryDescriptionTxtInput.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Empty Field Error");
            }
        }
    }
}
