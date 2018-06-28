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
        public static Package Content;

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
            Content = new Package(fileName);
            if (string.IsNullOrEmpty(Content.Passcode)) {
                using (dlgPasscode = new frmPasscode())
                    dlgPasscode.ShowDialog();
            }

            Content.Read();

            string rootName = Content.Pkg.Header.ContentId.Substring(Content.Pkg.Header.ContentId.IndexOf("-") + 1,
                Content.Pkg.Header.ContentId.IndexOf("_") - Content.Pkg.Header.ContentId.IndexOf("-") - 1);

            RetrieveFolders(rootName);
        }

        public void RetrieveFolders(string root)
        {
            AddFolder(root);
            folderTreeView.SelectedNode = folderTreeView.Nodes[0];
        }

        public void AddFolder(string name, string node = "")
        {
            if (node == "") {
                for (int i = 0; i < folderTreeView.Nodes.Count; ++i)
                    if (folderTreeView.Nodes[i].Text == name)
                        return;

                folderTreeView.Nodes.Add(name, name);
            } else {

            }
        }
    }
}