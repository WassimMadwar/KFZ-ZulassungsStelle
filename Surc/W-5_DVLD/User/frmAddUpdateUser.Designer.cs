namespace Basis_W_App.User
{
    partial class frmAddUpdateUser
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_IsActive = new System.Windows.Forms.CheckBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.btn_PersonInfoNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.tp_PersonalInfo = new System.Windows.Forms.TabPage();
            this.tp_LoginInfo = new System.Windows.Forms.TabPage();
            this.tc_UserInfo = new System.Windows.Forms.TabControl();
            this.ctrPersonCardWithFilterUser = new Basis_W_App.People.Controls.ctrPersonCardWithFilter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tp_PersonalInfo.SuspendLayout();
            this.tp_LoginInfo.SuspendLayout();
            this.tc_UserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(1108, 660);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(126, 37);
            this.btn_Save.TabIndex = 119;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(180, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(863, 39);
            this.lblTitle.TabIndex = 122;
            this.lblTitle.Text = "Add Edit User";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Close
            // 
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(938, 660);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(126, 37);
            this.btn_Close.TabIndex = 120;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.Location = new System.Drawing.Point(233, 58);
            this.lbl_UserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(39, 20);
            this.lbl_UserID.TabIndex = 129;
            this.lbl_UserID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 128;
            this.label4.Text = "UserID:";
            // 
            // chk_IsActive
            // 
            this.chk_IsActive.AutoSize = true;
            this.chk_IsActive.Checked = true;
            this.chk_IsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_IsActive.Location = new System.Drawing.Point(231, 214);
            this.chk_IsActive.Name = "chk_IsActive";
            this.chk_IsActive.Size = new System.Drawing.Size(88, 24);
            this.chk_IsActive.TabIndex = 127;
            this.chk_IsActive.Text = "Is Active";
            this.chk_IsActive.UseVisualStyleBackColor = true;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(231, 96);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UserName.MaxLength = 50;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(167, 26);
            this.txt_UserName.TabIndex = 118;
            this.txt_UserName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_UserName_Validating);
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(231, 168);
            this.txt_ConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ConfirmPassword.MaxLength = 50;
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.PasswordChar = '*';
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(167, 26);
            this.txt_ConfirmPassword.TabIndex = 124;
            this.txt_ConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ConfirmPassword_Validating);
            // 
            // btn_PersonInfoNext
            // 
            this.btn_PersonInfoNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PersonInfoNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PersonInfoNext.Location = new System.Drawing.Point(1097, 503);
            this.btn_PersonInfoNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_PersonInfoNext.Name = "btn_PersonInfoNext";
            this.btn_PersonInfoNext.Size = new System.Drawing.Size(126, 37);
            this.btn_PersonInfoNext.TabIndex = 119;
            this.btn_PersonInfoNext.Text = "Next";
            this.btn_PersonInfoNext.UseVisualStyleBackColor = true;
            this.btn_PersonInfoNext.Click += new System.EventHandler(this.btn_PersonInfoNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 120;
            this.label1.Text = "UserName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 125;
            this.label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 121;
            this.label2.Text = "Password:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(231, 132);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Password.MaxLength = 50;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(167, 26);
            this.txt_Password.TabIndex = 119;
            this.txt_Password.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Password_Validating);
            // 
            // tp_PersonalInfo
            // 
            this.tp_PersonalInfo.Controls.Add(this.btn_PersonInfoNext);
            this.tp_PersonalInfo.Controls.Add(this.ctrPersonCardWithFilterUser);
            this.tp_PersonalInfo.Location = new System.Drawing.Point(4, 29);
            this.tp_PersonalInfo.Name = "tp_PersonalInfo";
            this.tp_PersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tp_PersonalInfo.Size = new System.Drawing.Size(1251, 556);
            this.tp_PersonalInfo.TabIndex = 0;
            this.tp_PersonalInfo.Text = "Personal Info";
            this.tp_PersonalInfo.UseVisualStyleBackColor = true;
            // 
            // tp_LoginInfo
            // 
            this.tp_LoginInfo.Controls.Add(this.pictureBox2);
            this.tp_LoginInfo.Controls.Add(this.lbl_UserID);
            this.tp_LoginInfo.Controls.Add(this.label4);
            this.tp_LoginInfo.Controls.Add(this.chk_IsActive);
            this.tp_LoginInfo.Controls.Add(this.txt_UserName);
            this.tp_LoginInfo.Controls.Add(this.txt_ConfirmPassword);
            this.tp_LoginInfo.Controls.Add(this.label1);
            this.tp_LoginInfo.Controls.Add(this.label3);
            this.tp_LoginInfo.Controls.Add(this.label2);
            this.tp_LoginInfo.Controls.Add(this.txt_Password);
            this.tp_LoginInfo.Controls.Add(this.pictureBox1);
            this.tp_LoginInfo.Controls.Add(this.pictureBox8);
            this.tp_LoginInfo.Controls.Add(this.pictureBox3);
            this.tp_LoginInfo.Location = new System.Drawing.Point(4, 29);
            this.tp_LoginInfo.Name = "tp_LoginInfo";
            this.tp_LoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tp_LoginInfo.Size = new System.Drawing.Size(1251, 556);
            this.tp_LoginInfo.TabIndex = 1;
            this.tp_LoginInfo.Text = "LoginInfo";
            this.tp_LoginInfo.UseVisualStyleBackColor = true;
            // 
            // tc_UserInfo
            // 
            this.tc_UserInfo.Controls.Add(this.tp_PersonalInfo);
            this.tc_UserInfo.Controls.Add(this.tp_LoginInfo);
            this.tc_UserInfo.Location = new System.Drawing.Point(7, 63);
            this.tc_UserInfo.Name = "tc_UserInfo";
            this.tc_UserInfo.SelectedIndex = 0;
            this.tc_UserInfo.Size = new System.Drawing.Size(1259, 589);
            this.tc_UserInfo.TabIndex = 121;
            // 
            // ctrPersonCardWithFilterUser
            // 
            this.ctrPersonCardWithFilterUser.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrPersonCardWithFilterUser.FilterEnabled = true;
            this.ctrPersonCardWithFilterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPersonCardWithFilterUser.Location = new System.Drawing.Point(7, 7);
            this.ctrPersonCardWithFilterUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrPersonCardWithFilterUser.Name = "ctrPersonCardWithFilterUser";
            this.ctrPersonCardWithFilterUser.ShowAddPerson = true;
            this.ctrPersonCardWithFilterUser.Size = new System.Drawing.Size(1235, 486);
            this.ctrPersonCardWithFilterUser.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Basis_W_App.Properties.Resources.Number_321;
            this.pictureBox2.Location = new System.Drawing.Point(193, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 130;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Basis_W_App.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(193, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 126;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Basis_W_App.Properties.Resources.Person_32;
            this.pictureBox8.Location = new System.Drawing.Point(193, 94);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 123;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Basis_W_App.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(193, 131);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 122;
            this.pictureBox3.TabStop = false;
            // 
            // frmAddUpdateUser
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Close;
            this.ClientSize = new System.Drawing.Size(1273, 709);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.tc_UserInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddUpdateUser";
            this.Activated += new System.EventHandler(this.frmAddUpdateUser_Activated);
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tp_PersonalInfo.ResumeLayout(false);
            this.tp_LoginInfo.ResumeLayout(false);
            this.tp_LoginInfo.PerformLayout();
            this.tc_UserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TabControl tc_UserInfo;
        private System.Windows.Forms.TabPage tp_PersonalInfo;
        private System.Windows.Forms.Button btn_PersonInfoNext;
        private System.Windows.Forms.TabPage tp_LoginInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_IsActive;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private People.Controls.ctrPersonCardWithFilter ctrPersonCardWithFilterUser;
    }
}