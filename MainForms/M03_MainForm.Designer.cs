﻿namespace MainForms
{
    partial class M03_MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.WorkSend = new System.Windows.Forms.ToolStripMenuItem();
            this.PlanManage = new System.Windows.Forms.ToolStripMenuItem();
            this.RealTimeMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.FacilityManage = new System.Windows.Forms.ToolStripMenuItem();
            this.FacilityWarning = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseM = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.UserMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsFormName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsNowDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timNowDate = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabMyTab = new Services.MyTabControl();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.WorkSend,
            this.PlanManage,
            this.RealTimeMonitor,
            this.FacilityManage,
            this.FacilityWarning,
            this.BaseM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 505);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(1, 20, 1, 10);
            this.toolStripTextBox1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(111, 30);
            this.toolStripTextBox1.Text = "Endure";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStripTextBox2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 20);
            this.toolStripTextBox2.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(111, 30);
            this.toolStripTextBox2.Text = "MES_System";
            // 
            // WorkSend
            // 
            this.WorkSend.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WorkSend.Name = "WorkSend";
            this.WorkSend.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.WorkSend.Size = new System.Drawing.Size(113, 51);
            this.WorkSend.Text = "작업지시";
            this.WorkSend.Click += new System.EventHandler(this.WorkSend_Click);
            // 
            // PlanManage
            // 
            this.PlanManage.Name = "PlanManage";
            this.PlanManage.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.PlanManage.Size = new System.Drawing.Size(113, 49);
            this.PlanManage.Text = "스케쥴관리";
            this.PlanManage.Click += new System.EventHandler(this.PlanManage_Click);
            // 
            // RealTimeMonitor
            // 
            this.RealTimeMonitor.Name = "RealTimeMonitor";
            this.RealTimeMonitor.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.RealTimeMonitor.Size = new System.Drawing.Size(113, 49);
            this.RealTimeMonitor.Text = "설비보전 모니터링";
            this.RealTimeMonitor.Click += new System.EventHandler(this.RealTimeMonitor_Click);
            // 
            // FacilityManage
            // 
            this.FacilityManage.Name = "FacilityManage";
            this.FacilityManage.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.FacilityManage.Size = new System.Drawing.Size(113, 49);
            this.FacilityManage.Text = "설비자산관리";
            this.FacilityManage.Click += new System.EventHandler(this.FacilityManage_Click);
            // 
            // FacilityWarning
            // 
            this.FacilityWarning.Name = "FacilityWarning";
            this.FacilityWarning.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.FacilityWarning.Size = new System.Drawing.Size(113, 49);
            this.FacilityWarning.Text = "설비 이상치 탐지";
            this.FacilityWarning.Click += new System.EventHandler(this.FacilityWarning_Click);
            // 
            // BaseM
            // 
            this.BaseM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMaster,
            this.UserMaster});
            this.BaseM.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BaseM.Name = "BaseM";
            this.BaseM.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.BaseM.Size = new System.Drawing.Size(113, 51);
            this.BaseM.Text = "기준정보";
            this.BaseM.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BaseM_DropDownItemClicked);
            // 
            // ItemMaster
            // 
            this.ItemMaster.Name = "ItemMaster";
            this.ItemMaster.Size = new System.Drawing.Size(159, 22);
            this.ItemMaster.Text = "품목 마스터";
            // 
            // UserMaster
            // 
            this.UserMaster.Name = "UserMaster";
            this.UserMaster.Size = new System.Drawing.Size(159, 22);
            this.UserMaster.Text = "사용자 마스터";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSearch,
            this.btnAdd,
            this.btnSave,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnClose,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(126, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(747, 83);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::MainForms.Properties.Resources.BtnSearch;
            this.btnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 80);
            this.btnSearch.Text = "조회";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::MainForms.Properties.Resources.BtnAdd;
            this.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 80);
            this.btnAdd.Text = "추가";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::MainForms.Properties.Resources.BtnSaveB;
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 80);
            this.btnSave.Text = "저장";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::MainForms.Properties.Resources.BtnDelete;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 80);
            this.btnDelete.Text = "삭제";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 83);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::MainForms.Properties.Resources.BtnClose;
            this.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 80);
            this.btnClose.Text = "닫기";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::MainForms.Properties.Resources.BtcExit;
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 80);
            this.btnExit.Text = "종료";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsFormName,
            this.toolStripStatusLabel2,
            this.stsUserName,
            this.stsNowDate});
            this.statusStrip1.Location = new System.Drawing.Point(126, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(747, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stsFormName
            // 
            this.stsFormName.AutoSize = false;
            this.stsFormName.Name = "stsFormName";
            this.stsFormName.Size = new System.Drawing.Size(200, 17);
            this.stsFormName.Text = "FormName";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(182, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // stsUserName
            // 
            this.stsUserName.AutoSize = false;
            this.stsUserName.Name = "stsUserName";
            this.stsUserName.Size = new System.Drawing.Size(150, 17);
            this.stsUserName.Text = "UserName";
            // 
            // stsNowDate
            // 
            this.stsNowDate.AutoSize = false;
            this.stsNowDate.Name = "stsNowDate";
            this.stsNowDate.Size = new System.Drawing.Size(200, 17);
            this.stsNowDate.Text = "Datetime";
            // 
            // timNowDate
            // 
            this.timNowDate.Interval = 1000;
            this.timNowDate.Tick += new System.EventHandler(this.timNowDate_Tick);
            // 
            // tabMyTab
            // 
            this.tabMyTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMyTab.Location = new System.Drawing.Point(126, 83);
            this.tabMyTab.Name = "tabMyTab";
            this.tabMyTab.SelectedIndex = 0;
            this.tabMyTab.Size = new System.Drawing.Size(747, 400);
            this.tabMyTab.TabIndex = 3;
            // 
            // M03_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 505);
            this.Controls.Add(this.tabMyTab);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "M03_MainForm";
            this.Text = "Endure_MES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.M03_MainForm_FormClosing);
            this.Load += new System.EventHandler(this.M03_MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsFormName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel stsUserName;
        private System.Windows.Forms.ToolStripStatusLabel stsNowDate;
        private System.Windows.Forms.Timer timNowDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem BaseM;
        private System.Windows.Forms.ToolStripMenuItem ItemMaster;
        private System.Windows.Forms.ToolStripMenuItem UserMaster;
        private Services.MyTabControl tabMyTab;
        private System.Windows.Forms.ToolStripMenuItem WorkSend;
        private System.Windows.Forms.ToolStripMenuItem PlanManage;
        private System.Windows.Forms.ToolStripMenuItem RealTimeMonitor;
        private System.Windows.Forms.ToolStripMenuItem FacilityManage;
        private System.Windows.Forms.ToolStripMenuItem FacilityWarning;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
    }
}