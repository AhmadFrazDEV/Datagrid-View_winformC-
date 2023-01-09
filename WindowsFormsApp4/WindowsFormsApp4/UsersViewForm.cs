using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.BL;
using WindowsFormsApp4.DL;

namespace WindowsFormsApp4
{
    public partial class UsersViewForm : Form
    {
        private string path = "data.txt";
        public UsersViewForm()
        {
            InitializeComponent();
            
        }

        public void dataBind()
        {
            usersGV.DataSource = null;
            usersGV.DataSource = MUserDL.UsersList;
            usersGV.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MUserDL.readDataFromFile("data.txt");
            usersGV.DataSource = MUserDL.UsersList; // introspection
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddUserForm myform = new AddUserForm();
            myform.ShowDialog();           //Show dialog does not allow to edit the previous form
            MUserDL.storeAllDataIntoFile(path);
            dataBind();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MUser user = (MUser)usersGV.CurrentRow.DataBoundItem;
            if (usersGV.Columns["Delete"].Index == e.ColumnIndex)
            {
                MUserDL.deleteUserFromList(user);
                MUserDL.storeAllDataIntoFile(path);
                dataBind();
            }
            else if (usersGV.Columns["Edit"].Index == e.ColumnIndex)
            {
                EditUserForm myform = new EditUserForm(user);
                myform.ShowDialog();
                MUserDL.storeAllDataIntoFile(path);
                dataBind();
            }
        }


        // we can add menu strips as well

        // Modal Form
    }
}
