namespace DannyRydstromBrowser
{
    partial class Form1
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
            this.Browser1 = new System.Windows.Forms.WebBrowser();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.messBox = new System.Windows.Forms.TextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.newMess = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.stockBtn = new System.Windows.Forms.Button();
            this.stockPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stockSym = new System.Windows.Forms.TextBox();
            this.symLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.zipBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Browser1
            // 
            this.Browser1.AccessibleName = "Browser1";
            this.Browser1.Location = new System.Drawing.Point(0, 32);
            this.Browser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser1.Name = "Browser1";
            this.Browser1.Size = new System.Drawing.Size(433, 629);
            this.Browser1.TabIndex = 0;
            // 
            // txtUrl
            // 
            this.txtUrl.AccessibleName = "txtUrl";
            this.txtUrl.Location = new System.Drawing.Point(3, 5);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(399, 20);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "http://";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGo.Location = new System.Drawing.Point(401, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(32, 20);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Message";
            // 
            // messBox
            // 
            this.messBox.Location = new System.Drawing.Point(7, 21);
            this.messBox.Name = "messBox";
            this.messBox.Size = new System.Drawing.Size(246, 20);
            this.messBox.TabIndex = 1;
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(7, 47);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(75, 23);
            this.encryptBtn.TabIndex = 2;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // newMess
            // 
            this.newMess.Location = new System.Drawing.Point(7, 94);
            this.newMess.Name = "newMess";
            this.newMess.Size = new System.Drawing.Size(244, 20);
            this.newMess.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encrypted Message:";
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(7, 120);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(75, 23);
            this.decryptBtn.TabIndex = 5;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.decryptBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.newMess);
            this.panel1.Controls.Add(this.encryptBtn);
            this.panel1.Controls.Add(this.messBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(439, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 148);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.stockBtn);
            this.panel2.Controls.Add(this.stockPrice);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.stockSym);
            this.panel2.Controls.Add(this.symLabel);
            this.panel2.Location = new System.Drawing.Point(439, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 108);
            this.panel2.TabIndex = 4;
            // 
            // stockBtn
            // 
            this.stockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stockBtn.Location = new System.Drawing.Point(141, 5);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Size = new System.Drawing.Size(53, 20);
            this.stockBtn.TabIndex = 7;
            this.stockBtn.Text = "Check";
            this.stockBtn.UseVisualStyleBackColor = true;
            this.stockBtn.Click += new System.EventHandler(this.stockBtn_Click);
            // 
            // stockPrice
            // 
            this.stockPrice.AutoSize = true;
            this.stockPrice.Location = new System.Drawing.Point(47, 35);
            this.stockPrice.Name = "stockPrice";
            this.stockPrice.Size = new System.Drawing.Size(13, 13);
            this.stockPrice.TabIndex = 6;
            this.stockPrice.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // stockSym
            // 
            this.stockSym.Location = new System.Drawing.Point(83, 5);
            this.stockSym.Name = "stockSym";
            this.stockSym.Size = new System.Drawing.Size(66, 20);
            this.stockSym.TabIndex = 1;
            // 
            // symLabel
            // 
            this.symLabel.AutoSize = true;
            this.symLabel.Location = new System.Drawing.Point(7, 9);
            this.symLabel.Name = "symLabel";
            this.symLabel.Size = new System.Drawing.Size(75, 13);
            this.symLabel.TabIndex = 0;
            this.symLabel.Text = "Stock Symbol:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.zipBtn);
            this.panel3.Controls.Add(this.zipBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(439, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 108);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Location = new System.Drawing.Point(439, 415);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 108);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Location = new System.Drawing.Point(439, 529);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(261, 108);
            this.panel5.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ZIP Code:";
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(71, 8);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(100, 20);
            this.zipBox.TabIndex = 1;
            // 
            // zipBtn
            // 
            this.zipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zipBtn.Location = new System.Drawing.Point(167, 8);
            this.zipBtn.Name = "zipBtn";
            this.zipBtn.Size = new System.Drawing.Size(53, 20);
            this.zipBtn.TabIndex = 8;
            this.zipBtn.Text = "Check";
            this.zipBtn.UseVisualStyleBackColor = true;
            this.zipBtn.Click += new System.EventHandler(this.zipBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 661);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.Browser1);
            this.Name = "Form1";
            this.Text = "Danny Rydstrom\'s Browser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser Browser1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox messBox;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.TextBox newMess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label stockPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stockSym;
        private System.Windows.Forms.Label symLabel;
        private System.Windows.Forms.Button stockBtn;
        private System.Windows.Forms.Button zipBtn;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.Label label4;
    }
}

