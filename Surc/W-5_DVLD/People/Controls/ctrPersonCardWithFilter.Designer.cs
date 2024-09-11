namespace Basis_W_App.People.Controls
{
    partial class ctrPersonCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_Filters = new System.Windows.Forms.GroupBox();
            this.btn_AddNewPerson = new System.Windows.Forms.Button();
            this.btn_FindPerson = new System.Windows.Forms.Button();
            this.cb_FilterBy = new System.Windows.Forms.ComboBox();
            this.txt_FilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrPersonCard1 = new Basis_W_App.People.Controls.ctrPersonCard();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gb_Filters.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gb_Filters
            // 
            this.gb_Filters.BackColor = System.Drawing.Color.MintCream;
            this.gb_Filters.Controls.Add(this.btn_AddNewPerson);
            this.gb_Filters.Controls.Add(this.btn_FindPerson);
            this.gb_Filters.Controls.Add(this.cb_FilterBy);
            this.gb_Filters.Controls.Add(this.txt_FilterValue);
            this.gb_Filters.Controls.Add(this.label1);
            this.gb_Filters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Filters.Location = new System.Drawing.Point(2, 3);
            this.gb_Filters.Name = "gb_Filters";
            this.gb_Filters.Size = new System.Drawing.Size(955, 77);
            this.gb_Filters.TabIndex = 17;
            this.gb_Filters.TabStop = false;
            this.gb_Filters.Text = "Filter";
            // 
            // btn_AddNewPerson
            // 
            this.btn_AddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddNewPerson.Image = global::Basis_W_App.Properties.Resources.AddPerson_32;
            this.btn_AddNewPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddNewPerson.Location = new System.Drawing.Point(883, 25);
            this.btn_AddNewPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_AddNewPerson.Name = "btn_AddNewPerson";
            this.btn_AddNewPerson.Size = new System.Drawing.Size(44, 37);
            this.btn_AddNewPerson.TabIndex = 20;
            this.btn_AddNewPerson.UseVisualStyleBackColor = true;
            this.btn_AddNewPerson.Click += new System.EventHandler(this.btn_AddNewPerson_Click);
            // 
            // btn_FindPerson
            // 
            this.btn_FindPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FindPerson.Image = global::Basis_W_App.Properties.Resources.SearchPerson;
            this.btn_FindPerson.Location = new System.Drawing.Point(823, 25);
            this.btn_FindPerson.Name = "btn_FindPerson";
            this.btn_FindPerson.Size = new System.Drawing.Size(44, 37);
            this.btn_FindPerson.TabIndex = 18;
            this.btn_FindPerson.UseVisualStyleBackColor = true;
            this.btn_FindPerson.Click += new System.EventHandler(this.btn_FindPerson_Click);
            // 
            // cb_FilterBy
            // 
            this.cb_FilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FilterBy.FormattingEnabled = true;
            this.cb_FilterBy.Items.AddRange(new object[] {
            "None",
            "National No.",
            "Person ID"});
            this.cb_FilterBy.Location = new System.Drawing.Point(96, 25);
            this.cb_FilterBy.Name = "cb_FilterBy";
            this.cb_FilterBy.Size = new System.Drawing.Size(210, 23);
            this.cb_FilterBy.TabIndex = 16;
            this.cb_FilterBy.SelectedIndexChanged += new System.EventHandler(this.cb_FilterBy_SelectedIndexChanged);
            // 
            // txt_FilterValue
            // 
            this.txt_FilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FilterValue.Location = new System.Drawing.Point(313, 25);
            this.txt_FilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_FilterValue.Name = "txt_FilterValue";
            this.txt_FilterValue.Size = new System.Drawing.Size(214, 21);
            this.txt_FilterValue.TabIndex = 17;
            this.txt_FilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FilterValue_KeyPress);
            this.txt_FilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txt_FilterValue_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Find By:";
            // 
            // ctrPersonCard1
            // 
            this.ctrPersonCard1.BackColor = System.Drawing.Color.MintCream;
            this.ctrPersonCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPersonCard1.Location = new System.Drawing.Point(2, 70);
            this.ctrPersonCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrPersonCard1.Name = "ctrPersonCard1";
            this.ctrPersonCard1.Size = new System.Drawing.Size(955, 299);
            this.ctrPersonCard1.TabIndex = 18;
            // 
            // ctrPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.ctrPersonCard1);
            this.Controls.Add(this.gb_Filters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrPersonCardWithFilter";
            this.Size = new System.Drawing.Size(958, 369);
            this.Load += new System.EventHandler(this.ctrPersonCardWithFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gb_Filters.ResumeLayout(false);
            this.gb_Filters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gb_Filters;
        private System.Windows.Forms.Button btn_AddNewPerson;
        private System.Windows.Forms.Button btn_FindPerson;
        private System.Windows.Forms.ComboBox cb_FilterBy;
        private System.Windows.Forms.TextBox txt_FilterValue;
        private System.Windows.Forms.Label label1;
        private ctrPersonCard ctrPersonCard1;
    }
}
