using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFormWithCombo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cboShowPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboShowPage.SelectedItem.ToString())
            {
                case "Page A":
                    new FormA().ShowDialog();
                    break;
                case "Page B":
                    new FormB().ShowDialog();
                    break;
            }
        }
    }
}
