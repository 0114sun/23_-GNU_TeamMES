namespace PopupList
{
    partial class Facility_register
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
            this.cbx_m_preSerMth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_m_id = new System.Windows.Forms.TextBox();
            this.txt_m_manufac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_m_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.cbx_m_place = new System.Windows.Forms.ComboBox();
            this.Grid_Fr = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Fr)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_m_preSerMth
            // 
            this.cbx_m_preSerMth.FormattingEnabled = true;
            this.cbx_m_preSerMth.Location = new System.Drawing.Point(159, 270);
            this.cbx_m_preSerMth.Name = "cbx_m_preSerMth";
            this.cbx_m_preSerMth.Size = new System.Drawing.Size(150, 23);
            this.cbx_m_preSerMth.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "장비ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "예방정비 방법";
            // 
            // txt_m_id
            // 
            this.txt_m_id.Location = new System.Drawing.Point(159, 89);
            this.txt_m_id.Name = "txt_m_id";
            this.txt_m_id.Size = new System.Drawing.Size(150, 25);
            this.txt_m_id.TabIndex = 12;
            // 
            // txt_m_manufac
            // 
            this.txt_m_manufac.Location = new System.Drawing.Point(159, 205);
            this.txt_m_manufac.Name = "txt_m_manufac";
            this.txt_m_manufac.Size = new System.Drawing.Size(150, 25);
            this.txt_m_manufac.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "장비이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "제조사";
            // 
            // txt_m_name
            // 
            this.txt_m_name.Location = new System.Drawing.Point(159, 141);
            this.txt_m_name.Name = "txt_m_name";
            this.txt_m_name.Size = new System.Drawing.Size(150, 25);
            this.txt_m_name.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "설치작업장";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(343, 263);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(80, 50);
            this.btn_register.TabIndex = 21;
            this.btn_register.Text = "등록";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // cbx_m_place
            // 
            this.cbx_m_place.FormattingEnabled = true;
            this.cbx_m_place.Location = new System.Drawing.Point(159, 334);
            this.cbx_m_place.Name = "cbx_m_place";
            this.cbx_m_place.Size = new System.Drawing.Size(150, 23);
            this.cbx_m_place.TabIndex = 22;
            // 
            // Grid_Fr
            // 
            this.Grid_Fr.AllowUserToAddRows = false;
            this.Grid_Fr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Fr.Location = new System.Drawing.Point(446, 29);
            this.Grid_Fr.Name = "Grid_Fr";
            this.Grid_Fr.RowHeadersWidth = 51;
            this.Grid_Fr.RowTemplate.Height = 27;
            this.Grid_Fr.Size = new System.Drawing.Size(664, 420);
            this.Grid_Fr.TabIndex = 23;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(343, 190);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 50);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "←";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(343, 111);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(80, 50);
            this.btn_add.TabIndex = 25;
            this.btn_add.Text = "→";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Facility_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 475);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.Grid_Fr);
            this.Controls.Add(this.cbx_m_place);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.cbx_m_preSerMth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_m_id);
            this.Controls.Add(this.txt_m_manufac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_m_name);
            this.Controls.Add(this.label4);
            this.Name = "Facility_register";
            this.Text = "Facility_register";
            this.Load += new System.EventHandler(this.Facility_register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Fr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_m_preSerMth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_m_id;
        private System.Windows.Forms.TextBox txt_m_manufac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_m_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.ComboBox cbx_m_place;
        private System.Windows.Forms.DataGridView Grid_Fr;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
    }
}