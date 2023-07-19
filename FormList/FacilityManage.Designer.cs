namespace FormList
{
    partial class FacilityManage
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
            this.Facility = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Location_Facility = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.WorkPlace = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_register_F = new System.Windows.Forms.Button();
            this.btn_edit_F = new System.Windows.Forms.Button();
            this.Grid_FM = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_FM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.btn_register_F);
            this.groupBox1.Controls.Add(this.btn_edit_F);
            this.groupBox1.Controls.Add(this.Facility);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.Location_Facility);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.WorkPlace);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Size = new System.Drawing.Size(1169, 138);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Grid_FM);
            this.groupBox2.Size = new System.Drawing.Size(1169, 528);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "설비관리화면";
            // 
            // Facility
            // 
            this.Facility.AutoSize = true;
            this.Facility.Location = new System.Drawing.Point(592, 48);
            this.Facility.Name = "Facility";
            this.Facility.Size = new System.Drawing.Size(67, 15);
            this.Facility.TabIndex = 12;
            this.Facility.Text = "설비선택";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "A장비",
            "B장비",
            "C장비"});
            this.comboBox3.Location = new System.Drawing.Point(550, 77);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(142, 23);
            this.comboBox3.TabIndex = 11;
            // 
            // Location_Facility
            // 
            this.Location_Facility.AutoSize = true;
            this.Location_Facility.Location = new System.Drawing.Point(407, 48);
            this.Location_Facility.Name = "Location_Facility";
            this.Location_Facility.Size = new System.Drawing.Size(67, 15);
            this.Location_Facility.TabIndex = 10;
            this.Location_Facility.Text = "설비위치";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "제품작업장",
            "반제품작업장"});
            this.comboBox2.Location = new System.Drawing.Point(365, 77);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(142, 23);
            this.comboBox2.TabIndex = 9;
            // 
            // WorkPlace
            // 
            this.WorkPlace.AutoSize = true;
            this.WorkPlace.Location = new System.Drawing.Point(226, 48);
            this.WorkPlace.Name = "WorkPlace";
            this.WorkPlace.Size = new System.Drawing.Size(52, 15);
            this.WorkPlace.TabIndex = 8;
            this.WorkPlace.Text = "사업장";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1공장",
            "2공장",
            "3공장"});
            this.comboBox1.Location = new System.Drawing.Point(184, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // btn_register_F
            // 
            this.btn_register_F.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_register_F.Location = new System.Drawing.Point(766, 22);
            this.btn_register_F.Name = "btn_register_F";
            this.btn_register_F.Size = new System.Drawing.Size(200, 112);
            this.btn_register_F.TabIndex = 14;
            this.btn_register_F.Text = "설비 정보 등록";
            this.btn_register_F.UseVisualStyleBackColor = true;
            this.btn_register_F.Click += new System.EventHandler(this.btn_register_F_Click);
            // 
            // btn_edit_F
            // 
            this.btn_edit_F.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_edit_F.Location = new System.Drawing.Point(966, 22);
            this.btn_edit_F.Name = "btn_edit_F";
            this.btn_edit_F.Size = new System.Drawing.Size(200, 112);
            this.btn_edit_F.TabIndex = 13;
            this.btn_edit_F.Text = "설비 정보 수정";
            this.btn_edit_F.UseVisualStyleBackColor = true;
            this.btn_edit_F.Click += new System.EventHandler(this.btn_edit_F_Click);
            // 
            // Grid_FM
            // 
            this.Grid_FM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_FM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_FM.Location = new System.Drawing.Point(3, 22);
            this.Grid_FM.Name = "Grid_FM";
            this.Grid_FM.RowHeadersWidth = 51;
            this.Grid_FM.Size = new System.Drawing.Size(1163, 502);
            this.Grid_FM.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "장비ID";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "A장비",
            "B장비",
            "C장비"});
            this.comboBox4.Location = new System.Drawing.Point(12, 77);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(142, 23);
            this.comboBox4.TabIndex = 15;
            // 
            // FacilityManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 666);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FacilityManage";
            this.Text = "FacilityManage";
            this.Load += new System.EventHandler(this.FacilityManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_FM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_register_F;
        private System.Windows.Forms.Button btn_edit_F;
        private System.Windows.Forms.Label Facility;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label Location_Facility;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label WorkPlace;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView Grid_FM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}