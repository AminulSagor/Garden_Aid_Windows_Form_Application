using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Web;
using System.Net.Mail;
using System.IO;


namespace Garden_AID
{
    public partial class CreateAccountPage : Form
    {
        public static int number;
        public static string s1;
        public static string s2;
        DataRow DATr;
        int check = 0;
        string Emailpattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        string passPattern = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?=.*[A-Z])(?=.*[a-z]).*$";
        public CreateAccountPage()
        {
            InitializeComponent();
            MakeComboCountry();
        }

        private void CreateAccountPage_Load(object sender, EventArgs e)
        {

        }

        private void BirthdaySelect_Click(object sender, EventArgs e)
        {

        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            if ((FirstName.Text != null) && (LastName.Text != null) && (EmailandPhn != null) && (Passwordbox.Text != null) && (Passwordbox.Text == textBox1.Text) && (comboBox1.SelectedItem != null) &&
                (comboBox2.SelectedItem != null) && (comboBox3.SelectedItem != null) && ((radioButton1.Checked == true) || (radioButton2.Checked == true) || (radioButton3.Checked == true)) &&
                (comboBox5.SelectedItem != null) && (comboBox6.SelectedItem != null))
            {
                SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
                string query = "INSERT INTO Information_Store (First_Name,Last_Name,Phone_No,Email,Password,Gander,Location_Country,Location_City,Date1,Month1,Year1) VALUES (@F_name,@L_name,@Phn_no,@email,@pass,@gender,@country,@city,@dob1,@dob2,@dob3)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@F_name", FirstName.Text);
                cmd.Parameters.AddWithValue("@L_name", LastName.Text);
                if (EmailandPhn.Text.All(Char.IsDigit) == true)
                {
                    cmd.Parameters.AddWithValue("@phn_no", EmailandPhn.Text);
                    check++;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@email", EmailandPhn.Text);
                    check = 0;
                }
                if (check == 0)
                {
                    cmd.Parameters.AddWithValue("@phn_no", " ");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@email", " ");
                }
                cmd.Parameters.AddWithValue("@pass", Passwordbox.Text);
                if (radioButton1.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@gender", "Female");
                }
                else if (radioButton2.Checked == true) 
                {
                    cmd.Parameters.AddWithValue("@gender", "Male");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@gender", radioButton3.Text);
                }
                cmd.Parameters.AddWithValue("@country", comboBox5.Text);
                cmd.Parameters.AddWithValue("@city", comboBox6.Text);
                cmd.Parameters.AddWithValue("@dob1", Convert.ToInt32(comboBox1.SelectedItem));
                cmd.Parameters.AddWithValue("@dob2", comboBox2.SelectedItem);
                cmd.Parameters.AddWithValue("@dob3", Convert.ToInt32(comboBox3.SelectedItem));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                s2 = FirstName.Text;
                s1 = EmailandPhn.Text;
                if (EmailandPhn.Text.All(Char.IsDigit) == true)
                {
                    Random obj1 = new Random();
                    number = obj1.Next(0000, 9999);
                    string result = "";
                    WebRequest request = null;
                    HttpWebResponse response = null;
                    String to = EmailandPhn.Text; //Mobile number of user
                    String token = "838616401316609920131c6ff4ad0c009bbdbdfbb6ba4acabc49"; //generate token from site bulkSmS
                    String message = System.Uri.EscapeUriString("We’ll make this quick! Just enter this code to confirm your phone number:"+number);
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
                }
                else
                {
                    Random obj1 = new Random();
                    number = obj1.Next(0000, 9999);
                    MailMessage m1 = new MailMessage("gardenaid29@gmail.com",EmailandPhn.Text,"Security Code", "Hi, please enter the code to finish confirming your email."+number);
                    SmtpClient s1 = new SmtpClient("smtp.gmail.com");
                    s1.UseDefaultCredentials = false;
                    s1.Port = 587;
                    s1.Credentials = new NetworkCredential("gardenaid29@gmail.com", "qqotvdrgohhauxmi");
                    s1.EnableSsl = true;
                    s1.Send(m1);
                }
                Verification obj = new Verification();
                obj.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Complete the unfilled information");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FirstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstName.Text))
            {
                FirstName.Focus();
                errorProvider1.SetError(this.FirstName, "Please Enter Your First Name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true || ch==32 || ch==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true || ch == 32 || ch==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void LastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LastName.Text))
            {
                LastName.Focus();
                errorProvider2.SetError(this.LastName, "Please Enter Your Last Name");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void EmailandPhn_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
            con.Open();
            string query = "SELECT * FROM Information_Store WHERE Phone_No=@inputValue or Email=@inputValue";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@inputValue",EmailandPhn.Text);
            SqlDataReader readdata = cmd.ExecuteReader();
            if (readdata.HasRows == true)
            {
                MessageBox.Show("Already exist in our system");
                EmailandPhn.Clear();
                EmailandPhn.Focus();
            }
            if (string.IsNullOrEmpty(EmailandPhn.Text))
            {
                EmailandPhn.Focus();
                errorProvider3.SetError(this.EmailandPhn, "Please Enter Your Email or Phone No.");
            }
            else
            {
                errorProvider3.Clear();
            }
            
            con.Close();
        }

        private void EmailandPhn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                //check = true;
            }
            else
            {
                if (Regex.IsMatch(EmailandPhn.Text, Emailpattern) == false)
                {
                    errorProvider6.SetError(this.EmailandPhn,"Invalid Email");
                }
                else
                {
                    errorProvider6.Clear();
                }
            }
        }

        private void Passwordbox_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Passwordbox.Text, passPattern) == false)
            {
                errorProvider8.SetError(this.Passwordbox, "Must contain letters (upper and lower case), numbers, and symbols and have a minimum number of each");
            }
            else
            {
                errorProvider8.Clear();
            }
            if (string.IsNullOrEmpty(Passwordbox.Text))
            {
                Passwordbox.Focus();
                errorProvider4.SetError(this.Passwordbox, "Please Enter new password");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (Passwordbox.Text != textBox1.Text)
            {
                errorProvider7.SetError(this.textBox1, "Did not match. Check again..");
            }
            else
            {
                errorProvider7.Clear();
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider5.SetError(this.textBox1, "Please Re-type password");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            bool check = showpass.Checked;
            if (check == true)
            {
                Passwordbox.UseSystemPasswordChar = false;
            }
            else
            {
                Passwordbox.UseSystemPasswordChar = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem==null)
            {
                comboBox1.Focus();
                errorProvider9.SetError(this.comboBox1, "Provide DOB day");
            }
            else
            {
                errorProvider9.Clear();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                comboBox2.Focus();
                errorProvider10.SetError(this.comboBox2, "Provide DOB month");
            }
            else
            {
                errorProvider10.Clear();
            }
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == null)
            {
                comboBox3.Focus();
                errorProvider11.SetError(this.comboBox3, "Provide DOB year");
            }
            else
            {
                errorProvider11.Clear();
            }
        }

        private void radioButton1_Leave(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                errorProvider12.SetError(this.radioButton1, "Please select gender");
            }
            else
            {
                errorProvider12.Clear();
            }
        }
        void MakeComboCountry()
        {
            SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
            con.Open();
            string query_Command = "SELECT * from country";
            SqlDataAdapter DataADP = new SqlDataAdapter(query_Command,con);
            DataTable Data_show = new DataTable();
            DataADP.Fill(Data_show);
            DATr = Data_show.NewRow();
            DATr.ItemArray = new object[] { 0, "---Select Country---" };
            Data_show.Rows.InsertAt(DATr, 0);
            comboBox5.DisplayMember = "country_Name";
            comboBox5.ValueMember = "country_ID";
            comboBox5.DataSource = Data_show;
            con.Close();
        }
        void makeComboCity(int CountryID)
        {
            SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
            con.Open();
            string query_Command = "SELECT * FROM city WHERE county_ID = @C_Id";
            SqlDataAdapter DataADP = new SqlDataAdapter(query_Command, con);
            DataADP.SelectCommand.Parameters.AddWithValue("@C_id", CountryID);
            DataTable Data_show = new DataTable();
            DataADP.Fill(Data_show);
            DATr = Data_show.NewRow();
            DATr.ItemArray = new object[] { 0, "---Select City---" };
            Data_show.Rows.InsertAt(DATr, 0);
            comboBox6.DisplayMember = "city_Name";
            comboBox6.ValueMember = "city_ID";
            comboBox6.DataSource = Data_show;
            con.Close();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedValue.ToString() != null)
            {
                int countryId = Convert.ToInt32 (comboBox5.SelectedValue.ToString());
                makeComboCity(countryId);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            FirstName.Clear();
            LastName.Clear();
            EmailandPhn.Clear();
            Passwordbox.Clear();
            textBox1.Clear();
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
    }
}
