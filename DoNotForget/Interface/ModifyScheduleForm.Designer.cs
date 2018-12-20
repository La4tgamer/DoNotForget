namespace Interface
{
    partial class ModifyScheduleForm
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
            this.LNowTime = new System.Windows.Forms.Label();
            this.LShowNowTime = new System.Windows.Forms.Label();
            this.lbAllSchedules = new System.Windows.Forms.ListBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LAllSchedules = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbModifyRemindTime = new System.Windows.Forms.GroupBox();
            this.dtpModifyRemindTime = new System.Windows.Forms.DateTimePicker();
            this.gbModifyDetails = new System.Windows.Forms.GroupBox();
            this.rtbModifyDetails = new System.Windows.Forms.RichTextBox();
            this.gbModifyCycle = new System.Windows.Forms.GroupBox();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.rbOnce = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbModifyRemindTime.SuspendLayout();
            this.gbModifyDetails.SuspendLayout();
            this.gbModifyCycle.SuspendLayout();
            this.SuspendLayout();
            // 
            // LNowTime
            // 
            this.LNowTime.AutoSize = true;
            this.LNowTime.Location = new System.Drawing.Point(29, 11);
            this.LNowTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNowTime.Name = "LNowTime";
            this.LNowTime.Size = new System.Drawing.Size(112, 15);
            this.LNowTime.TabIndex = 0;
            this.LNowTime.Text = "当前日期和时间";
            // 
            // LShowNowTime
            // 
            this.LShowNowTime.AutoSize = true;
            this.LShowNowTime.Location = new System.Drawing.Point(188, 11);
            this.LShowNowTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LShowNowTime.Name = "LShowNowTime";
            this.LShowNowTime.Size = new System.Drawing.Size(142, 15);
            this.LShowNowTime.TabIndex = 1;
            this.LShowNowTime.Text = "显示当前日期和时间";
            // 
            // lbAllSchedules
            // 
            this.lbAllSchedules.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbAllSchedules.FormattingEnabled = true;
            this.lbAllSchedules.HorizontalScrollbar = true;
            this.lbAllSchedules.ItemHeight = 15;
            this.lbAllSchedules.Location = new System.Drawing.Point(0, 92);
            this.lbAllSchedules.Margin = new System.Windows.Forms.Padding(4);
            this.lbAllSchedules.Name = "lbAllSchedules";
            this.lbAllSchedules.Size = new System.Drawing.Size(391, 484);
            this.lbAllSchedules.TabIndex = 2;
            this.lbAllSchedules.SelectedIndexChanged += new System.EventHandler(this.lbAllSchedules_SelectedIndexChanged);
            // 
            // btnModify
            // 
            this.btnModify.ForeColor = System.Drawing.Color.Red;
            this.btnModify.Location = new System.Drawing.Point(193, 532);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(100, 29);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "确认修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LAllSchedules);
            this.panel1.Controls.Add(this.lbAllSchedules);
            this.panel1.Controls.Add(this.LNowTime);
            this.panel1.Controls.Add(this.LShowNowTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 576);
            this.panel1.TabIndex = 5;
            // 
            // LAllSchedules
            // 
            this.LAllSchedules.AutoSize = true;
            this.LAllSchedules.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LAllSchedules.ForeColor = System.Drawing.Color.Red;
            this.LAllSchedules.Location = new System.Drawing.Point(123, 55);
            this.LAllSchedules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAllSchedules.Name = "LAllSchedules";
            this.LAllSchedules.Size = new System.Drawing.Size(116, 25);
            this.LAllSchedules.TabIndex = 3;
            this.LAllSchedules.Text = "所有日程";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbModifyRemindTime);
            this.panel2.Controls.Add(this.gbModifyDetails);
            this.panel2.Controls.Add(this.gbModifyCycle);
            this.panel2.Controls.Add(this.btnModify);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(391, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 576);
            this.panel2.TabIndex = 6;
            // 
            // gbModifyRemindTime
            // 
            this.gbModifyRemindTime.Controls.Add(this.dtpModifyRemindTime);
            this.gbModifyRemindTime.Location = new System.Drawing.Point(43, 352);
            this.gbModifyRemindTime.Margin = new System.Windows.Forms.Padding(4);
            this.gbModifyRemindTime.Name = "gbModifyRemindTime";
            this.gbModifyRemindTime.Padding = new System.Windows.Forms.Padding(4);
            this.gbModifyRemindTime.Size = new System.Drawing.Size(433, 98);
            this.gbModifyRemindTime.TabIndex = 7;
            this.gbModifyRemindTime.TabStop = false;
            this.gbModifyRemindTime.Text = "修改提醒时间";
            // 
            // dtpModifyRemindTime
            // 
            this.dtpModifyRemindTime.CustomFormat = "         yyyy-MM-dd HH:mm:ss    ";
            this.dtpModifyRemindTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModifyRemindTime.Location = new System.Drawing.Point(47, 46);
            this.dtpModifyRemindTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpModifyRemindTime.Name = "dtpModifyRemindTime";
            this.dtpModifyRemindTime.Size = new System.Drawing.Size(343, 25);
            this.dtpModifyRemindTime.TabIndex = 0;
            // 
            // gbModifyDetails
            // 
            this.gbModifyDetails.Controls.Add(this.rtbModifyDetails);
            this.gbModifyDetails.Location = new System.Drawing.Point(43, 131);
            this.gbModifyDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gbModifyDetails.Name = "gbModifyDetails";
            this.gbModifyDetails.Padding = new System.Windows.Forms.Padding(4);
            this.gbModifyDetails.Size = new System.Drawing.Size(433, 194);
            this.gbModifyDetails.TabIndex = 6;
            this.gbModifyDetails.TabStop = false;
            this.gbModifyDetails.Text = "修改提醒内容";
            // 
            // rtbModifyDetails
            // 
            this.rtbModifyDetails.Location = new System.Drawing.Point(15, 19);
            this.rtbModifyDetails.Margin = new System.Windows.Forms.Padding(4);
            this.rtbModifyDetails.Name = "rtbModifyDetails";
            this.rtbModifyDetails.Size = new System.Drawing.Size(409, 153);
            this.rtbModifyDetails.TabIndex = 0;
            this.rtbModifyDetails.Text = "";
            // 
            // gbModifyCycle
            // 
            this.gbModifyCycle.Controls.Add(this.rbWeekly);
            this.gbModifyCycle.Controls.Add(this.rbDaily);
            this.gbModifyCycle.Controls.Add(this.rbOnce);
            this.gbModifyCycle.Location = new System.Drawing.Point(43, 15);
            this.gbModifyCycle.Margin = new System.Windows.Forms.Padding(4);
            this.gbModifyCycle.Name = "gbModifyCycle";
            this.gbModifyCycle.Padding = new System.Windows.Forms.Padding(4);
            this.gbModifyCycle.Size = new System.Drawing.Size(433, 80);
            this.gbModifyCycle.TabIndex = 5;
            this.gbModifyCycle.TabStop = false;
            this.gbModifyCycle.Text = "修改提醒周期";
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Location = new System.Drawing.Point(319, 40);
            this.rbWeekly.Margin = new System.Windows.Forms.Padding(4);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(88, 19);
            this.rbWeekly.TabIndex = 2;
            this.rbWeekly.TabStop = true;
            this.rbWeekly.Text = "每周提醒";
            this.rbWeekly.UseVisualStyleBackColor = true;
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Location = new System.Drawing.Point(177, 40);
            this.rbDaily.Margin = new System.Windows.Forms.Padding(4);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(88, 19);
            this.rbDaily.TabIndex = 1;
            this.rbDaily.TabStop = true;
            this.rbDaily.Text = "每日提醒";
            this.rbDaily.UseVisualStyleBackColor = true;
            // 
            // rbOnce
            // 
            this.rbOnce.AutoSize = true;
            this.rbOnce.Location = new System.Drawing.Point(8, 40);
            this.rbOnce.Margin = new System.Windows.Forms.Padding(4);
            this.rbOnce.Name = "rbOnce";
            this.rbOnce.Size = new System.Drawing.Size(118, 19);
            this.rbOnce.TabIndex = 0;
            this.rbOnce.TabStop = true;
            this.rbOnce.Text = "定时提醒一次";
            this.rbOnce.UseVisualStyleBackColor = true;
            // 
            // ModifyScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(912, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModifyScheduleForm";
            this.Text = "修改日程";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gbModifyRemindTime.ResumeLayout(false);
            this.gbModifyDetails.ResumeLayout(false);
            this.gbModifyCycle.ResumeLayout(false);
            this.gbModifyCycle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LNowTime;
        private System.Windows.Forms.Label LShowNowTime;
        private System.Windows.Forms.ListBox lbAllSchedules;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LAllSchedules;
        private System.Windows.Forms.GroupBox gbModifyCycle;
        private System.Windows.Forms.RadioButton rbOnce;
        private System.Windows.Forms.GroupBox gbModifyRemindTime;
        private System.Windows.Forms.DateTimePicker dtpModifyRemindTime;
        private System.Windows.Forms.GroupBox gbModifyDetails;
        private System.Windows.Forms.RichTextBox rtbModifyDetails;
        private System.Windows.Forms.RadioButton rbWeekly;
        private System.Windows.Forms.RadioButton rbDaily;
    }
}