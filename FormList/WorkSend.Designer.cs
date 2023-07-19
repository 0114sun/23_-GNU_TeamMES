namespace FormList
{
    partial class WorkSend
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
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WorkPlace = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_WorkSend_register = new System.Windows.Forms.Button();
            this.btn_WorkSend_edit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_WorkSend_register);
            this.groupBox1.Controls.Add(this.btn_WorkSend_edit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.WorkPlace);
            this.groupBox1.Controls.Add(this.label2);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "작업지시화면";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "~";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(545, 74);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(150, 25);
            this.dateTimePicker2.TabIndex = 25;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1공장",
            "2공장",
            "3공장"});
            this.comboBox2.Location = new System.Drawing.Point(192, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(142, 23);
            this.comboBox2.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(365, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 25);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1공장",
            "2공장",
            "3공장"});
            this.comboBox1.Location = new System.Drawing.Point(16, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 23);
            this.comboBox1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "작업일자";
            // 
            // WorkPlace
            // 
            this.WorkPlace.AutoSize = true;
            this.WorkPlace.Location = new System.Drawing.Point(58, 44);
            this.WorkPlace.Name = "WorkPlace";
            this.WorkPlace.Size = new System.Drawing.Size(52, 15);
            this.WorkPlace.TabIndex = 20;
            this.WorkPlace.Text = "사업장";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "사업장";
            // 
            // btn_WorkSend_register
            // 
            this.btn_WorkSend_register.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_WorkSend_register.Location = new System.Drawing.Point(493, 22);
            this.btn_WorkSend_register.Name = "btn_WorkSend_register";
            this.btn_WorkSend_register.Size = new System.Drawing.Size(209, 112);
            this.btn_WorkSend_register.TabIndex = 28;
            this.btn_WorkSend_register.Text = "작업지시 등록";
            this.btn_WorkSend_register.UseVisualStyleBackColor = true;
            this.btn_WorkSend_register.Click += new System.EventHandler(this.btn_WorkSend_register_Click);
            // 
            // btn_WorkSend_edit
            // 
            this.btn_WorkSend_edit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_WorkSend_edit.Location = new System.Drawing.Point(702, 22);
            this.btn_WorkSend_edit.Name = "btn_WorkSend_edit";
            this.btn_WorkSend_edit.Size = new System.Drawing.Size(209, 112);
            this.btn_WorkSend_edit.TabIndex = 27;
            this.btn_WorkSend_edit.Text = "작업지시 수정";
            this.btn_WorkSend_edit.UseVisualStyleBackColor = true;
            this.btn_WorkSend_edit.Click += new System.EventHandler(this.btn_WorkSend_edit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(908, 398);
            this.dataGridView1.TabIndex = 2;
            // 
            // WorkSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "WorkSend";
            this.Text = "WorkSend";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_WorkSend_register;
        private System.Windows.Forms.Button btn_WorkSend_edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WorkPlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}