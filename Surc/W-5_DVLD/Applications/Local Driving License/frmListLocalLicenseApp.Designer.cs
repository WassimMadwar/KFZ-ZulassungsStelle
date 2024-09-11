namespace Basis_W_App.Applications.Local_Driving_License
{
    partial class frmListLocalLicenseApp
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
            this.cb_FilterBy = new System.Windows.Forms.ComboBox();
            this.txt_FilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetailsSM = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSM = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAppSM = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelAppSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleTestsMenue = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleVisionTestSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleWrittenTestSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueLicenseFirstTimeSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHistorySM = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_RecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLocalLicenseApp = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_AddNewApplication = new System.Windows.Forms.Button();
            this.cmsApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseApp)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_FilterBy
            // 
            this.cb_FilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FilterBy.FormattingEnabled = true;
            this.cb_FilterBy.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "National No.",
            "Full Name",
            "Status"});
            this.cb_FilterBy.Location = new System.Drawing.Point(105, 82);
            this.cb_FilterBy.Name = "cb_FilterBy";
            this.cb_FilterBy.Size = new System.Drawing.Size(210, 28);
            this.cb_FilterBy.TabIndex = 138;
            this.cb_FilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txt_FilterValue
            // 
            this.txt_FilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FilterValue.Location = new System.Drawing.Point(322, 82);
            this.txt_FilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_FilterValue.Name = "txt_FilterValue";
            this.txt_FilterValue.Size = new System.Drawing.Size(256, 26);
            this.txt_FilterValue.TabIndex = 137;
            this.txt_FilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txt_FilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 136;
            this.label1.Text = "Filter By  :";
            // 
            // btn_Close
            // 
            this.btn_Close.AutoEllipsis = true;
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(1255, 494);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(135, 36);
            this.btn_Close.TabIndex = 131;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(258, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(258, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(258, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(258, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(258, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(258, 6);
            // 
            // cmsApplications
            // 
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDetailsSM,
            this.toolStripSeparator2,
            this.EditSM,
            this.DeleteAppSM,
            this.toolStripSeparator5,
            this.CancelAppSM,
            this.toolStripSeparator1,
            this.ScheduleTestsMenue,
            this.toolStripSeparator3,
            this.IssueLicenseFirstTimeSM,
            this.toolStripSeparator4,
            this.ShowLicenseSM,
            this.toolStripSeparator6,
            this.ShowPersonLicenseHistorySM});
            this.cmsApplications.Name = "contextMenuStrip1";
            this.cmsApplications.Size = new System.Drawing.Size(262, 344);
            this.cmsApplications.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplications_Opening);
            // 
            // ShowDetailsSM
            // 
            this.ShowDetailsSM.Image = global::Basis_W_App.Properties.Resources.PersonDetails_321;
            this.ShowDetailsSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowDetailsSM.Name = "ShowDetailsSM";
            this.ShowDetailsSM.Size = new System.Drawing.Size(261, 38);
            this.ShowDetailsSM.Text = "&Show Application Details";
            this.ShowDetailsSM.Click += new System.EventHandler(this.ShowDetailsSM_Click);
            // 
            // EditSM
            // 
            this.EditSM.Image = global::Basis_W_App.Properties.Resources.edit_32;
            this.EditSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditSM.Name = "EditSM";
            this.EditSM.Size = new System.Drawing.Size(261, 38);
            this.EditSM.Text = "&Edit Application";
            this.EditSM.Click += new System.EventHandler(this.EditSM_Click);
            // 
            // DeleteAppSM
            // 
            this.DeleteAppSM.Image = global::Basis_W_App.Properties.Resources.Delete_32_2;
            this.DeleteAppSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteAppSM.Name = "DeleteAppSM";
            this.DeleteAppSM.Size = new System.Drawing.Size(261, 38);
            this.DeleteAppSM.Text = "&Delete Application";
            this.DeleteAppSM.Click += new System.EventHandler(this.DeleteAppSM_Click);
            // 
            // CancelAppSM
            // 
            this.CancelAppSM.Image = global::Basis_W_App.Properties.Resources.Delete_321;
            this.CancelAppSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CancelAppSM.Name = "CancelAppSM";
            this.CancelAppSM.Size = new System.Drawing.Size(261, 38);
            this.CancelAppSM.Text = "&Cancel Application";
            this.CancelAppSM.Click += new System.EventHandler(this.CancelAppSM_Click);
            // 
            // ScheduleTestsMenue
            // 
            this.ScheduleTestsMenue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ScheduleVisionTestSM,
            this.ScheduleWrittenTestSM,
            this.ScheduleStreetTest});
            this.ScheduleTestsMenue.Image = global::Basis_W_App.Properties.Resources.Schedule_Test_32;
            this.ScheduleTestsMenue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleTestsMenue.Name = "ScheduleTestsMenue";
            this.ScheduleTestsMenue.Size = new System.Drawing.Size(261, 38);
            this.ScheduleTestsMenue.Text = "Sechdule &Tests";
            // 
            // ScheduleVisionTestSM
            // 
            this.ScheduleVisionTestSM.Image = global::Basis_W_App.Properties.Resources.Vision_Test_32;
            this.ScheduleVisionTestSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleVisionTestSM.Name = "ScheduleVisionTestSM";
            this.ScheduleVisionTestSM.Size = new System.Drawing.Size(203, 38);
            this.ScheduleVisionTestSM.Text = "Schedule Vision Test";
            this.ScheduleVisionTestSM.Click += new System.EventHandler(this.ScheduleVisionTestSM_Click);
            // 
            // ScheduleWrittenTestSM
            // 
            this.ScheduleWrittenTestSM.Image = global::Basis_W_App.Properties.Resources.Written_Test_32_Sechdule;
            this.ScheduleWrittenTestSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleWrittenTestSM.Name = "ScheduleWrittenTestSM";
            this.ScheduleWrittenTestSM.Size = new System.Drawing.Size(203, 38);
            this.ScheduleWrittenTestSM.Text = "Schedule Written Test";
            this.ScheduleWrittenTestSM.Click += new System.EventHandler(this.ScheduleWrittenTestSM_Click);
            // 
            // ScheduleStreetTest
            // 
            this.ScheduleStreetTest.Image = global::Basis_W_App.Properties.Resources.Street_Test_32;
            this.ScheduleStreetTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleStreetTest.Name = "ScheduleStreetTest";
            this.ScheduleStreetTest.Size = new System.Drawing.Size(203, 38);
            this.ScheduleStreetTest.Text = "Schedule Street Test";
            this.ScheduleStreetTest.Click += new System.EventHandler(this.ScheduleStreetTest_Click);
            // 
            // IssueLicenseFirstTimeSM
            // 
            this.IssueLicenseFirstTimeSM.Image = global::Basis_W_App.Properties.Resources.IssueDrivingLicense_32;
            this.IssueLicenseFirstTimeSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IssueLicenseFirstTimeSM.Name = "IssueLicenseFirstTimeSM";
            this.IssueLicenseFirstTimeSM.Size = new System.Drawing.Size(261, 38);
            this.IssueLicenseFirstTimeSM.Text = "&Issue Driving License (First Time)";
            this.IssueLicenseFirstTimeSM.Click += new System.EventHandler(this.IssueLicenseFirstTimeSM_Click);
            // 
            // ShowLicenseSM
            // 
            this.ShowLicenseSM.Image = global::Basis_W_App.Properties.Resources.License_View_321;
            this.ShowLicenseSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLicenseSM.Name = "ShowLicenseSM";
            this.ShowLicenseSM.Size = new System.Drawing.Size(261, 38);
            this.ShowLicenseSM.Text = "Show &License";
            this.ShowLicenseSM.Click += new System.EventHandler(this.ShowLicenseSM_Click);
            // 
            // ShowPersonLicenseHistorySM
            // 
            this.ShowPersonLicenseHistorySM.Image = global::Basis_W_App.Properties.Resources.Person_32;
            this.ShowPersonLicenseHistorySM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPersonLicenseHistorySM.Name = "ShowPersonLicenseHistorySM";
            this.ShowPersonLicenseHistorySM.Size = new System.Drawing.Size(261, 38);
            this.ShowPersonLicenseHistorySM.Text = "Show Person License History";
            this.ShowPersonLicenseHistorySM.Click += new System.EventHandler(this.ShowPersonLicenseHistorySM_Click);
            // 
            // lbl_RecordsCount
            // 
            this.lbl_RecordsCount.AutoSize = true;
            this.lbl_RecordsCount.Location = new System.Drawing.Point(106, 500);
            this.lbl_RecordsCount.Name = "lbl_RecordsCount";
            this.lbl_RecordsCount.Size = new System.Drawing.Size(27, 20);
            this.lbl_RecordsCount.TabIndex = 134;
            this.lbl_RecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 133;
            this.label2.Text = "# Records:";
            // 
            // dgvLocalLicenseApp
            // 
            this.dgvLocalLicenseApp.AllowUserToAddRows = false;
            this.dgvLocalLicenseApp.AllowUserToDeleteRows = false;
            this.dgvLocalLicenseApp.AllowUserToResizeRows = false;
            this.dgvLocalLicenseApp.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalLicenseApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenseApp.ContextMenuStrip = this.cmsApplications;
            this.dgvLocalLicenseApp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLocalLicenseApp.Location = new System.Drawing.Point(2, 131);
            this.dgvLocalLicenseApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLocalLicenseApp.MultiSelect = false;
            this.dgvLocalLicenseApp.Name = "dgvLocalLicenseApp";
            this.dgvLocalLicenseApp.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalLicenseApp.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocalLicenseApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalLicenseApp.Size = new System.Drawing.Size(1405, 353);
            this.dgvLocalLicenseApp.TabIndex = 132;
            this.dgvLocalLicenseApp.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(388, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(568, 39);
            this.lblTitle.TabIndex = 135;
            this.lblTitle.Text = "Local Driving License Applications";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_AddNewApplication
            // 
            this.btn_AddNewApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewApplication.Image = global::Basis_W_App.Properties.Resources.New_Application_64;
            this.btn_AddNewApplication.Location = new System.Drawing.Point(1302, 48);
            this.btn_AddNewApplication.Name = "btn_AddNewApplication";
            this.btn_AddNewApplication.Size = new System.Drawing.Size(88, 75);
            this.btn_AddNewApplication.TabIndex = 140;
            this.btn_AddNewApplication.UseVisualStyleBackColor = true;
            this.btn_AddNewApplication.Click += new System.EventHandler(this.btnAddNewApplication_Click);
            // 
            // frmListLocalLicenseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1408, 538);
            this.Controls.Add(this.btn_AddNewApplication);
            this.Controls.Add(this.cb_FilterBy);
            this.Controls.Add(this.txt_FilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_RecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLocalLicenseApp);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListLocalLicenseApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List Local License App";
            this.Load += new System.EventHandler(this.frmListLocalLicenseApp_Load);
            this.cmsApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddNewApplication;
        private System.Windows.Forms.ComboBox cb_FilterBy;
        private System.Windows.Forms.TextBox txt_FilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistorySM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseSM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem IssueLicenseFirstTimeSM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ScheduleStreetTest;
        private System.Windows.Forms.ToolStripMenuItem ScheduleWrittenTestSM;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTestsMenue;
        private System.Windows.Forms.ToolStripMenuItem ScheduleVisionTestSM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CancelAppSM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem DeleteAppSM;
        private System.Windows.Forms.ToolStripMenuItem EditSM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ShowDetailsSM;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.Label lbl_RecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLocalLicenseApp;
        private System.Windows.Forms.Label lblTitle;
    }
}