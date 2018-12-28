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
            this.lbTodaySchedules = new System.Windows.Forms.ListBox();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnQueryAllSchedules = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.LtodaySchedules = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonMinimum = new System.Windows.Forms.Button();
            this.remindTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMonth1 = new diyControl.PanelMonth();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.remindTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbWeather = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTodaySchedules);
            this.panel1.Controls.Add(this.tlpButton);
            this.panel1.Controls.Add(this.LtodaySchedules);
            this.panel1.Location = new System.Drawing.Point(677, 242);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 471);
            this.panel1.TabIndex = 0;
            // 
            // lbTodaySchedules
            // 
            this.lbTodaySchedules.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbTodaySchedules.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTodaySchedules.FormattingEnabled = true;
            this.lbTodaySchedules.HorizontalScrollbar = true;
            this.lbTodaySchedules.ItemHeight = 20;
            this.lbTodaySchedules.Location = new System.Drawing.Point(0, 40);
            this.lbTodaySchedules.Margin = new System.Windows.Forms.Padding(4);
            this.lbTodaySchedules.Name = "lbTodaySchedules";
            this.lbTodaySchedules.Size = new System.Drawing.Size(387, 164);
            this.lbTodaySchedules.TabIndex = 4;
            this.lbTodaySchedules.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbTodaySchedules_DrawItem);
            this.lbTodaySchedules.SelectedIndexChanged += new System.EventHandler(this.lbTodaySchedules_SelectedIndexChanged);
            this.lbTodaySchedules.MouseLeave += new System.EventHandler(this.lbTodaySchedules_MouseLeave);
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
            this.tlpButton.Location = new System.Drawing.Point(0, 332);
            this.tlpButton.Margin = new System.Windows.Forms.Padding(4);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 2;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpButton.Size = new System.Drawing.Size(389, 139);
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
            this.btnDelete.Location = new System.Drawing.Point(262, 73);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 62);
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
            this.btnModify.Location = new System.Drawing.Point(133, 73);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(121, 62);
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
            this.btnQueryAllSchedules.Location = new System.Drawing.Point(4, 0);
            this.btnQueryAllSchedules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnQueryAllSchedules.Name = "btnQueryAllSchedules";
            this.btnQueryAllSchedules.Size = new System.Drawing.Size(381, 69);
            this.btnQueryAllSchedules.TabIndex = 3;
            this.btnQueryAllSchedules.Text = "查看所有日程";
            this.btnQueryAllSchedules.UseVisualStyleBackColor = false;
            this.btnQueryAllSchedules.Click += new System.EventHandler(this.btnQueryAllSchedules_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(4, 73);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 62);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加日程";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // LtodaySchedules
            // 
            this.LtodaySchedules.Dock = System.Windows.Forms.DockStyle.Top;
            this.LtodaySchedules.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LtodaySchedules.ForeColor = System.Drawing.Color.Black;
            this.LtodaySchedules.Location = new System.Drawing.Point(0, 0);
            this.LtodaySchedules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LtodaySchedules.Name = "LtodaySchedules";
            this.LtodaySchedules.Size = new System.Drawing.Size(389, 36);
            this.LtodaySchedules.TabIndex = 1;
            this.LtodaySchedules.Text = "今日日程";
            this.LtodaySchedules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMinimum
            // 
            this.buttonMinimum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimum.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonMinimum.Location = new System.Drawing.Point(929, 11);
            this.buttonMinimum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMinimum.Name = "buttonMinimum";
            this.buttonMinimum.Size = new System.Drawing.Size(123, 34);
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
            this.panelMonth1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMonth1.Name = "panelMonth1";
            this.panelMonth1.Size = new System.Drawing.Size(671, 852);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 24);
            this.toolStripMenuItem1.Text = "关闭";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // remindTip1
            // 
            this.remindTip1.IsBalloon = true;
            this.remindTip1.OwnerDraw = true;
            // 
            // lbWeather
            // 
            this.lbWeather.AutoSize = true;
            this.lbWeather.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbWeather.Location = new System.Drawing.Point(639, 18);
            this.lbWeather.Name = "lbWeather";
            this.lbWeather.Size = new System.Drawing.Size(49, 20);
            this.lbWeather.TabIndex = 3;
            this.lbWeather.Text = "天气";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 852);
            this.Controls.Add(this.lbWeather);
            this.Controls.Add(this.buttonMinimum);
            this.Controls.Add(this.panelMonth1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Don\'t Forgrt(万年历记事软件)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.tlpButton.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LtodaySchedules;
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
        private System.Windows.Forms.Label lbWeather;
        private System.Windows.Forms.ListBox lbTodaySchedules;
    }
}

