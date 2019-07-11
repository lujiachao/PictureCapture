namespace PictureCapture
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelWebUrl = new System.Windows.Forms.Label();
            this.txtWebText = new System.Windows.Forms.TextBox();
            this.labelWebCode = new System.Windows.Forms.Label();
            this.comboBoxEdit1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPictureNum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartPage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndPage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 565);
            this.textBox1.TabIndex = 0;
            // 
            // labelWebUrl
            // 
            this.labelWebUrl.AutoSize = true;
            this.labelWebUrl.Location = new System.Drawing.Point(320, 31);
            this.labelWebUrl.Name = "labelWebUrl";
            this.labelWebUrl.Size = new System.Drawing.Size(53, 12);
            this.labelWebUrl.TabIndex = 1;
            this.labelWebUrl.Text = "网站url:";
            // 
            // txtWebText
            // 
            this.txtWebText.Location = new System.Drawing.Point(379, 25);
            this.txtWebText.Name = "txtWebText";
            this.txtWebText.Size = new System.Drawing.Size(227, 21);
            this.txtWebText.TabIndex = 2;
            // 
            // labelWebCode
            // 
            this.labelWebCode.AutoSize = true;
            this.labelWebCode.Location = new System.Drawing.Point(320, 77);
            this.labelWebCode.Name = "labelWebCode";
            this.labelWebCode.Size = new System.Drawing.Size(59, 12);
            this.labelWebCode.TabIndex = 1;
            this.labelWebCode.Text = "网站编码:";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.FormattingEnabled = true;
            this.comboBoxEdit1.Location = new System.Drawing.Point(379, 74);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Size = new System.Drawing.Size(227, 20);
            this.comboBoxEdit1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "抓取图片";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(487, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "下载图片";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnPictureNum
            // 
            this.btnPictureNum.Location = new System.Drawing.Point(406, 169);
            this.btnPictureNum.Name = "btnPictureNum";
            this.btnPictureNum.Size = new System.Drawing.Size(122, 23);
            this.btnPictureNum.TabIndex = 4;
            this.btnPictureNum.Text = "获取图片数量";
            this.btnPictureNum.UseVisualStyleBackColor = true;
            this.btnPictureNum.Click += new System.EventHandler(this.BtnPictureNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "起始页码：";
            // 
            // txtStartPage
            // 
            this.txtStartPage.Location = new System.Drawing.Point(379, 118);
            this.txtStartPage.Name = "txtStartPage";
            this.txtStartPage.Size = new System.Drawing.Size(74, 21);
            this.txtStartPage.TabIndex = 7;
            this.txtStartPage.Leave += new System.EventHandler(this.TxtStartPage_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "结束页码:";
            // 
            // txtEndPage
            // 
            this.txtEndPage.Location = new System.Drawing.Point(532, 118);
            this.txtEndPage.Name = "txtEndPage";
            this.txtEndPage.Size = new System.Drawing.Size(74, 21);
            this.txtEndPage.TabIndex = 7;
            this.txtEndPage.Leave += new System.EventHandler(this.TxtEndPage_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 589);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStartPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPictureNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.txtWebText);
            this.Controls.Add(this.labelWebCode);
            this.Controls.Add(this.labelWebUrl);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelWebUrl;
        private System.Windows.Forms.TextBox txtWebText;
        private System.Windows.Forms.Label labelWebCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPictureNum;
        private System.Windows.Forms.ComboBox comboBoxEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndPage;
        private System.Windows.Forms.Label label3;
    }
}

