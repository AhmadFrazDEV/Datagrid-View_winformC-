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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MUser user = new MUser(txtUsername.Text , txtPassword.Text , txtRole.Text , textBox1.Text , textBox2.Text , textBox3.Text , textBox4.Text);
            MUserDL.addUserIntoList(user);
            this.Close();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
