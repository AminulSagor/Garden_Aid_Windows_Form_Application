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
    public partial class Notification : Form
    {
        public string name;
        public Notification()
        {
            InitializeComponent();
            //showDetails();
        }
        /*public void showDetails()
        {
            SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
            con.Open();
            string query = "SELECT * FROM SellerUpload1 WHERE Name=@input;";
            SqlDataAdapter sqadp = new SqlDataAdapter(query, con);
            sqadp.SelectCommand.Parameters.AddWithValue("@input", name);
            DataTable Dtable = new DataTable();
            sqadp.Fill(Dtable);
            ViewPic.DataSource = Dtable;
            con.Close();
        }*/

        private void Notification_Load(object sender, EventArgs e)
        {
            //dataGridView1.Hide();
            SqlConnection con = new SqlConnection("Data Source=WORKSPACE;Initial Catalog=GardenAID;Persist Security Info=True;User ID=SA;Password=dehan221999");
            con.Open();
            string query = "SELECT name FROM Verfication WHERE id=(SELECT MAX(id) FROM Verfication);";
            SqlDataAdapter sqadp = new SqlDataAdapter(query, con);
            DataTable Dtable = new DataTable();
            sqadp.Fill(Dtable);
            dataGridView1.DataSource = Dtable;
            //name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            con.Close();
            DisplayName.Text = name;

        }
    }
}
