namespace diyControl
{
    partial class PanelMonth
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panelWeek = new System.Windows.Forms.Panel();
            this.panelWall = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelSunday = new System.Windows.Forms.Label();
            this.labelMonday = new System.Windows.Forms.Label();
            this.labelTuesday = new System.Windows.Forms.Label();
            this.labelWednesday = new System.Windows.Forms.Label();
            this.labelThursday = new System.Windows.Forms.Label();
            this.labelFriday = new System.Windows.Forms.Label();
            this.labelSaturday = new System.Windows.Forms.Label();
            this.panelSearch.SuspendLayout();
            this.panelWeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.dateTimePicker);
            this.panelSearch.Location = new System.Drawing.Point(0, 4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(665, 58);
            this.panelSearch.TabIndex = 0;
            // 
            // panelWeek
            // 
            this.panelWeek.Controls.Add(this.labelSaturday);
            this.panelWeek.Controls.Add(this.labelFriday);
            this.panelWeek.Controls.Add(this.labelThursday);
            this.panelWeek.Controls.Add(this.labelWednesday);
            this.panelWeek.Controls.Add(this.labelTuesday);
            this.panelWeek.Controls.Add(this.labelMonday);
            this.panelWeek.Controls.Add(this.labelSunday);
            this.panelWeek.Location = new System.Drawing.Point(0, 69);
            this.panelWeek.Name = "panelWeek";
            this.panelWeek.Size = new System.Drawing.Size(665, 37);
            this.panelWeek.TabIndex = 1;
            // 
            // panelWall
            // 
            this.panelWall.Location = new System.Drawing.Point(0, 113);
            this.panelWall.Name = "panelWall";
            this.panelWall.Size = new System.Drawing.Size(665, 696);
            this.panelWall.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(16, 16);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // labelSunday
            // 
            this.labelSunday.AutoSize = true;
            this.labelSunday.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSunday.Location = new System.Drawing.Point(0, 4);
            this.labelSunday.Name = "labelSunday";
            this.labelSunday.Size = new System.Drawing.Size(90, 25);
            this.labelSunday.TabIndex = 0;
            this.labelSunday.Text = "星期日";
            // 
            // labelMonday
            // 
            this.labelMonday.AutoSize = true;
            this.labelMonday.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMonday.Location = new System.Drawing.Point(93, 4);
            this.labelMonday.Name = "labelMonday";
            this.labelMonday.Size = new System.Drawing.Size(90, 25);
            this.labelMonday.TabIndex = 1;
            this.labelMonday.Text = "星期一";
            // 
            // labelTuesday
            // 
            this.labelTuesday.AutoSize = true;
            this.labelTuesday.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTuesday.Location = new System.Drawing.Point(186, 4);
            this.labelTuesday.Name = "labelTuesday";
            this.labelTuesday.Size = new System.Drawing.Size(90, 25);
            this.labelTuesday.TabIndex = 2;
            this.labelTuesday.Text = "星期二";
            // 
            // labelWednesday
            // 
            this.labelWednesday.AutoSize = true;
            this.labelWednesday.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWednesday.Location = new System.Drawing.Point(279, 4);
            this.labelWednesday.Name = "labelWednesday";
            this.labelWednesday.Size = new System.Drawing.Size(90, 25);
            this.labelWednesday.TabIndex = 3;
            this.labelWednesday.Text = "星期三";
            // 
            // labelThursday
            // 
            this.labelThursday.AutoSize = true;
            this.labelThursday.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelThursday.Location = new System.Drawing.Point(372, 4);
            this.labelThursday.Name = "labelThursday";
            this.labelThursday.Size = new System.Drawing.Size(90, 25);
            this.labelThursday.TabIndex = 4;
            this.labelThursday.Text = "星期四";
            // 
            // labelFriday
            // 
            this.labelFriday.AutoSize = true;
            this.labelFriday.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFriday.Location = new System.Drawing.Point(465, 4);
            this.labelFriday.Name = "labelFriday";
            this.labelFriday.Size = new System.Drawing.Size(90, 25);
            this.labelFriday.TabIndex = 5;
            this.labelFriday.Text = "星期五";
            // 
            // labelSaturday
            // 
            this.labelSaturday.AutoSize = true;
            this.labelSaturday.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSaturday.Location = new System.Drawing.Point(558, 4);
            this.labelSaturday.Name = "labelSaturday";
            this.labelSaturday.Size = new System.Drawing.Size(90, 25);
            this.labelSaturday.TabIndex = 6;
            this.labelSaturday.Text = "星期六";
            // 
            // PanelMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelWall);
            this.Controls.Add(this.panelWeek);
            this.Controls.Add(this.panelSearch);
            this.Name = "PanelMonth";
            this.Size = new System.Drawing.Size(670, 820);
            this.panelSearch.ResumeLayout(false);
            this.panelWeek.ResumeLayout(false);
            this.panelWeek.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Panel panelWeek;
        private System.Windows.Forms.Label labelSaturday;
        private System.Windows.Forms.Label labelFriday;
        private System.Windows.Forms.Label labelThursday;
        private System.Windows.Forms.Label labelWednesday;
        private System.Windows.Forms.Label labelTuesday;
        private System.Windows.Forms.Label labelMonday;
        private System.Windows.Forms.Label labelSunday;
        private System.Windows.Forms.Panel panelWall;
    }
}
