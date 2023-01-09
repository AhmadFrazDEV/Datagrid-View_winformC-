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
    public partial class EditUserForm : Form
    {
        private MUser previous;
        public EditUserForm(MUser previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MUser updated = new MUser(txtUsername.Text, txtPassword.Text, txtRole.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            MUserDL.EditUserFromList(previous, updated);
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtUsername.Text = previous.Data;
            txtPassword.Text = previous.Username;
            txtRole.Text = previous.Sector;
            textBox1.Text = previous.Company;
            textBox2.Text = previous.QR_code1;
            textBox3.Text = previous.In_Time1;
            textBox4.Text = previous.Out_Time1;
        }

    }
}
