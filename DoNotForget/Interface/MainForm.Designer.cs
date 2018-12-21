namespace Interface {
    partial class MainForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQueryAllSchedules = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.LtodaySchedules = new System.Windows.Forms.Label();
            this.clbTodaySchedules = new System.Windows.Forms.CheckedListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMonth1 = new diyControl.PanelMonth();
            this.buttonMinimum = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnQueryAllSchedules);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.LtodaySchedules);
            this.panel1.Controls.Add(this.clbTodaySchedules);
            this.panel1.Location = new System.Drawing.Point(762, 271);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 553);
            this.panel1.TabIndex = 0;
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Location = new System.Drawing.Point(156, 467);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(108, 35);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "修改日程";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(273, 467);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除日程";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnQueryAllSchedules
            // 
            this.btnQueryAllSchedules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueryAllSchedules.Location = new System.Drawing.Point(76, 422);
            this.btnQueryAllSchedules.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQueryAllSchedules.Name = "btnQueryAllSchedules";
            this.btnQueryAllSchedules.Size = new System.Drawing.Size(273, 35);
            this.btnQueryAllSchedules.TabIndex = 3;
            this.btnQueryAllSchedules.Text = "查看所有日程";
            this.btnQueryAllSchedules.UseVisualStyleBackColor = true;
            this.btnQueryAllSchedules.Click += new System.EventHandler(this.btnQueryAllSchedules_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(39, 467);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加日程";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // LtodaySchedules
            // 
            this.LtodaySchedules.Dock = System.Windows.Forms.DockStyle.Top;
            this.LtodaySchedules.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LtodaySchedules.ForeColor = System.Drawing.Color.Blue;
            this.LtodaySchedules.Location = new System.Drawing.Point(0, 0);
            this.LtodaySchedules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LtodaySchedules.Name = "LtodaySchedules";
            this.LtodaySchedules.Size = new System.Drawing.Size(438, 43);
            this.LtodaySchedules.TabIndex = 1;
            this.LtodaySchedules.Text = "今日日程";
            this.LtodaySchedules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clbTodaySchedules
            // 
            this.clbTodaySchedules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbTodaySchedules.FormattingEnabled = true;
            this.clbTodaySchedules.HorizontalScrollbar = true;
            this.clbTodaySchedules.Location = new System.Drawing.Point(0, 48);
            this.clbTodaySchedules.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbTodaySchedules.Name = "clbTodaySchedules";
            this.clbTodaySchedules.Size = new System.Drawing.Size(435, 303);
            this.clbTodaySchedules.TabIndex = 0;
            this.clbTodaySchedules.SelectedIndexChanged += new System.EventHandler(this.clbTodaySchedules_SelectedIndexChanged);
            this.clbTodaySchedules.MouseLeave += new System.EventHandler(this.clbTodaySchedules_MouseLeave);
            // 
            // panelMonth1
            // 
            this.panelMonth1.Datetime = new System.DateTime(2018, 12, 20, 22, 49, 26, 518);
            this.panelMonth1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMonth1.Location = new System.Drawing.Point(0, 0);
            this.panelMonth1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelMonth1.Name = "panelMonth1";
            this.panelMonth1.Size = new System.Drawing.Size(755, 858);
            this.panelMonth1.TabIndex = 1;
            // 
            // buttonMinimum
            // 
            this.buttonMinimum.Location = new System.Drawing.Point(801, 271);
            this.buttonMinimum.Name = "buttonMinimum";
            this.buttonMinimum.Size = new System.Drawing.Size(96, 34);
            this.buttonMinimum.TabIndex = 2;
            this.buttonMinimum.Text = "最小化";
            this.buttonMinimum.UseVisualStyleBackColor = true;
            this.buttonMinimum.Click += new System.EventHandler(this.buttonMinimum_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 858);
            this.Controls.Add(this.buttonMinimum);
            this.Controls.Add(this.panelMonth1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Don\'t Forgrt(万年历记事软件)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LtodaySchedules;
        private System.Windows.Forms.CheckedListBox clbTodaySchedules;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnQueryAllSchedules;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private diyControl.PanelMonth panelMonth1;
        private System.Windows.Forms.Button buttonMinimum;
    }
}

