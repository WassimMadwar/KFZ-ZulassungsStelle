namespace Basis_W_App.Applications.ApplicationTypes
{
    partial class frmListAppTypes
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl_RecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_AppTypes = new System.Windows.Forms.DataGridView();
            this.cms_AppTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Close = new System.Windows.Forms.Button();
            this.EditStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pbApplicationTypesmage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AppTypes)).BeginInit();
            this.cms_AppTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationTypesmage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(118, 207);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(446, 39);
            this.lblTitle.TabIndex = 117;
            this.lblTitle.Text = "Manage Application Types";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_RecordsCount
            // 
            this.lbl_RecordsCount.AutoSize = true;
            this.lbl_RecordsCount.Location = new System.Drawing.Point(106, 581);
            this.lbl_RecordsCount.Name = "lbl_RecordsCount";
            this.lbl_RecordsCount.Size = new System.Drawing.Size(27, 20);
            this.lbl_RecordsCount.TabIndex = 115;
            this.lbl_RecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 581);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 114;
            this.label2.Text = "# Records:";
            // 
            // dgv_AppTypes
            // 
            this.dgv_AppTypes.AllowUserToAddRows = false;
            this.dgv_AppTypes.AllowUserToDeleteRows = false;
            this.dgv_AppTypes.AllowUserToResizeRows = false;
            this.dgv_AppTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_AppTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AppTypes.ContextMenuStrip = this.cms_AppTypes;
            this.dgv_AppTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_AppTypes.Location = new System.Drawing.Point(2, 267);
            this.dgv_AppTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_AppTypes.MultiSelect = false;
            this.dgv_AppTypes.Name = "dgv_AppTypes";
            this.dgv_AppTypes.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_AppTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_AppTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AppTypes.Size = new System.Drawing.Size(679, 290);
            this.dgv_AppTypes.TabIndex = 113;
            this.dgv_AppTypes.TabStop = false;
            // 
            // cms_AppTypes
            // 
            this.cms_AppTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.EditStripMenu,
            this.toolStripSeparator1});
            this.cms_AppTypes.Name = "contextMenuStrip1";
            this.cms_AppTypes.Size = new System.Drawing.Size(202, 54);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(198, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // btn_Close
            // 
            this.btn_Close.AutoEllipsis = true;
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(546, 574);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(135, 36);
            this.btn_Close.TabIndex = 112;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // EditStripMenu
            // 
            this.EditStripMenu.Image = global::Basis_W_App.Properties.Resources.edit_32;
            this.EditStripMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditStripMenu.Name = "EditStripMenu";
            this.EditStripMenu.Size = new System.Drawing.Size(201, 38);
            this.EditStripMenu.Text = "&Edit Application Type";
            this.EditStripMenu.Click += new System.EventHandler(this.EditStripMenu_Click);
            // 
            // pbApplicationTypesmage
            // 
            this.pbApplicationTypesmage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbApplicationTypesmage.Image = global::Basis_W_App.Properties.Resources.Application_Types_512;
            this.pbApplicationTypesmage.InitialImage = null;
            this.pbApplicationTypesmage.Location = new System.Drawing.Point(231, 2);
            this.pbApplicationTypesmage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbApplicationTypesmage.Name = "pbApplicationTypesmage";
            this.pbApplicationTypesmage.Size = new System.Drawing.Size(220, 189);
            this.pbApplicationTypesmage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicationTypesmage.TabIndex = 116;
            this.pbApplicationTypesmage.TabStop = false;
            // 
            // frmListAppTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 613);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lbl_RecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_AppTypes);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.pbApplicationTypesmage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListAppTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmListAppTypes";
            this.Load += new System.EventHandler(this.frmListAppTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AppTypes)).EndInit();
            this.cms_AppTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationTypesmage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbl_RecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_AppTypes;
        private System.Windows.Forms.ContextMenuStrip cms_AppTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem EditStripMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.PictureBox pbApplicationTypesmage;
    }
}