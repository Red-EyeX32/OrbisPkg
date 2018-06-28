using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OrbisPkg.CNT;

namespace OrbisPkg.Forms
{
    public partial class frmPasscode : Form
    {
        public frmPasscode()
        {
            InitializeComponent();
        }

        private void txtPasscode_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = (txtPasscode.Text.Length == 32) ? true : false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Main.Content.Passcode = txtPasscode.Text.ToString();
            this.Close();
        }
    }
}