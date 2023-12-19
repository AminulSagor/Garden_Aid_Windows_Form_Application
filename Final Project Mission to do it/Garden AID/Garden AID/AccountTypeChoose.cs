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
    public partial class AccountTypeChoose : Form
    {
        public AccountTypeChoose()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ContinueInType_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Seller")
            {
                if (CreateAccountPage.s1.All(Char.IsDigit) == true)
                {
                    SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
                    string query = "UPDATE Information_Store SET Ac_Type=@type where Phone_No=@input";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@type", comboBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("@input", CreateAccountPage.s1);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    SellerPage obj = new SellerPage();
                    obj.Show();
                    Hide();
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
                    string query = "UPDATE Information_Store SET Ac_Type=@type where Email=@input";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@type", comboBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("@input", CreateAccountPage.s1);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    SellerPage obj = new SellerPage();
                    obj.Show();
                    Hide();
                }
            }
            else
            {
                if(CreateAccountPage.s1.All(Char.IsDigit) == true)
                {
                    SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
                    string query = "UPDATE Information_Store SET Ac_Type=@type where Phone_No=@input";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@type", comboBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("@input", CreateAccountPage.s1);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LogInPage obj = new LogInPage();
                    obj.Show();
                    Hide();
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
                    string query = "UPDATE Information_Store SET Ac_Type=@type where Email=@input";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@type", comboBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("@input", CreateAccountPage.s1);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LogInPage obj = new LogInPage();
                    obj.Show();
                    Hide();
                }
            }
        }

        private void AccountTypeChoose_Load(object sender, EventArgs e)
        {

        }
    }
}
