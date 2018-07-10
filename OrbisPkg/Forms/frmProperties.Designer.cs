namespace OrbisPkg.Forms
{
    partial class frmProperties
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProperties));
            this.lblContentId = new System.Windows.Forms.Label();
            this.txtContentId = new System.Windows.Forms.TextBox();
            this.propertiesListView = new System.Windows.Forms.ListView();
            this.ItemsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblScEntriesHash1 = new System.Windows.Forms.Label();
            this.txtScEntriesHash1 = new System.Windows.Forms.TextBox();
            this.lblScEntriesHash2 = new System.Windows.Forms.Label();
            this.txtScEntriesHash2 = new System.Windows.Forms.TextBox();
            this.lblDigestTableHash = new System.Windows.Forms.Label();
            this.txtDigestTableHash = new System.Windows.Forms.TextBox();
            this.lblBodyDigest = new System.Windows.Forms.Label();
            this.txtBodyDigest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblContentId
            // 
            this.lblContentId.AutoSize = true;
            this.lblContentId.Location = new System.Drawing.Point(12, 15);
            this.lblContentId.Name = "lblContentId";
            this.lblContentId.Size = new System.Drawing.Size(59, 13);
            this.lblContentId.TabIndex = 0;
            this.lblContentId.Text = "Content Id:";
            // 
            // txtContentId
            // 
            this.txtContentId.Location = new System.Drawing.Point(77, 12);
            this.txtContentId.Name = "txtContentId";
            this.txtContentId.ReadOnly = true;
            this.txtContentId.Size = new System.Drawing.Size(310, 20);
            this.txtContentId.TabIndex = 1;
            this.txtContentId.TabStop = false;
            // 
            // propertiesListView
            // 
            this.propertiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemsColumnHeader,
            this.DataColumnHeader,
            this.ValueColumnHeader});
            this.propertiesListView.FullRowSelect = true;
            this.propertiesListView.GridLines = true;
            this.propertiesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.propertiesListView.HoverSelection = true;
            this.propertiesListView.Location = new System.Drawing.Point(12, 38);
            this.propertiesListView.MultiSelect = false;
            this.propertiesListView.Name = "propertiesListView";
            this.propertiesListView.Size = new System.Drawing.Size(375, 158);
            this.propertiesListView.TabIndex = 2;
            this.propertiesListView.UseCompatibleStateImageBehavior = false;
            this.propertiesListView.View = System.Windows.Forms.View.Details;
            // 
            // ItemsColumnHeader
            // 
            this.ItemsColumnHeader.Text = "";
            this.ItemsColumnHeader.Width = 110;
            // 
            // DataColumnHeader
            // 
            this.DataColumnHeader.Text = "Data";
            this.DataColumnHeader.Width = 125;
            // 
            // ValueColumnHeader
            // 
            this.ValueColumnHeader.Text = "Value";
            this.ValueColumnHeader.Width = 135;
            // 
            // lblScEntriesHash1
            // 
            this.lblScEntriesHash1.AutoSize = true;
            this.lblScEntriesHash1.Location = new System.Drawing.Point(12, 209);
            this.lblScEntriesHash1.Name = "lblScEntriesHash1";
            this.lblScEntriesHash1.Size = new System.Drawing.Size(102, 13);
            this.lblScEntriesHash1.TabIndex = 3;
            this.lblScEntriesHash1.Text = "Sc Entries Hash #1:";
            // 
            // txtScEntriesHash1
            // 
            this.txtScEntriesHash1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScEntriesHash1.Location = new System.Drawing.Point(12, 225);
            this.txtScEntriesHash1.Name = "txtScEntriesHash1";
            this.txtScEntriesHash1.ReadOnly = true;
            this.txtScEntriesHash1.Size = new System.Drawing.Size(375, 18);
            this.txtScEntriesHash1.TabIndex = 4;
            // 
            // lblScEntriesHash2
            // 
            this.lblScEntriesHash2.AutoSize = true;
            this.lblScEntriesHash2.Location = new System.Drawing.Point(12, 258);
            this.lblScEntriesHash2.Name = "lblScEntriesHash2";
            this.lblScEntriesHash2.Size = new System.Drawing.Size(102, 13);
            this.lblScEntriesHash2.TabIndex = 5;
            this.lblScEntriesHash2.Text = "Sc Entries Hash #2:";
            // 
            // txtScEntriesHash2
            // 
            this.txtScEntriesHash2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScEntriesHash2.Location = new System.Drawing.Point(12, 274);
            this.txtScEntriesHash2.Name = "txtScEntriesHash2";
            this.txtScEntriesHash2.ReadOnly = true;
            this.txtScEntriesHash2.Size = new System.Drawing.Size(375, 18);
            this.txtScEntriesHash2.TabIndex = 6;
            // 
            // lblDigestTableHash
            // 
            this.lblDigestTableHash.AutoSize = true;
            this.lblDigestTableHash.Location = new System.Drawing.Point(12, 304);
            this.lblDigestTableHash.Name = "lblDigestTableHash";
            this.lblDigestTableHash.Size = new System.Drawing.Size(98, 13);
            this.lblDigestTableHash.TabIndex = 7;
            this.lblDigestTableHash.Text = "Digest Table Hash:";
            // 
            // txtDigestTableHash
            // 
            this.txtDigestTableHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDigestTableHash.Location = new System.Drawing.Point(12, 320);
            this.txtDigestTableHash.Name = "txtDigestTableHash";
            this.txtDigestTableHash.ReadOnly = true;
            this.txtDigestTableHash.Size = new System.Drawing.Size(375, 18);
            this.txtDigestTableHash.TabIndex = 8;
            // 
            // lblBodyDigest
            // 
            this.lblBodyDigest.AutoSize = true;
            this.lblBodyDigest.Location = new System.Drawing.Point(12, 350);
            this.lblBodyDigest.Name = "lblBodyDigest";
            this.lblBodyDigest.Size = new System.Drawing.Size(67, 13);
            this.lblBodyDigest.TabIndex = 9;
            this.lblBodyDigest.Text = "Body Digest:";
            // 
            // txtBodyDigest
            // 
            this.txtBodyDigest.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodyDigest.Location = new System.Drawing.Point(12, 366);
            this.txtBodyDigest.Name = "txtBodyDigest";
            this.txtBodyDigest.ReadOnly = true;
            this.txtBodyDigest.Size = new System.Drawing.Size(375, 18);
            this.txtBodyDigest.TabIndex = 10;
            // 
            // frmProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 411);
            this.Controls.Add(this.txtBodyDigest);
            this.Controls.Add(this.lblBodyDigest);
            this.Controls.Add(this.txtDigestTableHash);
            this.Controls.Add(this.lblDigestTableHash);
            this.Controls.Add(this.txtScEntriesHash2);
            this.Controls.Add(this.lblScEntriesHash2);
            this.Controls.Add(this.txtScEntriesHash1);
            this.Controls.Add(this.lblScEntriesHash1);
            this.Controls.Add(this.propertiesListView);
            this.Controls.Add(this.txtContentId);
            this.Controls.Add(this.lblContentId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProperties";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.frmProperties_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContentId;
        private System.Windows.Forms.TextBox txtContentId;
        private System.Windows.Forms.ListView propertiesListView;
        private System.Windows.Forms.ColumnHeader ItemsColumnHeader;
        private System.Windows.Forms.ColumnHeader DataColumnHeader;
        private System.Windows.Forms.ColumnHeader ValueColumnHeader;
        private System.Windows.Forms.Label lblScEntriesHash1;
        private System.Windows.Forms.TextBox txtScEntriesHash1;
        private System.Windows.Forms.Label lblScEntriesHash2;
        private System.Windows.Forms.TextBox txtScEntriesHash2;
        private System.Windows.Forms.Label lblDigestTableHash;
        private System.Windows.Forms.TextBox txtDigestTableHash;
        private System.Windows.Forms.Label lblBodyDigest;
        private System.Windows.Forms.TextBox txtBodyDigest;
    }
}