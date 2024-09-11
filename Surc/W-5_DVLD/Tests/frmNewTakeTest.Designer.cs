namespace Basis_W_App.Tests
{
    partial class frmNewTakeTest
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
            this.lbl_UserMessage = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.rb_Fail = new System.Windows.Forms.RadioButton();
            this.rb_Pass = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ctrTakeTest1 = new Basis_W_App.Tests.Controls.ctrTakeTest();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_UserMessage
            // 
            this.lbl_UserMessage.AutoSize = true;
            this.lbl_UserMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserMessage.ForeColor = System.Drawing.Color.Red;
            this.lbl_UserMessage.Location = new System.Drawing.Point(261, 600);
            this.lbl_UserMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_UserMessage.Name = "lbl_UserMessage";
            this.lbl_UserMessage.Size = new System.Drawing.Size(255, 20);
            this.lbl_UserMessage.TabIndex = 209;
            this.lbl_UserMessage.Text = "You cannot change the results";
            this.lbl_UserMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_UserMessage.Visible = false;
            // 
            // btn_Close
            // 
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.Image = global::Basis_W_App.Properties.Resources.Close_32;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(267, 752);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(126, 37);
            this.btn_Close.TabIndex = 208;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Image = global::Basis_W_App.Properties.Resources.Save_32;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(408, 753);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(137, 36);
            this.btn_Save.TabIndex = 207;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(132, 647);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(408, 91);
            this.txt_Notes.TabIndex = 206;
            // 
            // rb_Fail
            // 
            this.rb_Fail.AutoSize = true;
            this.rb_Fail.Location = new System.Drawing.Point(200, 598);
            this.rb_Fail.Name = "rb_Fail";
            this.rb_Fail.Size = new System.Drawing.Size(52, 24);
            this.rb_Fail.TabIndex = 205;
            this.rb_Fail.Text = "Fail";
            this.rb_Fail.UseVisualStyleBackColor = true;
            // 
            // rb_Pass
            // 
            this.rb_Pass.AutoSize = true;
            this.rb_Pass.Checked = true;
            this.rb_Pass.Location = new System.Drawing.Point(132, 598);
            this.rb_Pass.Name = "rb_Pass";
            this.rb_Pass.Size = new System.Drawing.Size(62, 24);
            this.rb_Pass.TabIndex = 204;
            this.rb_Pass.TabStop = true;
            this.rb_Pass.Text = "Pass";
            this.rb_Pass.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 647);
            this.label10.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 202;
            this.label10.Text = "Notes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 596);
            this.label8.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 200;
            this.label8.Text = "Result:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Basis_W_App.Properties.Resources.Notes_32;
            this.pictureBox7.Location = new System.Drawing.Point(84, 647);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 203;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Basis_W_App.Properties.Resources.Retake_Test_32;
            this.pictureBox4.Location = new System.Drawing.Point(84, 596);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 201;
            this.pictureBox4.TabStop = false;
            // 
            // ctrTakeTest1
            // 
            this.ctrTakeTest1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ctrTakeTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrTakeTest1.Location = new System.Drawing.Point(-1, 0);
            this.ctrTakeTest1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrTakeTest1.Name = "ctrTakeTest1";
            this.ctrTakeTest1.Size = new System.Drawing.Size(576, 570);
            this.ctrTakeTest1.TabIndex = 210;
            this.ctrTakeTest1.TestTypeID = W_Business_.Test_B.clsTestType_B.enTestTypeID.VisionTest;
            // 
            // frmNewTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(575, 799);
            this.Controls.Add(this.ctrTakeTest1);
            this.Controls.Add(this.lbl_UserMessage);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.rb_Fail);
            this.Controls.Add(this.rb_Pass);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNewTakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewTakeTest";
            this.Load += new System.EventHandler(this.frmNewTakeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserMessage;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.RadioButton rb_Fail;
        private System.Windows.Forms.RadioButton rb_Pass;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private Controls.ctrTakeTest ctrTakeTest1;
    }
}