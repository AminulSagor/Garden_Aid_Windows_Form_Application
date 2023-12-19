using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garden_AID
{
    public partial class ViewProfile : Form
    {
        public ViewProfile()
        {
            InitializeComponent();
        }

        private void locationVisiable_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInPage obj = new LogInPage();
            obj.Show();
        }

        private void BackButtonprf_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homapage obj = new Homapage();
            obj.Show();
        }
    }
}
