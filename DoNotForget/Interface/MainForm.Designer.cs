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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnQueryAllSchedules = new System.Windows.Forms.Button();
            this.LtodaySchedules = new System.Windows.Forms.Label();
            this.clbTodaySchedules = new System.Windows.Forms.CheckedListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonMinimum = new System.Windows.Forms.Button();
            this.remindTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMonth1 = new diyControl.PanelMonth();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.remindTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlpButton);
            this.panel1.Controls.Add(this.LtodaySchedules);
            this.panel1.Controls.Add(this.clbTodaySchedules);
            this.panel1.Location = new System.Drawing.Point(508, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 377);
            this.panel1.TabIndex = 0;
            // 
            // tlpButton
            // 
            this.tlpButton.BackColor = System.Drawing.Color.Transparent;
            this.tlpButton.ColumnCount = 3;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.Controls.Add(this.btnDelete, 2, 1);
            this.tlpButton.Controls.Add(this.btnModify, 1, 1);
            this.tlpButton.Controls.Add(this.btnQueryAllSchedules, 0, 0);
            this.tlpButton.Controls.Add(this.btnAdd, 0, 1);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpButton.Location = new System.Drawing.Point(0, 266);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 2;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButton.Size = new System.Drawing.Size(292, 111);
            this.tlpButton.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(74)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(157)))), ((int)(((byte)(154)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(197, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 50);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除日程";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModify.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(74)))));
            this.btnModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(157)))), ((int)(((byte)(154)))));
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModify.Location = new System.Drawing.Point(100, 58);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(91, 50);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "修改日程";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnQueryAllSchedules
            // 
            this.btnQueryAllSchedules.BackColor = System.Drawing.Color.White;
            this.tlpButton.SetColumnSpan(this.btnQueryAllSchedules, 3);
            this.btnQueryAllSchedules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQueryAllSchedules.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQueryAllSchedules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(74)))));
            this.btnQueryAllSchedules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(157)))), ((int)(((byte)(154)))));
            this.btnQueryAllSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueryAllSchedules.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQueryAllSchedules.Location = new System.Drawing.Point(3, 0);
            this.btnQueryAllSchedules.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnQueryAllSchedules.Name = "btnQueryAllSchedules";
            this.btnQueryAllSchedules.Size = new System.Drawing.Size(286, 55);
            this.btnQueryAllSchedules.TabIndex = 3;
            this.btnQueryAllSchedules.Text = "查看所有日程";
            this.btnQueryAllSchedules.UseVisualStyleBackColor = false;
            this.btnQueryAllSchedules.Click += new System.EventHandler(this.btnQueryAllSchedules_Click);
            // 
            // LtodaySchedules
            // 
            this.LtodaySchedules.Dock = System.Windows.Forms.DockStyle.Top;
            this.LtodaySchedules.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LtodaySchedules.ForeColor = System.Drawing.Color.Black;
            this.LtodaySchedules.Location = new System.Drawing.Point(0, 0);
            this.LtodaySchedules.Name = "LtodaySchedules";
            this.LtodaySchedules.Size = new System.Drawing.Size(292, 29);
            this.LtodaySchedules.TabIndex = 1;
            this.LtodaySchedules.Text = "今日日程";
            this.LtodaySchedules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clbTodaySchedules
            // 
            this.clbTodaySchedules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbTodaySchedules.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clbTodaySchedules.FormattingEnabled = true;
            this.clbTodaySchedules.HorizontalScrollbar = true;
            this.clbTodaySchedules.Location = new System.Drawing.Point(0, 40);
            this.clbTodaySchedules.Name = "clbTodaySchedules";
            this.clbTodaySchedules.Size = new System.Drawing.Size(291, 193);
            this.clbTodaySchedules.TabIndex = 0;
            this.clbTodaySchedules.SelectedIndexChanged += new System.EventHandler(this.clbTodaySchedules_SelectedIndexChanged);
            this.clbTodaySchedules.MouseLeave += new System.EventHandler(this.clbTodaySchedules_MouseLeave);
            // 
            // buttonMinimum
            // 
            this.buttonMinimum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimum.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonMinimum.Location = new System.Drawing.Point(697, 9);
            this.buttonMinimum.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinimum.Name = "buttonMinimum";
            this.buttonMinimum.Size = new System.Drawing.Size(92, 27);
            this.buttonMinimum.TabIndex = 2;
            this.buttonMinimum.Text = "小窗显示";
            this.buttonMinimum.UseVisualStyleBackColor = true;
            this.buttonMinimum.Click += new System.EventHandler(this.buttonMinimum_Click);
            // 
            // remindTimer
            // 
            this.remindTimer.Enabled = true;
            this.remindTimer.Interval = 15000;
            this.remindTimer.Tick += new System.EventHandler(this.remindTimer_Tick);
            // 
            // panelMonth1
            // 
            this.panelMonth1.Datetime = new System.DateTime(2018, 12, 20, 22, 49, 26, 518);
            this.panelMonth1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMonth1.Location = new System.Drawing.Point(0, 0);
            this.panelMonth1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelMonth1.Name = "panelMonth1";
            this.panelMonth1.Size = new System.Drawing.Size(503, 682);
            this.panelMonth1.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Don\'t Forget";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem1.Text = "关闭";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // remindTip1
            // 
            this.remindTip1.IsBalloon = true;
            this.remindTip1.OwnerDraw = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(74)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(157)))), ((int)(((byte)(154)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(3, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加日程";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 682);
            this.Controls.Add(this.buttonMinimum);
            this.Controls.Add(this.panelMonth1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Don\'t Forgrt(万年历记事软件)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.tlpButton.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LtodaySchedules;
        private System.Windows.Forms.CheckedListBox clbTodaySchedules;
        private System.Windows.Forms.Button btnQueryAllSchedules;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private diyControl.PanelMonth panelMonth1;
        private System.Windows.Forms.Button buttonMinimum;
        private System.Windows.Forms.Timer remindTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolTip remindTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnAdd;
    }
}

