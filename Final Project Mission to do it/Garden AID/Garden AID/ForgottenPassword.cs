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
using System.Net;
using System.Web;
using System.Net.Mail;
using System.IO;
using System.Text.RegularExpressions;

namespace Garden_AID
{
    public partial class ForgottenPassword : Form
    {
        string passPattern = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?=.*[A-Z])(?=.*[a-z]).*$";
        public int code;
        public ForgottenPassword()
        {
            InitializeComponent();
        }

        private void ForgottenPassword_Load(object sender, EventArgs e)
        {
            TextSlide.Hide();
            CodeSend.Hide();
            CodeSubmit.Hide();
            CodeInputbar.Hide();
            NewPassBox.Hide();
            RetypePass.Hide();
            PassSubmit.Hide();
            dataGridView1.Hide();
            showBox1.Hide();
        }

        private void searchID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchIcon_Click(object sender, EventArgs e)
        {
            if (searchID.Text.All(char.IsDigit) == true)
            {
                SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
                con.Open();
                string query = "SELECT * from Information_Store WHERE Phone_No=@input;";
                SqlDataAdapter sqadp = new SqlDataAdapter(query, con);
                sqadp.SelectCommand.Parameters.AddWithValue("@input", searchID.Text);
                DataTable Dtable = new DataTable();
                sqadp.Fill(Dtable);
                dataGridView1.DataSource = Dtable;
                int count = dataGridView1.RowCount;
                if (count == 0)
                {
                    MessageBox.Show("No id found. Search again..");
                }
                else
                {
                    TextSlide.Show();
                    Random obj1 = new Random();
                    code = obj1.Next(000000, 999999);
                    string result = "";
                    WebRequest request = null;
                    HttpWebResponse response = null;
                    String to = searchID.Text; //Mobile number of user
                    String token = "838616401316609920131c6ff4ad0c009bbdbdfbb6ba4acabc49"; //generate token from site bulkSmS
                    String message = System.Uri.EscapeUriString("We’ll make this quick! Just enter this code to confirm your phone number:" + code);
                    String url = "http://api.greenweb.com.bd/api.php?token=" + token + "&to=" + to + "&message=" + message;
                    request = WebRequest.Create(url);
                    response = (HttpWebResponse)request.GetResponse();
                    Stream stream = response.GetResponseStream();
                    Encoding ec = System.Text.Encoding.GetEncoding("utf-8");
                    StreamReader reader = new
                    System.IO.StreamReader(stream, ec);
                    result = reader.ReadToEnd();
                    Console.WriteLine(result);
                    reader.Close();
                    stream.Close();
                    CodeInputbar.Show();
                    CodeSubmit.Show();
                }
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
                con.Open();
                string query = "SELECT * from Information_Store WHERE Email=@input;";
                SqlDataAdapter sqadp = new SqlDataAdapter(query, con);
                sqadp.SelectCommand.Parameters.AddWithValue("@input", searchID.Text);
                DataTable Dtable = new DataTable();
                sqadp.Fill(Dtable);
                dataGridView1.DataSource = Dtable;
                int count = dataGridView1.RowCount;
                if (count == 0)
                {
                    MessageBox.Show("No id found. Search again..");
                }
                else
                {
                    TextSlide.Show();
                    Random obj1 = new Random();
                    code = obj1.Next(000000, 999999);
                    MailMessage m1 = new MailMessage("gardenaid29@gmail.com", searchID.Text, "Security Code", "Hi, please enter the code to finish confirming your email." + code);
                    SmtpClient s1 = new SmtpClient("smtp.gmail.com");
                    s1.UseDefaultCredentials = false;
                    s1.Port = 587;
                    s1.Credentials = new NetworkCredential("gardenaid29@gmail.com", "qqotvdrgohhauxmi");
                    s1.EnableSsl = true;
                    s1.Send(m1);
                    CodeInputbar.Show();
                    CodeSubmit.Show();
                }
            }
        }

        private void CodeSubmit_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CodeInputbar.Text) == code)
            {
                NewPassBox.Show();
                RetypePass.Show();
                PassSubmit.Show();
                showBox1.Show();
            }
            else
            {
                MessageBox.Show("Not matched. Enter code again and check your phone no or email...");
                CodeInputbar.Clear();
            }
        }

        private void PassSubmit_Click(object sender, EventArgs e)
        {
            if (searchID.Text.All(Char.IsDigit) == true)
            {
                SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
                string query = "UPDATE Information_Store SET Password=@newinput where Phone_No=@input";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@newinput", NewPassBox.Text);
                cmd.Parameters.AddWithValue("@input", searchID.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password changed successfully");
                LogInPage obj = new LogInPage();
                obj.Show();
                Hide();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
                string query = "UPDATE Information_Store SET Password=@newinput where Email=@input";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@newinput", NewPassBox.Text);
                cmd.Parameters.AddWithValue("@input", searchID.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password changed successfully");
                LogInPage obj = new LogInPage();
                obj.Show();
                Hide();
            }
        }

        private void RetypePass_TextChanged(object sender, EventArgs e)
        {
            if (NewPassBox.Text != RetypePass.Text)
            {
                errorProvider3.SetError(this.RetypePass, "Did not match. Check again..");
            }
            else
            {
                errorProvider3.Clear();
            }
            if (string.IsNullOrEmpty(RetypePass.Text))
            {
                RetypePass.Focus();
                errorProvider4.SetError(this.RetypePass, "Please Re-type password");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void NewPassBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(NewPassBox.Text, passPattern) == false)
            {
                errorProvider1.SetError(this.NewPassBox, "Must contain letters (upper and lower case), numbers, and symbols and have a minimum number of each");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(NewPassBox.Text))
            {
                NewPassBox.Focus();
                errorProvider2.SetError(this.NewPassBox, "Please Enter new password");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void showBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = showBox1.Checked;
            if (check == true)
            {
                NewPassBox.UseSystemPasswordChar = false;
                RetypePass.UseSystemPasswordChar = false;
            }
            else
            {
                NewPassBox.UseSystemPasswordChar = true;
                RetypePass.UseSystemPasswordChar = true;
            }
        }
    }
}
