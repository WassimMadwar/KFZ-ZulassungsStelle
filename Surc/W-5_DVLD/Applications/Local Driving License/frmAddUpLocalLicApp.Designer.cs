namespace Basis_W_App.Applications.Local_Driving_License
{
    partial class frmAddUpLocalLicApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CreatedByUser = new System.Windows.Forms.Label();
            this.lbl_Fees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tp_PersonalInfo = new System.Windows.Forms.TabPage();
            this.ctrPersonCardWithFilter1 = new Basis_W_App.People.Controls.ctrPersonCardWithFilter();
            this.btn_AppNextToInfo = new System.Windows.Forms.Button();
            this.tc_ApplicationInfo = new System.Windows.Forms.TabControl();
            this.tp_ApplicationInfo = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_LicenseClass = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_AppDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_LocalLicensAppID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tp_PersonalInfo.SuspendLayout();
            this.tc_ApplicationInfo.SuspendLayout();
            this.tp_ApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 142;
            this.label1.Text = "Created By:";
            // 
            // lbl_CreatedByUser
            // 
            this.lbl_CreatedByUser.AutoSize = true;
            this.lbl_CreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreatedByUser.Location = new System.Drawing.Point(256, 246);
            this.lbl_CreatedByUser.Name = "lbl_CreatedByUser";
            this.lbl_CreatedByUser.Size = new System.Drawing.Size(59, 20);
            this.lbl_CreatedByUser.TabIndex = 141;
            this.lbl_CreatedByUser.Text = "[????]";
            // 
            // lbl_Fees
            // 
            this.lbl_Fees.AutoSize = true;
            this.lbl_Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fees.Location = new System.Drawing.Point(256, 194);
            this.lbl_Fees.Name = "lbl_Fees";
            this.lbl_Fees.Size = new System.Drawing.Size(49, 20);
            this.lbl_Fees.TabIndex = 140;
            this.lbl_Fees.Text = "[$$$]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 138;
            this.label2.Text = "Application Fees:";
            // 
            // tp_PersonalInfo
            // 
            this.tp_PersonalInfo.Controls.Add(this.ctrPersonCardWithFilter1);
            this.tp_PersonalInfo.Controls.Add(this.btn_AppNextToInfo);
            this.tp_PersonalInfo.Location = new System.Drawing.Point(4, 24);
            this.tp_PersonalInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tp_PersonalInfo.Name = "tp_PersonalInfo";
            this.tp_PersonalInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tp_PersonalInfo.Size = new System.Drawing.Size(963, 419);
            this.tp_PersonalInfo.TabIndex = 0;
            this.tp_PersonalInfo.Text = "Personal Info";
            this.tp_PersonalInfo.UseVisualStyleBackColor = true;
            // 
            // ctrPersonCardWithFilter1
            // 
            this.ctrPersonCardWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrPersonCardWithFilter1.FilterEnabled = true;
            this.ctrPersonCardWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPersonCardWithFilter1.Location = new System.Drawing.Point(2, 1);
            this.ctrPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrPersonCardWithFilter1.Name = "ctrPersonCardWithFilter1";
            this.ctrPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrPersonCardWithFilter1.Size = new System.Drawing.Size(958, 369);
            this.ctrPersonCardWithFilter1.TabIndex = 120;
            this.ctrPersonCardWithFilter1.OnPersonSelected += new System.Action<int>(this.SubscribeEvent_OnPersonSelected);
            // 
            // btn_AppNextToInfo
            // 
            this.btn_AppNextToInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AppNextToInfo.Image = global::Basis_W_App.Properties.Resources.Next_32;
            this.btn_AppNextToInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AppNextToInfo.Location = new System.Drawing.Point(847, 376);
            this.btn_AppNextToInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AppNextToInfo.Name = "btn_AppNextToInfo";
            this.btn_AppNextToInfo.Size = new System.Drawing.Size(98, 34);
            this.btn_AppNextToInfo.TabIndex = 119;
            this.btn_AppNextToInfo.Text = "Next";
            this.btn_AppNextToInfo.UseVisualStyleBackColor = true;
            this.btn_AppNextToInfo.Click += new System.EventHandler(this.btn_AppNextToInfo_Click);
            // 
            // tc_ApplicationInfo
            // 
            this.tc_ApplicationInfo.Controls.Add(this.tp_PersonalInfo);
            this.tc_ApplicationInfo.Controls.Add(this.tp_ApplicationInfo);
            this.tc_ApplicationInfo.Location = new System.Drawing.Point(5, 46);
            this.tc_ApplicationInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tc_ApplicationInfo.Name = "tc_ApplicationInfo";
            this.tc_ApplicationInfo.SelectedIndex = 0;
            this.tc_ApplicationInfo.Size = new System.Drawing.Size(971, 447);
            this.tc_ApplicationInfo.TabIndex = 125;
            // 
            // tp_ApplicationInfo
            // 
            this.tp_ApplicationInfo.Controls.Add(this.pictureBox2);
            this.tp_ApplicationInfo.Controls.Add(this.pictureBox1);
            this.tp_ApplicationInfo.Controls.Add(this.label1);
            this.tp_ApplicationInfo.Controls.Add(this.lbl_CreatedByUser);
            this.tp_ApplicationInfo.Controls.Add(this.lbl_Fees);
            this.tp_ApplicationInfo.Controls.Add(this.label2);
            this.tp_ApplicationInfo.Controls.Add(this.cb_LicenseClass);
            this.tp_ApplicationInfo.Controls.Add(this.label15);
            this.tp_ApplicationInfo.Controls.Add(this.lbl_AppDate);
            this.tp_ApplicationInfo.Controls.Add(this.label5);
            this.tp_ApplicationInfo.Controls.Add(this.lbl_LocalLicensAppID);
            this.tp_ApplicationInfo.Controls.Add(this.label4);
            this.tp_ApplicationInfo.Controls.Add(this.pictureBox3);
            this.tp_ApplicationInfo.Controls.Add(this.pictureBox6);
            this.tp_ApplicationInfo.Controls.Add(this.pictureBox4);
            this.tp_ApplicationInfo.Location = new System.Drawing.Point(4, 24);
            this.tp_ApplicationInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tp_ApplicationInfo.Name = "tp_ApplicationInfo";
            this.tp_ApplicationInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tp_ApplicationInfo.Size = new System.Drawing.Size(963, 419);
            this.tp_ApplicationInfo.TabIndex = 1;
            this.tp_ApplicationInfo.Text = "Application Info.";
            this.tp_ApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Basis_W_App.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(210, 38);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 144;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Basis_W_App.Properties.Resources.User_32__2;
            this.pictureBox1.Location = new System.Drawing.Point(209, 246);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 143;
            this.pictureBox1.TabStop = false;
            // 
            // cb_LicenseClass
            // 
            this.cb_LicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LicenseClass.FormattingEnabled = true;
            this.cb_LicenseClass.Location = new System.Drawing.Point(256, 141);
            this.cb_LicenseClass.Margin = new System.Windows.Forms.Padding(2);
            this.cb_LicenseClass.Name = "cb_LicenseClass";
            this.cb_LicenseClass.Size = new System.Drawing.Size(211, 23);
            this.cb_LicenseClass.TabIndex = 134;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 20);
            this.label15.TabIndex = 135;
            this.label15.Text = "License Class:";
            // 
            // lbl_AppDate
            // 
            this.lbl_AppDate.AutoSize = true;
            this.lbl_AppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AppDate.Location = new System.Drawing.Point(256, 91);
            this.lbl_AppDate.Name = "lbl_AppDate";
            this.lbl_AppDate.Size = new System.Drawing.Size(109, 20);
            this.lbl_AppDate.TabIndex = 133;
            this.lbl_AppDate.Text = "[??/??/????]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 131;
            this.label5.Text = "Application Date:";
            // 
            // lbl_LocalLicensAppID
            // 
            this.lbl_LocalLicensAppID.AutoSize = true;
            this.lbl_LocalLicensAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LocalLicensAppID.Location = new System.Drawing.Point(256, 36);
            this.lbl_LocalLicensAppID.Name = "lbl_LocalLicensAppID";
            this.lbl_LocalLicensAppID.Size = new System.Drawing.Size(49, 20);
            this.lbl_LocalLicensAppID.TabIndex = 129;
            this.lbl_LocalLicensAppID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 128;
            this.label4.Text = "Local.L.Application ID:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Basis_W_App.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(209, 194);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 139;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Basis_W_App.Properties.Resources.LocalDriving_License;
            this.pictureBox6.Location = new System.Drawing.Point(209, 142);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 136;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Basis_W_App.Properties.Resources.Calendar_32;
            this.pictureBox4.Location = new System.Drawing.Point(210, 90);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 132;
            this.pictureBox4.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(148, 4);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(676, 40);
            this.lblTitle.TabIndex = 126;
            this.lblTitle.Text = "Local Driving License Application";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Close
            // 
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.Image = global::Basis_W_App.Properties.Resources.Close_32;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(742, 504);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(98, 38);
            this.btn_Close.TabIndex = 124;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Image = global::Basis_W_App.Properties.Resources.Save_32;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(858, 504);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(98, 38);
            this.btn_Save.TabIndex = 123;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frmAddUpLocalLicApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(981, 552);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tc_ApplicationInfo);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddUpLocalLicApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmLocalLicApp";
            this.Activated += new System.EventHandler(this.frmAddUpLocalLicApp_Activated);
            this.Load += new System.EventHandler(this.frmAddUpLocalLicApp_Load);
            this.tp_PersonalInfo.ResumeLayout(false);
            this.tc_ApplicationInfo.ResumeLayout(false);
            this.tp_ApplicationInfo.ResumeLayout(false);
            this.tp_ApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_CreatedByUser;
        private System.Windows.Forms.Label lbl_Fees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AppNextToInfo;
        private System.Windows.Forms.TabPage tp_PersonalInfo;
        private System.Windows.Forms.TabControl tc_ApplicationInfo;
        private System.Windows.Forms.TabPage tp_ApplicationInfo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cb_LicenseClass;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_AppDate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_LocalLicensAppID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitle;
        private People.Controls.ctrPersonCardWithFilter ctrPersonCardWithFilter1;
    }
}