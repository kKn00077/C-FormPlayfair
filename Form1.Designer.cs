namespace InformationProtect
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.plainLabel = new System.Windows.Forms.Label();
            this.plain = new System.Windows.Forms.TextBox();
            this.keywordLabel = new System.Windows.Forms.Label();
            this.keywordtext = new System.Windows.Forms.TextBox();
            this.encryption = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cryptogram = new System.Windows.Forms.Label();
            this.cryptogramLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plainLabel
            // 
            this.plainLabel.AutoSize = true;
            this.plainLabel.Location = new System.Drawing.Point(10, 52);
            this.plainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plainLabel.Name = "plainLabel";
            this.plainLabel.Size = new System.Drawing.Size(86, 18);
            this.plainLabel.TabIndex = 0;
            this.plainLabel.Text = "평문 입력";
            // 
            // plain
            // 
            this.plain.Location = new System.Drawing.Point(13, 75);
            this.plain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plain.Name = "plain";
            this.plain.Size = new System.Drawing.Size(491, 28);
            this.plain.TabIndex = 1;
            // 
            // keywordLabel
            // 
            this.keywordLabel.AutoSize = true;
            this.keywordLabel.Location = new System.Drawing.Point(10, 142);
            this.keywordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.keywordLabel.Name = "keywordLabel";
            this.keywordLabel.Size = new System.Drawing.Size(146, 18);
            this.keywordLabel.TabIndex = 2;
            this.keywordLabel.Text = "키워드 단어 입력";
            // 
            // keywordtext
            // 
            this.keywordtext.Location = new System.Drawing.Point(13, 166);
            this.keywordtext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keywordtext.Name = "keywordtext";
            this.keywordtext.Size = new System.Drawing.Size(215, 28);
            this.keywordtext.TabIndex = 3;
            // 
            // encryption
            // 
            this.encryption.Location = new System.Drawing.Point(279, 153);
            this.encryption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.encryption.Name = "encryption";
            this.encryption.Size = new System.Drawing.Size(213, 56);
            this.encryption.TabIndex = 4;
            this.encryption.Text = "암호화 하기";
            this.encryption.UseVisualStyleBackColor = true;
            this.encryption.Click += new System.EventHandler(this.encryption_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cryptogram);
            this.groupBox1.Controls.Add(this.cryptogramLabel);
            this.groupBox1.Controls.Add(this.plain);
            this.groupBox1.Controls.Add(this.encryption);
            this.groupBox1.Controls.Add(this.plainLabel);
            this.groupBox1.Controls.Add(this.keywordtext);
            this.groupBox1.Controls.Add(this.keywordLabel);
            this.groupBox1.Location = new System.Drawing.Point(23, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(514, 428);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "암호화";
            // 
            // cryptogram
            // 
            this.cryptogram.AutoSize = true;
            this.cryptogram.Location = new System.Drawing.Point(10, 340);
            this.cryptogram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cryptogram.Name = "cryptogram";
            this.cryptogram.Size = new System.Drawing.Size(104, 18);
            this.cryptogram.TabIndex = 6;
            this.cryptogram.Text = "암호문 결과";
            // 
            // cryptogramLabel
            // 
            this.cryptogramLabel.AutoSize = true;
            this.cryptogramLabel.Location = new System.Drawing.Point(7, 302);
            this.cryptogramLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cryptogramLabel.Name = "cryptogramLabel";
            this.cryptogramLabel.Size = new System.Drawing.Size(62, 18);
            this.cryptogramLabel.TabIndex = 5;
            this.cryptogramLabel.Text = "암호문";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 478);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "암호화 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label plainLabel;
        private System.Windows.Forms.TextBox plain;
        private System.Windows.Forms.Label keywordLabel;
        private System.Windows.Forms.TextBox keywordtext;
        private System.Windows.Forms.Button encryption;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label cryptogram;
        private System.Windows.Forms.Label cryptogramLabel;
    }
}

