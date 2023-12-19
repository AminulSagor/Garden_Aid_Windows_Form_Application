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
using System.IO;

namespace Garden_AID
{
    public partial class SellerPage : Form
    {
        int count = 0;
        int i = 0;
        public static string[] nameStore = new string[100];
        public SellerPage()
        {
            InitializeComponent();
        }
        public byte[] saveFile()
        {
            MemoryStream obj = new MemoryStream();
            DisplayImage.Image.Save(obj,DisplayImage.Image.RawFormat);
            return obj.GetBuffer();
        }

        private void SellerPage_Load(object sender, EventArgs e)
        {
            SellerContinuePage.Hide();
            DisplayImage.Hide();
        }

        private void SellerContinuePage_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
            con.Open();
            string query = "INSERT INTO Verfication (id,name) VALUES (@input,@value)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@input", i);
            cmd.Parameters.AddWithValue("@value", CreateAccountPage.s2);
            cmd.ExecuteNonQuery();
            con.Close();
            i = i + 1;
            MessageBox.Show("Your account is in review. Wait 72hours for the confirmation. A confirmation message will be sent your email or number");
            LogInPage obj1 = new LogInPage();
            obj1.Show();
            Hide();
        }
        //"INSERT INTO Information_Store (First_Name,Last_Name,Phone_No,Email,Password,Gander,Location_Country,Location_City,Date1,Month1,Year1) VALUES
        private void ForBrowserSeller_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Title = "Select file";
                file.Filter = "Image file(*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";
                file.ShowDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    InputPic.Text = file.FileName.ToString();
                    DisplayImage.Image = new Bitmap(file.FileName);
                }
                SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
                con.Open();
                string query = "INSERT INTO SellerUpload1 (Name,Nursery_Name,pic1) VALUES (@name,@NrsName,@input)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", CreateAccountPage.s2);
                cmd.Parameters.AddWithValue("@NrsName", NurseryNameWrite.Text);
                cmd.Parameters.AddWithValue("@input", saveFile());
                cmd.ExecuteNonQuery();
                con.Close();
                SellerContinuePage.Show();
                count = count + 1;
            }
            else if (count == 1)
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Title = "Select file";
                file.Filter = "Image file(*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";
                file.ShowDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    DisplayImage.Image = new Bitmap(file.FileName);
                    InputPic.Text = file.FileName.ToString();
                }
                SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
                con.Open();
                string query = "UPDATE SellerUpload1 SET pic2=@input where Name=@name"; ;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@input", saveFile());
                cmd.Parameters.AddWithValue("@name", CreateAccountPage.s2);
                cmd.ExecuteNonQuery();
                con.Close();
                SellerContinuePage.Show();
                count = count + 1;
            }
            else if (count == 2)
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Title = "Select file";
                file.Filter = "Image file(*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";
                file.ShowDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    InputPic.Text = file.FileName.ToString();
                    DisplayImage.Image = new Bitmap(file.FileName);
                }
                SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
                con.Open();
                string query = "UPDATE SellerUpload1 SET pic3=@input where Name=@name"; ;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@input", saveFile());
                cmd.Parameters.AddWithValue("@name", CreateAccountPage.s2);
                cmd.ExecuteNonQuery();
                con.Close();
                SellerContinuePage.Show();
                count = count + 1;
            }
            else if (count == 3)
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Title = "Select file";
                file.Filter = "Image file(*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";
                file.ShowDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    InputPic.Text = file.FileName.ToString();
                    DisplayImage.Image = new Bitmap(file.FileName);
                }
                SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
                con.Open();
                string query = "UPDATE SellerUpload1 SET pic4=@input where Name=@name"; ;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@input", saveFile());
                cmd.Parameters.AddWithValue("@name", CreateAccountPage.s2);
                cmd.ExecuteNonQuery();
                con.Close();
                SellerContinuePage.Show();
                count = count + 1;
            }
            else if (count == 4)
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Title = "Select file";
                file.Filter = "Image file(*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";
                file.ShowDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    InputPic.Text = file.FileName.ToString();
                    DisplayImage.Image = new Bitmap(file.FileName);
                }
                SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
                con.Open();
                string query = "UPDATE SellerUpload1 SET pic5=@input where Name=@name"; ;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@input", saveFile());
                cmd.Parameters.AddWithValue("@name", CreateAccountPage.s2);
                cmd.ExecuteNonQuery();
                con.Close();
                SellerContinuePage.Show();
                count = count + 1;
            }
            else
            {
                ForBrowserSeller.Hide();
            }
        }
    }
}
