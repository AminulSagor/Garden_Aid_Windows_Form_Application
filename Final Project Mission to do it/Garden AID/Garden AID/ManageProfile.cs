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
    public partial class ManageProfile : Form
    {
        public ManageProfile()
        {
            InitializeComponent();
        }

        private void ManageProfile_Load(object sender, EventArgs e)
        {
            nameInput.Hide();
            LastNameinput.Hide();
            Emailinput.Hide();
            PhoneNumberinput.Hide();
            AddressInput.Hide();
        }

        private void ChangeName_Click(object sender, EventArgs e)
        {
            nameInput.Show();
            LastNameinput.Show();
        }

        private void EmailChange_Click(object sender, EventArgs e)
        {
            Emailinput.Show();
        }

        private void changeMobile_Click(object sender, EventArgs e)
        {
            PhoneNumberinput.Show();
        }

        private void changeAddress_Click(object sender, EventArgs e)
        {
            AddressInput.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homapage obj = new Homapage();
            obj.Show();
        }
    }
}
