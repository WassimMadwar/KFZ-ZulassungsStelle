namespace Basis_W_App.Detain
{
    partial class frmListDetainedLicenses
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SM_PersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.SM_LicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.SM_LicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.SM_ReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbIsReleased = new System.Windows.Forms.ComboBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ReleaseDetainedLicense = new System.Windows.Forms.Button();
            this.btn_DetainLicense = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            this.cmsApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Location = new System.Drawing.Point(101, 479);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(27, 20);
            this.lblTotalRecords.TabIndex = 170;
            this.lblTotalRecords.Text = "??";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 169;
            this.label5.Text = "# Records:";
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenses.AllowUserToResizeRows = false;
            this.dgvDetainedLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicenses.ContextMenuStrip = this.cmsApplications;
            this.dgvDetainedLicenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(7, 130);
            this.dgvDetainedLicenses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDetainedLicenses.MultiSelect = false;
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetainedLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(1360, 340);
            this.dgvDetainedLicenses.TabIndex = 168;
            this.dgvDetainedLicenses.TabStop = false;
            // 
            // cmsApplications
            // 
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SM_PersonDetails,
            this.SM_LicenseDetails,
            this.SM_LicenseHistory,
            this.toolStripMenuItem1,
            this.SM_ReleaseDetainedLicense});
            this.cmsApplications.Name = "contextMenuStrip1";
            this.cmsApplications.Size = new System.Drawing.Size(258, 248);
            this.cmsApplications.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplications_Opening);
            // 
            // SM_PersonDetails
            // 
            this.SM_PersonDetails.Image = global::Basis_W_App.Properties.Resources.PersonDetails_32;
            this.SM_PersonDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SM_PersonDetails.Name = "SM_PersonDetails";
            this.SM_PersonDetails.Size = new System.Drawing.Size(257, 54);
            this.SM_PersonDetails.Text = "Show Person Details";
            this.SM_PersonDetails.Click += new System.EventHandler(this.SM_PersonDetails_Click);
            // 
            // SM_LicenseDetails
            // 
            this.SM_LicenseDetails.Image = global::Basis_W_App.Properties.Resources.Driver_License_32;
            this.SM_LicenseDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SM_LicenseDetails.Name = "SM_LicenseDetails";
            this.SM_LicenseDetails.Size = new System.Drawing.Size(257, 54);
            this.SM_LicenseDetails.Text = "&Show License Details";
            this.SM_LicenseDetails.Click += new System.EventHandler(this.SM_LicenseDetails_Click);
            // 
            // SM_LicenseHistory
            // 
            this.SM_LicenseHistory.Image = global::Basis_W_App.Properties.Resources.PersonLicenseHistory_32;
            this.SM_LicenseHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SM_LicenseHistory.Name = "SM_LicenseHistory";
            this.SM_LicenseHistory.Size = new System.Drawing.Size(257, 54);
            this.SM_LicenseHistory.Text = "Show Person License History";
            this.SM_LicenseHistory.Click += new System.EventHandler(this.SM_LicenseHistory_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(254, 6);
            // 
            // SM_ReleaseDetainedLicense
            // 
            this.SM_ReleaseDetainedLicense.Image = global::Basis_W_App.Properties.Resources.Release_Detained_License_32;
            this.SM_ReleaseDetainedLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SM_ReleaseDetainedLicense.Name = "SM_ReleaseDetainedLicense";
            this.SM_ReleaseDetainedLicense.Size = new System.Drawing.Size(257, 54);
            this.SM_ReleaseDetainedLicense.Text = "Release Detained License";
            this.SM_ReleaseDetainedLicense.Click += new System.EventHandler(this.SM_ReleaseDetainedLicense_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(403, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(568, 39);
            this.lblTitle.TabIndex = 162;
            this.lblTitle.Text = "List Detained Licenses";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbIsReleased
            // 
            this.cbIsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsReleased.FormattingEnabled = true;
            this.cbIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsReleased.Location = new System.Drawing.Point(295, 94);
            this.cbIsReleased.Name = "cbIsReleased";
            this.cbIsReleased.Size = new System.Drawing.Size(121, 28);
            this.cbIsReleased.TabIndex = 171;
            this.cbIsReleased.Visible = false;
            this.cbIsReleased.SelectedIndexChanged += new System.EventHandler(this.cbIsReleased_SelectedIndexChanged);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "Is Released",
            "National No.",
            "Full Name",
            "Release Application ID"});
            this.cbFilterBy.Location = new System.Drawing.Point(79, 94);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(210, 28);
            this.cbFilterBy.TabIndex = 165;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(296, 94);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(256, 26);
            this.txtFilterValue.TabIndex = 164;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 163;
            this.label1.Text = "Filter By:";
            // 
            // btn_ReleaseDetainedLicense
            // 
            this.btn_ReleaseDetainedLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReleaseDetainedLicense.Image = global::Basis_W_App.Properties.Resources.Release_Detained_License_64;
            this.btn_ReleaseDetainedLicense.Location = new System.Drawing.Point(1185, 47);
            this.btn_ReleaseDetainedLicense.Name = "btn_ReleaseDetainedLicense";
            this.btn_ReleaseDetainedLicense.Size = new System.Drawing.Size(88, 75);
            this.btn_ReleaseDetainedLicense.TabIndex = 172;
            this.btn_ReleaseDetainedLicense.UseVisualStyleBackColor = true;
            this.btn_ReleaseDetainedLicense.Click += new System.EventHandler(this.btn_ReleaseDetainedLicense_Click);
            // 
            // btn_DetainLicense
            // 
            this.btn_DetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DetainLicense.Image = global::Basis_W_App.Properties.Resources.Detain_64;
            this.btn_DetainLicense.Location = new System.Drawing.Point(1279, 47);
            this.btn_DetainLicense.Name = "btn_DetainLicense";
            this.btn_DetainLicense.Size = new System.Drawing.Size(88, 75);
            this.btn_DetainLicense.TabIndex = 167;
            this.btn_DetainLicense.UseVisualStyleBackColor = true;
            this.btn_DetainLicense.Click += new System.EventHandler(this.btn_DetainLicense_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.AutoEllipsis = true;
            this.btn_Close.BackColor = System.Drawing.Color.MintCream;
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.Image = global::Basis_W_App.Properties.Resources.Close_32;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(1232, 478);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(135, 36);
            this.btn_Close.TabIndex = 161;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frmListDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1374, 528);
            this.Controls.Add(this.btn_ReleaseDetainedLicense);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDetainedLicenses);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbIsReleased);
            this.Controls.Add(this.btn_DetainLicense);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListDetainedLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List Detained Licenses";
            this.Load += new System.EventHandler(this.frmListDetainedLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ReleaseDetainedLicense;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDetainedLicenses;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem SM_PersonDetails;
        private System.Windows.Forms.ToolStripMenuItem SM_LicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem SM_LicenseHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SM_ReleaseDetainedLicense;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbIsReleased;
        private System.Windows.Forms.Button btn_DetainLicense;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
    }
}