namespace Interface
{
    partial class AddScheduleForm
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
            this.rtbDetails = new System.Windows.Forms.RichTextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbOnce = new System.Windows.Forms.RadioButton();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.LSetRemindTime = new System.Windows.Forms.Label();
            this.gbSetRemindCycle = new System.Windows.Forms.GroupBox();
            this.LShowNowTime = new System.Windows.Forms.Label();
            this.dtpSetRemindTime = new System.Windows.Forms.DateTimePicker();
            this.gbSetRemindCycle.SuspendLayout();
            this.SuspendLayout();
            // 
            // LNowTime
            // 
            this.LNowTime.AutoSize = true;
            this.LNowTime.Location = new System.Drawing.Point(177, 35);
            this.LNowTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNowTime.Name = "LNowTime";
            this.LNowTime.Size = new System.Drawing.Size(112, 15);
            this.LNowTime.TabIndex = 0;
            this.LNowTime.Text = "当前日期和时间";
            // 
            // rtbDetails
            // 
            this.rtbDetails.Location = new System.Drawing.Point(133, 84);
            this.rtbDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbDetails.Name = "rtbDetails";
            this.rtbDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbDetails.Size = new System.Drawing.Size(408, 210);
            this.rtbDetails.TabIndex = 2;
            this.rtbDetails.Text = "";
            // 
            // btnYes
            // 
            this.btnYes.ForeColor = System.Drawing.Color.Blue;
            this.btnYes.Location = new System.Drawing.Point(168, 532);
            this.btnYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 29);
            this.btnYes.TabIndex = 3;
            this.btnYes.Text = "确认";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(409, 532);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbOnce
            // 
            this.rbOnce.AutoSize = true;
            this.rbOnce.Checked = true;
            this.rbOnce.Location = new System.Drawing.Point(8, 40);
            this.rbOnce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbOnce.Name = "rbOnce";
            this.rbOnce.Size = new System.Drawing.Size(118, 19);
            this.rbOnce.TabIndex = 5;
            this.rbOnce.TabStop = true;
            this.rbOnce.Text = "定时提醒一次";
            this.rbOnce.UseVisualStyleBackColor = true;
            this.rbOnce.CheckedChanged += new System.EventHandler(this.rbOnce_CheckedChanged);
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Location = new System.Drawing.Point(167, 40);
            this.rbDaily.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(88, 19);
            this.rbDaily.TabIndex = 6;
            this.rbDaily.Text = "每日提醒";
            this.rbDaily.UseVisualStyleBackColor = true;
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Location = new System.Drawing.Point(307, 40);
            this.rbWeekly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(88, 19);
            this.rbWeekly.TabIndex = 7;
            this.rbWeekly.Text = "每周提醒";
            this.rbWeekly.UseVisualStyleBackColor = true;
            // 
            // LSetRemindTime
            // 
            this.LSetRemindTime.AutoSize = true;
            this.LSetRemindTime.Location = new System.Drawing.Point(131, 416);
            this.LSetRemindTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LSetRemindTime.Name = "LSetRemindTime";
            this.LSetRemindTime.Size = new System.Drawing.Size(97, 15);
            this.LSetRemindTime.TabIndex = 8;
            this.LSetRemindTime.Text = "设置提醒时间";
            this.LSetRemindTime.Click += new System.EventHandler(this.LSetRemindTime_Click);
            // 
            // gbSetRemindCycle
            // 
            this.gbSetRemindCycle.Controls.Add(this.rbDaily);
            this.gbSetRemindCycle.Controls.Add(this.rbOnce);
            this.gbSetRemindCycle.Controls.Add(this.rbWeekly);
            this.gbSetRemindCycle.Location = new System.Drawing.Point(133, 316);
            this.gbSetRemindCycle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSetRemindCycle.Name = "gbSetRemindCycle";
            this.gbSetRemindCycle.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSetRemindCycle.Size = new System.Drawing.Size(409, 68);
            this.gbSetRemindCycle.TabIndex = 9;
            this.gbSetRemindCycle.TabStop = false;
            this.gbSetRemindCycle.Text = "设置提醒周期";
            // 
            // LShowNowTime
            // 
            this.LShowNowTime.AutoSize = true;
            this.LShowNowTime.Location = new System.Drawing.Point(327, 35);
            this.LShowNowTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LShowNowTime.Name = "LShowNowTime";
            this.LShowNowTime.Size = new System.Drawing.Size(172, 15);
            this.LShowNowTime.TabIndex = 10;
            this.LShowNowTime.Text = "此处显示当前日期和时间";
            // 
            // dtpSetRemindTime
            // 
            this.dtpSetRemindTime.CustomFormat = "     yyyy-MM-dd HH:mm:00";
            this.dtpSetRemindTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSetRemindTime.Location = new System.Drawing.Point(268, 409);
            this.dtpSetRemindTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpSetRemindTime.Name = "dtpSetRemindTime";
            this.dtpSetRemindTime.Size = new System.Drawing.Size(265, 25);
            this.dtpSetRemindTime.TabIndex = 11;
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 576);
            this.Controls.Add(this.dtpSetRemindTime);
            this.Controls.Add(this.LShowNowTime);
            this.Controls.Add(this.gbSetRemindCycle);
            this.Controls.Add(this.LSetRemindTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.rtbDetails);
            this.Controls.Add(this.LNowTime);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddScheduleForm";
            this.Text = "添加新日程";
            this.gbSetRemindCycle.ResumeLayout(false);
            this.gbSetRemindCycle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNowTime;
        private System.Windows.Forms.RichTextBox rtbDetails;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbOnce;
        private System.Windows.Forms.RadioButton rbDaily;
        private System.Windows.Forms.RadioButton rbWeekly;
        private System.Windows.Forms.Label LSetRemindTime;
        private System.Windows.Forms.GroupBox gbSetRemindCycle;
        private System.Windows.Forms.Label LShowNowTime;
        private System.Windows.Forms.DateTimePicker dtpSetRemindTime;
    }
}