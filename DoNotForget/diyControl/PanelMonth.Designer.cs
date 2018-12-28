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
            this.Today = new System.Windows.Forms.LinkLabel();
            this.Rightbtn = new System.Windows.Forms.Button();
            this.Leftbtn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panelWeek = new System.Windows.Forms.Panel();
            this.labelSaturday = new System.Windows.Forms.Label();
            this.labelFriday = new System.Windows.Forms.Label();
            this.labelThursday = new System.Windows.Forms.Label();
            this.labelWednesday = new System.Windows.Forms.Label();
            this.labelTuesday = new System.Windows.Forms.Label();
            this.labelMonday = new System.Windows.Forms.Label();
            this.labelSunday = new System.Windows.Forms.Label();
            this.panelWall = new System.Windows.Forms.Panel();
            this.panelSearch.SuspendLayout();
            this.panelWeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.Today);
            this.panelSearch.Controls.Add(this.Rightbtn);
            this.panelSearch.Controls.Add(this.Leftbtn);
            this.panelSearch.Controls.Add(this.dateTimePicker);
            this.panelSearch.Location = new System.Drawing.Point(0, 4);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(665, 58);
            this.panelSearch.TabIndex = 0;
            // 
            // Today
            // 
            this.Today.Cursor = System.Windows.Forms.Cursors.Default;
            this.Today.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Today.LinkColor = System.Drawing.Color.Black;
            this.Today.Location = new System.Drawing.Point(386, 16);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(128, 31);
            this.Today.TabIndex = 3;
            this.Today.TabStop = true;
            this.Today.Text = "Today";
            this.Today.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Today.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Today_LinkClicked);
            // 
            // Rightbtn
            // 
            this.Rightbtn.BackColor = System.Drawing.Color.White;
            this.Rightbtn.FlatAppearance.BorderSize = 0;
            this.Rightbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rightbtn.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Rightbtn.Location = new System.Drawing.Point(520, 16);
            this.Rightbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rightbtn.Name = "Rightbtn";
            this.Rightbtn.Size = new System.Drawing.Size(100, 30);
            this.Rightbtn.TabIndex = 2;
            this.Rightbtn.Text = "-->";
            this.Rightbtn.UseVisualStyleBackColor = false;
            this.Rightbtn.Click += new System.EventHandler(this.Rightbtn_Click);
            // 
            // Leftbtn
            // 
            this.Leftbtn.BackColor = System.Drawing.Color.White;
            this.Leftbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Leftbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Leftbtn.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Leftbtn.Location = new System.Drawing.Point(280, 16);
            this.Leftbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Leftbtn.Name = "Leftbtn";
            this.Leftbtn.Size = new System.Drawing.Size(100, 30);
            this.Leftbtn.TabIndex = 1;
            this.Leftbtn.Text = "<--";
            this.Leftbtn.UseVisualStyleBackColor = false;
            this.Leftbtn.Click += new System.EventHandler(this.Leftbtn_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker.Location = new System.Drawing.Point(16, 16);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
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
            this.panelWeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelWeek.Name = "panelWeek";
            this.panelWeek.Size = new System.Drawing.Size(665, 38);
            this.panelWeek.TabIndex = 1;
            // 
            // labelSaturday
            // 
            this.labelSaturday.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaturday.Location = new System.Drawing.Point(557, 4);
            this.labelSaturday.Name = "labelSaturday";
            this.labelSaturday.Size = new System.Drawing.Size(86, 31);
            this.labelSaturday.TabIndex = 6;
            this.labelSaturday.Text = "Sat";
            this.labelSaturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFriday
            // 
            this.labelFriday.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriday.Location = new System.Drawing.Point(465, 4);
            this.labelFriday.Name = "labelFriday";
            this.labelFriday.Size = new System.Drawing.Size(86, 31);
            this.labelFriday.TabIndex = 5;
            this.labelFriday.Text = "Fri";
            this.labelFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThursday
            // 
            this.labelThursday.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThursday.Location = new System.Drawing.Point(372, 4);
            this.labelThursday.Name = "labelThursday";
            this.labelThursday.Size = new System.Drawing.Size(87, 31);
            this.labelThursday.TabIndex = 4;
            this.labelThursday.Text = "Thu";
            this.labelThursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWednesday
            // 
            this.labelWednesday.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWednesday.Location = new System.Drawing.Point(279, 4);
            this.labelWednesday.Name = "labelWednesday";
            this.labelWednesday.Size = new System.Drawing.Size(87, 31);
            this.labelWednesday.TabIndex = 3;
            this.labelWednesday.Text = "Wed";
            this.labelWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTuesday
            // 
            this.labelTuesday.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTuesday.Location = new System.Drawing.Point(187, 4);
            this.labelTuesday.Name = "labelTuesday";
            this.labelTuesday.Size = new System.Drawing.Size(86, 31);
            this.labelTuesday.TabIndex = 2;
            this.labelTuesday.Text = "Tue";
            this.labelTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMonday
            // 
            this.labelMonday.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonday.Location = new System.Drawing.Point(93, 4);
            this.labelMonday.Name = "labelMonday";
            this.labelMonday.Size = new System.Drawing.Size(88, 31);
            this.labelMonday.TabIndex = 1;
            this.labelMonday.Text = "Mon";
            this.labelMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSunday
            // 
            this.labelSunday.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSunday.Location = new System.Drawing.Point(0, 4);
            this.labelSunday.Name = "labelSunday";
            this.labelSunday.Size = new System.Drawing.Size(87, 31);
            this.labelSunday.TabIndex = 0;
            this.labelSunday.Text = "Sun";
            this.labelSunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWall
            // 
            this.panelWall.Location = new System.Drawing.Point(0, 112);
            this.panelWall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelWall.Name = "panelWall";
            this.panelWall.Size = new System.Drawing.Size(665, 696);
            this.panelWall.TabIndex = 2;
            // 
            // PanelMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelWall);
            this.Controls.Add(this.panelWeek);
            this.Controls.Add(this.panelSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PanelMonth";
            this.Size = new System.Drawing.Size(669, 820);
            this.panelSearch.ResumeLayout(false);
            this.panelWeek.ResumeLayout(false);
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
        private System.Windows.Forms.LinkLabel Today;
        private System.Windows.Forms.Button Rightbtn;
        private System.Windows.Forms.Button Leftbtn;
    }
}
