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

namespace OrbisPkg
{
    public partial class Main : Form
    {
        private Package PKG;

        public Main()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            openPkg(ofd.FileName);
        }

        private void openPkg(string fileName)
        {
            PKG = new Package(fileName);
        }
    }
}
