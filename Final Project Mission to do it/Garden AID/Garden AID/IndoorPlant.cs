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
    public partial class IndoorPlant : Form
    {
        public IndoorPlant()
        {
            InitializeComponent();
        }

        private void IndoorPlant_Load(object sender, EventArgs e)
        {
            panelopt1.Hide();
            panelopt2.Hide();
            panelopt3.Hide();
            panelopt4.Hide();
            panelopt5.Hide();
            panelopt6.Hide();
            panelopt07.Hide();
            panelopt08.Hide();
            panelopt09.Hide();
            panelopt10.Hide();
        }
    }
}
