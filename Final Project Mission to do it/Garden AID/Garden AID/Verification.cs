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

namespace Garden_AID
{
    public partial class Verification : Form
    {
        public  int code;
        public string s1;
        public Verification()
        {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            AccountTypeChoose obj = new AccountTypeChoose();
            obj.Show();
            Hide();
        }

        private void Verification_Load(object sender, EventArgs e)
        {
            ContinueButton.Hide();
            numberDisplay.Text = CreateAccountPage.s1;
        }

        private void EnterOTP_Leave(object sender, EventArgs e)
        {
          
        }

        private void EnterOTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(EnterOTP.Text) == CreateAccountPage.number || Convert.ToInt32(EnterOTP.Text) == code)
            {
                Verify.Text = "Verified";
                ContinueButton.Show();
            }
            else
            {
                Verify.Text = "Not verified";
            }
        }

        private void CodeNotFound_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CreateAccountPage.s1.All(Char.IsDigit) == true)
            {
                Random obj1 = new Random();
                code = obj1.Next(0000, 9999);
                string result = "";
                WebRequest request = null;
                HttpWebResponse response = null;
                String to = CreateAccountPage.s1; //Mobile number of user
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
            }
            else
            {
                Random obj1 = new Random();
                code = obj1.Next(0000, 9999);
                MailMessage m1 = new MailMessage("gardenaid29@gmail.com", CreateAccountPage.s1, "Security Code", "Hi, please enter the code to finish confirming your email." + code);
                SmtpClient s1 = new SmtpClient("smtp.gmail.com");
                s1.UseDefaultCredentials = false;
                s1.Port = 587;
                s1.Credentials = new NetworkCredential("gardenaid29@gmail.com", "qqotvdrgohhauxmi");
                s1.EnableSsl = true;
                s1.Send(m1);
            }
        }
    }
}
