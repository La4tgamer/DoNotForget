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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQueryAllSchedules = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.LtodaySchedules = new System.Windows.Forms.Label();
            this.clbTodaySchedules = new System.Windows.Forms.CheckedListBox();
            this.btnModify = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(599, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(62, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除日程";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnQueryAllSchedules
            // 
            this.btnQueryAllSchedules.Location = new System.Drawing.Point(57, 211);
            this.btnQueryAllSchedules.Name = "btnQueryAllSchedules";
            this.btnQueryAllSchedules.Size = new System.Drawing.Size(90, 23);
            this.btnQueryAllSchedules.TabIndex = 3;
            this.btnQueryAllSchedules.Text = "查看所有日程";
            this.btnQueryAllSchedules.UseVisualStyleBackColor = true;
            this.btnQueryAllSchedules.Click += new System.EventHandler(this.btnQueryAllSchedules_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(62, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加日程";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // LtodaySchedules
            // 
            this.LtodaySchedules.AutoSize = true;
            this.LtodaySchedules.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LtodaySchedules.ForeColor = System.Drawing.Color.Blue;
            this.LtodaySchedules.Location = new System.Drawing.Point(58, 9);
            this.LtodaySchedules.Name = "LtodaySchedules";
            this.LtodaySchedules.Size = new System.Drawing.Size(89, 19);
            this.LtodaySchedules.TabIndex = 1;
            this.LtodaySchedules.Text = "今日日程";
            // 
            // clbTodaySchedules
            // 
            this.clbTodaySchedules.FormattingEnabled = true;
            this.clbTodaySchedules.HorizontalScrollbar = true;
            this.clbTodaySchedules.Location = new System.Drawing.Point(0, 42);
            this.clbTodaySchedules.Name = "clbTodaySchedules";
            this.clbTodaySchedules.Size = new System.Drawing.Size(200, 132);
            this.clbTodaySchedules.TabIndex = 0;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(62, 359);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "修改日程";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Don\'t Forgrt(万年历记事软件)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

