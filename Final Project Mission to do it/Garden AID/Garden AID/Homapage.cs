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
    public partial class Homapage : Form
    {
        public string s4 = LogInPage.emailorphone;
        int count = 0;
        int count1 = 0,count2=0;
        public Homapage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out......");
            LogInPage obj = new LogInPage();
            obj.Show();
            Hide();
            Application.Exit();
        }

        private void Homapage_Load(object sender, EventArgs e)
        {
            OptionView.Height = 1;
            dataRegain.Hide();
            Dashboard.Hide();
            if (LogInPage.emailorphone.All(Char.IsDigit) == true)
            {
                SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
                con.Open();
                string query = "SELECT * from Information_Store WHERE Phone_No=@input and Ac_Type=@value;";
                SqlDataAdapter sqadp = new SqlDataAdapter(query, con);
                sqadp.SelectCommand.Parameters.AddWithValue("@input", LogInPage.emailorphone);
                sqadp.SelectCommand.Parameters.AddWithValue("@value","Admin");
                DataTable Dtable = new DataTable();
                sqadp.Fill(Dtable);
                dataRegain.DataSource = Dtable;
                con.Close();
                count = dataRegain.RowCount;
                if (count != 0)
                {
                    PaymentUpdate.Hide();
                    Package_Update.Hide();
                    Dashboard.Show();
                    dataRegain.ClearSelection();
                }
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
                con.Open();
                string query = "SELECT * from Information_Store WHERE Email=@input and Ac_Type=@value;";
                SqlDataAdapter sqadp = new SqlDataAdapter(query, con);
                sqadp.SelectCommand.Parameters.AddWithValue("@input", LogInPage.emailorphone);
                sqadp.SelectCommand.Parameters.AddWithValue("@value", "Admin");
                DataTable Dtable = new DataTable();
                sqadp.Fill(Dtable);
                dataRegain.DataSource = Dtable;
                count = dataRegain.RowCount;
                con.Close();
                if (count != 0)
                {
                    PaymentUpdate.Hide();
                    Package_Update.Hide();
                    Dashboard.Show();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (OptionView.Height == 162)
            {
                OptionView.Height = 1;
            }
            else
            {
                OptionView.Height = 162;
            }
        }

        private void ManagePrf_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageProfile obj = new ManageProfile();
            obj.Show();
        }

        private void ViewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewProfile obj = new ViewProfile();
            obj.Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInPage obj = new LogInPage();
            obj.Show();
        }

        private void Notification_Click(object sender, EventArgs e)
        {
            Hide();
            Notification obj =new Notification();
            obj.Show();
        }

        private void HomePagebutton01_Click(object sender, EventArgs e)
        {
            this.Hide();
            IndoorPlant obj = new IndoorPlant();
            obj.Show();
        }
    }
}
