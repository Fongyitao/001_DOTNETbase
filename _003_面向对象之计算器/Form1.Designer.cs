namespace _003_面向对象之计算器
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJiSuan = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.cobCaoZuoFu = new System.Windows.Forms.ComboBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnJiSuan
            // 
            this.btnJiSuan.Location = new System.Drawing.Point(487, 58);
            this.btnJiSuan.Name = "btnJiSuan";
            this.btnJiSuan.Size = new System.Drawing.Size(75, 23);
            this.btnJiSuan.TabIndex = 0;
            this.btnJiSuan.Text = "=";
            this.btnJiSuan.UseVisualStyleBackColor = true;
            this.btnJiSuan.Click += new System.EventHandler(this.btnJiSuan_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(613, 66);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 15);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "label1";
            // 
            // cobCaoZuoFu
            // 
            this.cobCaoZuoFu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobCaoZuoFu.FormattingEnabled = true;
            this.cobCaoZuoFu.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cobCaoZuoFu.Location = new System.Drawing.Point(190, 58);
            this.cobCaoZuoFu.Name = "cobCaoZuoFu";
            this.cobCaoZuoFu.Size = new System.Drawing.Size(121, 23);
            this.cobCaoZuoFu.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(355, 56);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 25);
            this.txtNum2.TabIndex = 3;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(38, 56);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 25);
            this.txtNum1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 164);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.cobCaoZuoFu);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnJiSuan);
            this.Name = "Form1";
            this.Text = "四则运算";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJiSuan;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cobCaoZuoFu;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
    }
}

