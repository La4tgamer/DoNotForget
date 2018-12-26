namespace Interface
{
    partial class DeleteScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteScheduleForm));
            this.clbAllSchedules = new System.Windows.Forms.CheckedListBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnSelectNone = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbAllSchedules
            // 
            this.clbAllSchedules.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.clbAllSchedules.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clbAllSchedules.FormattingEnabled = true;
            this.clbAllSchedules.HorizontalExtent = 1000;
            this.clbAllSchedules.HorizontalScrollbar = true;
            this.clbAllSchedules.Location = new System.Drawing.Point(55, 0);
            this.clbAllSchedules.Name = "clbAllSchedules";
            this.clbAllSchedules.Size = new System.Drawing.Size(380, 319);
            this.clbAllSchedules.TabIndex = 0;
            this.clbAllSchedules.SelectedIndexChanged += new System.EventHandler(this.clbAllSchedules_SelectedIndexChanged);
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnYes.ForeColor = System.Drawing.Color.Red;
            this.btnYes.Location = new System.Drawing.Point(166, 411);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(158, 28);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "确认删除所选日程";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectNone.Location = new System.Drawing.Point(107, 360);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(92, 23);
            this.btnSelectNone.TabIndex = 3;
            this.btnSelectNone.Text = "取消全选";
            this.btnSelectNone.UseVisualStyleBackColor = true;
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectAll.Location = new System.Drawing.Point(309, 360);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 4;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // DeleteScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnSelectNone);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.clbAllSchedules);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteScheduleForm";
            this.Text = "删除日程";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbAllSchedules;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnSelectNone;
        private System.Windows.Forms.Button btnSelectAll;
    }
}