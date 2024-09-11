namespace Basis_W_App.People
{
    partial class frmListPeople
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl_RecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_FilterBy = new System.Windows.Forms.ComboBox();
            this.txt_FilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_People = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPersonStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendEmailStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneCallStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_People = new System.Windows.Forms.DataGridView();
            this.btn_AddPerson = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.cms_People.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_People)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(1355, 660);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(135, 36);
            this.btn_Close.TabIndex = 102;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(607, 196);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 39);
            this.lblTitle.TabIndex = 100;
            this.lblTitle.Text = "Manage People";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_RecordsCount
            // 
            this.lbl_RecordsCount.AutoSize = true;
            this.lbl_RecordsCount.Location = new System.Drawing.Point(110, 660);
            this.lbl_RecordsCount.Name = "lbl_RecordsCount";
            this.lbl_RecordsCount.Size = new System.Drawing.Size(27, 20);
            this.lbl_RecordsCount.TabIndex = 98;
            this.lbl_RecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 660);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 97;
            this.label2.Text = "# Records:";
            // 
            // cb_FilterBy
            // 
            this.cb_FilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FilterBy.FormattingEnabled = true;
            this.cb_FilterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gender",
            "Phone",
            "Email"});
            this.cb_FilterBy.Location = new System.Drawing.Point(84, 240);
            this.cb_FilterBy.Name = "cb_FilterBy";
            this.cb_FilterBy.Size = new System.Drawing.Size(210, 28);
            this.cb_FilterBy.TabIndex = 96;
            this.cb_FilterBy.SelectedIndexChanged += new System.EventHandler(this.cb_FilterBy_SelectedIndexChanged);
            // 
            // txt_FilterValue
            // 
            this.txt_FilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FilterValue.Location = new System.Drawing.Point(301, 240);
            this.txt_FilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_FilterValue.Name = "txt_FilterValue";
            this.txt_FilterValue.Size = new System.Drawing.Size(256, 26);
            this.txt_FilterValue.TabIndex = 95;
            this.txt_FilterValue.TextChanged += new System.EventHandler(this.txt_FilterValue_TextChanged);
            this.txt_FilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "Filter By:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // cms_People
            // 
            this.cms_People.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.AddPersonStripMenuItem,
            this.editToolStripMenuItem,
            this.DeleteStripMenuItem,
            this.toolStripSeparator1,
            this.SendEmailStripMenuItem,
            this.PhoneCallStripMenuItem});
            this.cms_People.Name = "contextMenuStrip1";
            this.cms_People.Size = new System.Drawing.Size(197, 266);
            // 
            // ShowDetailsToolStripMenuItem
            // 
            this.ShowDetailsToolStripMenuItem.Image = global::Basis_W_App.Properties.Resources.PersonDetails_32;
            this.ShowDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowDetailsToolStripMenuItem.Name = "ShowDetailsToolStripMenuItem";
            this.ShowDetailsToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.ShowDetailsToolStripMenuItem.Text = "&Show Details";
            this.ShowDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowDetailsToolStripMenuItem_Click);
            // 
            // AddPersonStripMenuItem
            // 
            this.AddPersonStripMenuItem.Image = global::Basis_W_App.Properties.Resources.AddPerson_32;
            this.AddPersonStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddPersonStripMenuItem.Name = "AddPersonStripMenuItem";
            this.AddPersonStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.AddPersonStripMenuItem.Text = "Add Person";
            this.AddPersonStripMenuItem.Click += new System.EventHandler(this.AddPersonStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Basis_W_App.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // DeleteStripMenuItem
            // 
            this.DeleteStripMenuItem.Image = global::Basis_W_App.Properties.Resources.Delete_32;
            this.DeleteStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteStripMenuItem.Name = "DeleteStripMenuItem";
            this.DeleteStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.DeleteStripMenuItem.Text = "&Delete";
            this.DeleteStripMenuItem.Click += new System.EventHandler(this.DeleteStripMenuItem_Click);
            // 
            // SendEmailStripMenuItem
            // 
            this.SendEmailStripMenuItem.Image = global::Basis_W_App.Properties.Resources.send_email_32;
            this.SendEmailStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SendEmailStripMenuItem.Name = "SendEmailStripMenuItem";
            this.SendEmailStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.SendEmailStripMenuItem.Text = "Send E&mail";
            this.SendEmailStripMenuItem.Click += new System.EventHandler(this.SendEmailStripMenuItem_Click);
            // 
            // PhoneCallStripMenuItem
            // 
            this.PhoneCallStripMenuItem.Image = global::Basis_W_App.Properties.Resources.call_32;
            this.PhoneCallStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PhoneCallStripMenuItem.Name = "PhoneCallStripMenuItem";
            this.PhoneCallStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.PhoneCallStripMenuItem.Text = "Phone &Call";
            this.PhoneCallStripMenuItem.Click += new System.EventHandler(this.PhoneCallStripMenuItem_Click);
            // 
            // dgv_People
            // 
            this.dgv_People.AllowUserToAddRows = false;
            this.dgv_People.AllowUserToDeleteRows = false;
            this.dgv_People.AllowUserToResizeRows = false;
            this.dgv_People.BackgroundColor = System.Drawing.Color.White;
            this.dgv_People.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_People.ContextMenuStrip = this.cms_People;
            this.dgv_People.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_People.Location = new System.Drawing.Point(6, 279);
            this.dgv_People.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_People.MultiSelect = false;
            this.dgv_People.Name = "dgv_People";
            this.dgv_People.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_People.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_People.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_People.Size = new System.Drawing.Size(1484, 371);
            this.dgv_People.TabIndex = 93;
            this.dgv_People.TabStop = false;
            this.dgv_People.DoubleClick += new System.EventHandler(this.dgv_People_DoubleClick);
            // 
            // btn_AddPerson
            // 
            this.btn_AddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddPerson.Image = global::Basis_W_App.Properties.Resources.Add_Person_40;
            this.btn_AddPerson.Location = new System.Drawing.Point(1402, 216);
            this.btn_AddPerson.Name = "btn_AddPerson";
            this.btn_AddPerson.Size = new System.Drawing.Size(88, 55);
            this.btn_AddPerson.TabIndex = 101;
            this.btn_AddPerson.UseVisualStyleBackColor = true;
            this.btn_AddPerson.Click += new System.EventHandler(this.btn_AddPerson_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPersonImage.Image = global::Basis_W_App.Properties.Resources.People_400;
            this.pbPersonImage.InitialImage = null;
            this.pbPersonImage.Location = new System.Drawing.Point(621, 2);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(220, 189);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 99;
            this.pbPersonImage.TabStop = false;
            // 
            // frmListPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Close;
            this.ClientSize = new System.Drawing.Size(1496, 705);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_AddPerson);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.lbl_RecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_FilterBy);
            this.Controls.Add(this.txt_FilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_People);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmListPeople";
            this.Load += new System.EventHandler(this.frmListPeople_Load);
            this.cms_People.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_People)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_AddPerson;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lbl_RecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_FilterBy;
        private System.Windows.Forms.TextBox txt_FilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem PhoneCallStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem DeleteStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPersonStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ShowDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_People;
        private System.Windows.Forms.ToolStripMenuItem SendEmailStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_People;
    }
}