using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrbisPkg.Forms
{
    public partial class frmProperties : Form
    {
        public frmProperties()
        {
            InitializeComponent();
        }

        private void frmProperties_Load(object sender, EventArgs e)
        {
            AddProperties();
        }

        private void AddGroupWithTextAndSubItems(ListViewGroup group, string text, params string[] subItems)
        {
            var item = new ListViewItem(text, group);
            foreach (var subItem in subItems)
                item.SubItems.Add(subItem);

            propertiesListView.Items.Add(item);
        }

        private void AddProperties()
        {
            if (Main.Content != null) {
                propertiesListView.Items.Clear();

                txtContentId.Text = Main.Content.ContentId.ToString();

                var header = new ListViewGroup("Package Header");
                propertiesListView.Groups.Add(header);
                
                AddGroupWithTextAndSubItems(header, "Magic", "0x" + Main.Content.Pkg.Header.Magic.ToString("X"), "0x" + Main.Content.Pkg.Header.Magic.ToString("X"));
                AddGroupWithTextAndSubItems(header, "Is finalized?", "0x" + (Main.Content.Pkg.Header.Flags).ToString("X"), Main.Content.Pkg.IsFinalized.ToString());
                AddGroupWithTextAndSubItems(header, "Number of entries", "0x" + (Main.Content.Pkg.Header.EntryCount).ToString("X").PadLeft(8, '0'), Main.Content.Pkg.Header.EntryCount.ToString());
                AddGroupWithTextAndSubItems(header, "Number of Sc entries", "0x" + (Main.Content.Pkg.Header.ScEntryCount).ToString("X").PadLeft(4, '0'), Main.Content.Pkg.Header.ScEntryCount.ToString());
                AddGroupWithTextAndSubItems(header, "Entry table offset", "0x" + (Main.Content.Pkg.Header.EntryTableOffset).ToString("X").PadLeft(8, '0'), Main.Content.Pkg.Header.EntryTableOffset.ToString());
                AddGroupWithTextAndSubItems(header, "Main entry data size", "0x" + (Main.Content.Pkg.Header.MainEntDataSize).ToString("X").PadLeft(8, '0'), getFormatFromBytes((long)Main.Content.Pkg.Header.MainEntDataSize));
                AddGroupWithTextAndSubItems(header, "Body offset", "0x" + (Main.Content.Pkg.Header.BodyOffset).ToString("X").PadLeft(16, '0'), Main.Content.Pkg.Header.BodyOffset.ToString());
                AddGroupWithTextAndSubItems(header, "Body size", "0x" + (Main.Content.Pkg.Header.BodySize).ToString("X").PadLeft(16, '0'), getFormatFromBytes((long)Main.Content.Pkg.Header.BodySize));
                AddGroupWithTextAndSubItems(header, "Drm type", "0x" + (Main.Content.Pkg.Header.DrmType).ToString("X").PadLeft(8, '0'), Main.Content.Pkg.Header.DrmType.ToString());
                AddGroupWithTextAndSubItems(header, "Content type", "0x" + (Main.Content.Pkg.Header.ContentType).ToString("X").PadLeft(8, '0'), Main.Content.Pkg.Header.ContentType.ToString());

                var pfs = new ListViewGroup("PlayStation File System");
                propertiesListView.Groups.Add(pfs);

                AddGroupWithTextAndSubItems(pfs, "Pfs image count", "0x" + Main.Content.Pkg.Container.PfsImageCount.ToString("X").PadLeft(8, '0'), Main.Content.Pkg.Container.PfsImageCount.ToString());
                AddGroupWithTextAndSubItems(pfs, "Pfs image offset", "0x" + Main.Content.Pkg.Container.PfsImageOffset.ToString("X").PadLeft(16, '0'), Main.Content.Pkg.Container.PfsImageOffset.ToString());
                AddGroupWithTextAndSubItems(pfs, "Pfs image size", "0x" + Main.Content.Pkg.Container.PfsImageSize.ToString("X").PadLeft(16, '0'), getFormatFromBytes((long)Main.Content.Pkg.Container.PfsImageSize));
                AddGroupWithTextAndSubItems(pfs, "Mount image offset", "0x" + Main.Content.Pkg.Container.MountImageOffset.ToString("X").PadLeft(16, '0'), Main.Content.Pkg.Container.MountImageOffset.ToString());

                txtScEntriesHash1.Text = BitConverter.ToString(Main.Content.Pkg.Header.ScEntries1Hash).Replace("-", "");
                txtScEntriesHash2.Text = BitConverter.ToString(Main.Content.Pkg.Header.ScEntries2Hash).Replace("-", "");
                txtDigestTableHash.Text = BitConverter.ToString(Main.Content.Pkg.Header.DigestTableHash).Replace("-", "");
                txtBodyDigest.Text = BitConverter.ToString(Main.Content.Pkg.Header.BodyDigest).Replace("-", "");
            }
        }

        private static string getFormatFromBytes(long bytes)
        {
            var orders = new[] { "GB", "MB", "KB", "B" };
            var max = (long)Math.Pow(1024, orders.Length - 1);
            for (int x = 0; x < orders.Length; x++) {
                if (bytes >= max)
                    return string.Format(((x == orders.Length - 1) ? "{0:0}" : "{0:0.00}") + " {1}", (decimal)bytes / max, orders[x]);
                max /= 1024;
            }
            return "0 B";
        }
    }
}
