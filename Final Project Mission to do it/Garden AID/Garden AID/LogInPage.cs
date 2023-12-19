using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Garden_AID
{
    public partial class LogInPage : Form
    {
        public static string emailorphone;
        public LogInPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void email_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
            con.Open();
            string query = "SELECT * FROM Information_Store WHERE Phone_No=@inputValue or Email=@inputValue";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@inputValue", email.Text);
            SqlDataReader readdata = cmd.ExecuteReader();
            if (readdata.HasRows == false)
            {
                MessageBox.Show("You do not have account. Please create an account");
                email.Clear();
            }
            if (string.IsNullOrEmpty(email.Text))
            {
                email.Focus();
                Emailandphn.SetError(this.email,"Please Enter Email");
            }
            else
            {
                Emailandphn.Clear();
            }
            emailorphone = email.Text;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Paassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Paassword.Text))
            {
                Paassword.Focus();
                passworderror.SetError(this.Paassword, "Please Enter Password");
            }
            else
            {
                passworderror.Clear();
            }
        }

        private void Paassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            CreateAccountPage obj = new CreateAccountPage();
            obj.Show();
            Hide();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
            string query = "SELECT * FROM Information_Store WHERE Phone_No=@inputNumber1 or Email=@inputNumber2 and Password=@inputPassword";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@inputNumber1", email.Text);
            cmd.Parameters.AddWithValue("@inputNumber2", email.Text);
            cmd.Parameters.AddWithValue("@inputPassword", Paassword.Text);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                Homapage obj = new Homapage();
                obj.Show();
                Hide();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Log in faild. Check your number or email and password...");
                connection.Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            bool check = showpass.Checked;
            if (check == true)
            {
                Paassword.UseSystemPasswordChar = false;
            }
            else
            {
                Paassword.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgottenPassword obj = new ForgottenPassword();
            obj.Show();
        }
    }
}
