namespace Basis_W_App.Applications.Local_Driving_License
{
    partial class frmShowLocalLicenseAppInfo
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.ctrLocalLicenseAppInfo1 = new Basis_W_App.Applications.Local_Driving_License.ctrLocalLicenseAppInfo();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(0, 412);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(899, 61);
            this.btn_Close.TabIndex = 18;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // ctrLocalLicenseAppInfo1
            // 
            this.ctrLocalLicenseAppInfo1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ctrLocalLicenseAppInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrLocalLicenseAppInfo1.Location = new System.Drawing.Point(-1, 0);
            this.ctrLocalLicenseAppInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrLocalLicenseAppInfo1.Name = "ctrLocalLicenseAppInfo1";
            this.ctrLocalLicenseAppInfo1.Size = new System.Drawing.Size(902, 412);
            this.ctrLocalLicenseAppInfo1.TabIndex = 19;
            // 
            // frmShowLocalLicenseAppInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.CancelButton = this.btn_Close;
            this.ClientSize = new System.Drawing.Size(899, 473);
            this.Controls.Add(this.ctrLocalLicenseAppInfo1);
            this.Controls.Add(this.btn_Close);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmShowLocalLicenseAppInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Local License App Info";
            this.Load += new System.EventHandler(this.frmShowLocalLicenseAppInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private ctrLocalLicenseAppInfo ctrLocalLicenseAppInfo1;
    }
}