namespace StrategyPattern
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
            this.danjia = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.shuliang = new System.Windows.Forms.Label();
            this.textAmo = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.totalTxt = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.zhekou = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // danjia
            // 
            this.danjia.AutoSize = true;
            this.danjia.Location = new System.Drawing.Point(39, 43);
            this.danjia.Name = "danjia";
            this.danjia.Size = new System.Drawing.Size(41, 12);
            this.danjia.TabIndex = 0;
            this.danjia.Text = "单价：";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(86, 40);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(183, 21);
            this.textPrice.TabIndex = 1;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(321, 43);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "确认";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(321, 73);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "重置";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // shuliang
            // 
            this.shuliang.AutoSize = true;
            this.shuliang.Location = new System.Drawing.Point(39, 84);
            this.shuliang.Name = "shuliang";
            this.shuliang.Size = new System.Drawing.Size(41, 12);
            this.shuliang.TabIndex = 4;
            this.shuliang.Text = "数量：";
            // 
            // textAmo
            // 
            this.textAmo.Location = new System.Drawing.Point(86, 84);
            this.textAmo.Name = "textAmo";
            this.textAmo.Size = new System.Drawing.Size(183, 21);
            this.textAmo.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(41, 149);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 184);
            this.listBox1.TabIndex = 6;
            // 
            // totalTxt
            // 
            this.totalTxt.AutoSize = true;
            this.totalTxt.Location = new System.Drawing.Point(41, 368);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(41, 12);
            this.totalTxt.TabIndex = 7;
            this.totalTxt.Text = "总计：";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(131, 368);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(151, 53);
            this.total.TabIndex = 8;
            // 
            // zhekou
            // 
            this.zhekou.AutoSize = true;
            this.zhekou.Location = new System.Drawing.Point(41, 116);
            this.zhekou.Name = "zhekou";
            this.zhekou.Size = new System.Drawing.Size(41, 12);
            this.zhekou.TabIndex = 9;
            this.zhekou.Text = "折扣：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "正常收费",
            "满300减100",
            "8折"});
            this.comboBox1.Location = new System.Drawing.Point(86, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 20);
            this.comboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.zhekou);
            this.Controls.Add(this.total);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textAmo);
            this.Controls.Add(this.shuliang);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.danjia);
            this.Name = "Form1";
            this.Text = "超市收款计算";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label danjia;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label shuliang;
        private System.Windows.Forms.TextBox textAmo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label totalTxt;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label zhekou;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

