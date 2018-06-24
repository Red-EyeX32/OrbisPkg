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
using OrbisPkg.Forms;

namespace OrbisPkg
{
    public partial class Main : Form
    {
        public static Package PKG;

        public Main()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Package file (*.pkg)|*.pkg";
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            openPkg(ofd.FileName);
        }

        public frmPasscode dlgPasscode;
        private void openPkg(string fileName)
        {
            PKG = new Package(fileName);
            if (string.IsNullOrEmpty(PKG.Passcode)) {
                using (dlgPasscode = new frmPasscode())
                    dlgPasscode.ShowDialog();
            }

            PKG.Read();
        }
    }
}