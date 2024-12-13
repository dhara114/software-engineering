using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LoginAndRegistration
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();    
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DatabaseMain.mdf");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (EmailText.Text == "" && PasswordText.Text == "" && ConfirmPasswordText.Text == "")
            {
                MessageBox.Show("Email and Password fields are empty", "please enter your email and password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PasswordText.Text == ConfirmPasswordText.Text)
            {
                con.Open();
                string Register = "INSERT INTO DatabaseMain VALUES ('" + EmailText.Text + "', '" + PasswordText.Text + "')";
                cmd = new OleDbCommand(Register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("You have been registered successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords entered do not match", "Please enter a matching password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordText.Text = "";
                ConfirmPasswordText.Text = "";
                PasswordText.Focus();
            }
        }

        private void ShowPasswordChkbx_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
