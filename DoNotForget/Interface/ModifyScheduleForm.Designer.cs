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
            this.SuspendLayout();
            // 
            // LNowTime
            // 
            this.LNowTime.AutoSize = true;
            this.LNowTime.Location = new System.Drawing.Point(20, 9);
            this.LNowTime.Name = "LNowTime";
            this.LNowTime.Size = new System.Drawing.Size(89, 12);
            this.LNowTime.TabIndex = 0;
            this.LNowTime.Text = "当前日期和时间";
            // 
            // LShowNowTime
            // 
            this.LShowNowTime.AutoSize = true;
            this.LShowNowTime.Location = new System.Drawing.Point(115, 9);
            this.LShowNowTime.Name = "LShowNowTime";
            this.LShowNowTime.Size = new System.Drawing.Size(113, 12);
            this.LShowNowTime.TabIndex = 1;
            this.LShowNowTime.Text = "显示当前日期和时间";
            // 
            // lbAllSchedules
            // 
            this.lbAllSchedules.FormattingEnabled = true;
            this.lbAllSchedules.ItemHeight = 12;
            this.lbAllSchedules.Location = new System.Drawing.Point(12, 38);
            this.lbAllSchedules.Name = "lbAllSchedules";
            this.lbAllSchedules.Size = new System.Drawing.Size(230, 412);
            this.lbAllSchedules.TabIndex = 2;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(323, 415);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "确认修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // ModifyScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lbAllSchedules);
            this.Controls.Add(this.LShowNowTime);
            this.Controls.Add(this.LNowTime);
            this.Name = "ModifyScheduleForm";
            this.Text = "修改日程";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNowTime;
        private System.Windows.Forms.Label LShowNowTime;
        private System.Windows.Forms.ListBox lbAllSchedules;
        private System.Windows.Forms.Button btnModify;
    }
}