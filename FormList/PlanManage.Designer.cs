namespace FormList
{
    partial class PlanManage
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
            this.myCalendar = new Calendar.NET.Calendar();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.myCalendar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "스케쥴관리 화면";
            // 
            // myCalendar
            // 
            this.myCalendar.AllowEditingEvents = true;
            this.myCalendar.CalendarDate = new System.DateTime(2023, 7, 17, 19, 59, 14, 2);
            this.myCalendar.CalendarView = Calendar.NET.CalendarViews.Month;
            this.myCalendar.DateHeaderFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.myCalendar.DayOfWeekFont = new System.Drawing.Font("Arial", 10F);
            this.myCalendar.DaysFont = new System.Drawing.Font("Arial", 10F);
            this.myCalendar.DayViewTimeFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.myCalendar.DimDisabledEvents = true;
            this.myCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myCalendar.HighlightCurrentDay = true;
            this.myCalendar.LoadPresetHolidays = true;
            this.myCalendar.Location = new System.Drawing.Point(3, 17);
            this.myCalendar.Name = "myCalendar";
            this.myCalendar.ShowArrowControls = true;
            this.myCalendar.ShowDashedBorderOnDisabledEvents = true;
            this.myCalendar.ShowDateInHeader = true;
            this.myCalendar.ShowDisabledEvents = false;
            this.myCalendar.ShowEventTooltips = true;
            this.myCalendar.ShowTodayButton = true;
            this.myCalendar.Size = new System.Drawing.Size(794, 320);
            this.myCalendar.TabIndex = 0;
            this.myCalendar.TodayFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            // 
            // PlanManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PlanManage";
            this.Text = "PlanManage";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Calendar.NET.Calendar myCalendar;
    }
}