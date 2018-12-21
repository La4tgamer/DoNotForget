namespace diyControl
{
    partial class PanelDay
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
            this.labelSolar = new System.Windows.Forms.Label();
            this.labelLunar = new System.Windows.Forms.Label();
            this.labelTerms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSolar
            // 
            this.labelSolar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSolar.AutoSize = true;
            this.labelSolar.Font = new System.Drawing.Font("Calibri", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelSolar.Location = new System.Drawing.Point(1, 0);
            this.labelSolar.Name = "labelSolar";
            this.labelSolar.Size = new System.Drawing.Size(55, 64);
            this.labelSolar.TabIndex = 0;
            this.labelSolar.Text = "1";
            this.labelSolar.Click += new System.EventHandler(this.labelSolar_Click);
            // 
            // labelLunar
            // 
            this.labelLunar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLunar.AutoSize = true;
            this.labelLunar.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLunar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelLunar.Location = new System.Drawing.Point(1, 57);
            this.labelLunar.Name = "labelLunar";
            this.labelLunar.Size = new System.Drawing.Size(58, 24);
            this.labelLunar.TabIndex = 1;
            this.labelLunar.Text = "初一";
            // 
            // labelTerms
            // 
            this.labelTerms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTerms.AutoSize = true;
            this.labelTerms.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTerms.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTerms.Location = new System.Drawing.Point(1, 81);
            this.labelTerms.Name = "labelTerms";
            this.labelTerms.Size = new System.Drawing.Size(58, 24);
            this.labelTerms.TabIndex = 2;
            this.labelTerms.Text = "立春";
            // 
            // PanelDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labelTerms);
            this.Controls.Add(this.labelLunar);
            this.Controls.Add(this.labelSolar);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "PanelDay";
            this.Size = new System.Drawing.Size(89, 116);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSolar;
        private System.Windows.Forms.Label labelLunar;
        private System.Windows.Forms.Label labelTerms;
    }
}
