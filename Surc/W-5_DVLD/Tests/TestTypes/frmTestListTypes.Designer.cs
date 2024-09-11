namespace Basis_W_App.Tests.TestTypes
{
    partial class frmTestListTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl_RecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_TestTypes = new System.Windows.Forms.DataGridView();
            this.cms_TestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TestTypes)).BeginInit();
            this.cms_TestTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(375, 4);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(434, 60);
            this.lblTitle.TabIndex = 128;
            this.lblTitle.Text = "Manage Test Types";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_RecordsCount
            // 
            this.lbl_RecordsCount.AutoSize = true;
            this.lbl_RecordsCount.Location = new System.Drawing.Point(169, 452);
            this.lbl_RecordsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RecordsCount.Name = "lbl_RecordsCount";
            this.lbl_RecordsCount.Size = new System.Drawing.Size(27, 20);
            this.lbl_RecordsCount.TabIndex = 127;
            this.lbl_RecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 452);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 126;
            this.label2.Text = "# Records :";
            // 
            // dgv_TestTypes
            // 
            this.dgv_TestTypes.AllowUserToAddRows = false;
            this.dgv_TestTypes.AllowUserToDeleteRows = false;
            this.dgv_TestTypes.AllowUserToResizeRows = false;
            this.dgv_TestTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TestTypes.ContextMenuStrip = this.cms_TestTypes;
            this.dgv_TestTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_TestTypes.Location = new System.Drawing.Point(7, 75);
            this.dgv_TestTypes.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dgv_TestTypes.MultiSelect = false;
            this.dgv_TestTypes.Name = "dgv_TestTypes";
            this.dgv_TestTypes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TestTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TestTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TestTypes.Size = new System.Drawing.Size(1161, 355);
            this.dgv_TestTypes.TabIndex = 125;
            this.dgv_TestTypes.TabStop = false;
            // 
            // cms_TestTypes
            // 
            this.cms_TestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.EditStripMenu,
            this.toolStripSeparator1});
            this.cms_TestTypes.Name = "contextMenuStrip1";
            this.cms_TestTypes.Size = new System.Drawing.Size(161, 54);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // EditStripMenu
            // 
            this.EditStripMenu.Image = global::Basis_W_App.Properties.Resources.edit_32;
            this.EditStripMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditStripMenu.Name = "EditStripMenu";
            this.EditStripMenu.Size = new System.Drawing.Size(196, 38);
            this.EditStripMenu.Text = "&Edit Test Type";
            this.EditStripMenu.Click += new System.EventHandler(this.EditStripMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // btn_Close
            // 
            this.btn_Close.AutoEllipsis = true;
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(1027, 448);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(139, 37);
            this.btn_Close.TabIndex = 129;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frmTestListTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 493);
            this.ContextMenuStrip = this.cms_TestTypes;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lbl_RecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_TestTypes);
            this.Controls.Add(this.btn_Close);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTestListTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTestListTypes";
            this.Load += new System.EventHandler(this.frmTestListTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TestTypes)).EndInit();
            this.cms_TestTypes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbl_RecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_TestTypes;
        private System.Windows.Forms.ContextMenuStrip cms_TestTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem EditStripMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btn_Close;
    }
}