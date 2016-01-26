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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.newMess = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.messBox = new System.Windows.Forms.TextBox();
            this.Browser1 = new System.Windows.Forms.WebBrowser();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.zipBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.coBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.AccessibleName = "txtUrl";
            this.txtUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUrl.Location = new System.Drawing.Point(0, 0);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(1090, 20);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "http://www.google.com";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGo.Location = new System.Drawing.Point(1090, 0);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(32, 21);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Message";
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(8, 46);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(75, 23);
            this.encryptBtn.TabIndex = 2;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // newMess
            // 
            this.newMess.Location = new System.Drawing.Point(357, 20);
            this.newMess.Name = "newMess";
            this.newMess.Size = new System.Drawing.Size(328, 20);
            this.newMess.TabIndex = 3;
            this.newMess.Text = "a8eY1NIvx0BmzJFEMLELAg==";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(354, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encrypted Message:";
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(357, 46);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(75, 23);
            this.decryptBtn.TabIndex = 5;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.decryptBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.newMess);
            this.panel1.Controls.Add(this.encryptBtn);
            this.panel1.Controls.Add(this.messBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 589);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 72);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // messBox
            // 
            this.messBox.Location = new System.Drawing.Point(8, 20);
            this.messBox.Name = "messBox";
            this.messBox.Size = new System.Drawing.Size(328, 20);
            this.messBox.TabIndex = 1;
            // 
            // Browser1
            // 
            this.Browser1.AccessibleName = "Browser1";
            this.Browser1.Location = new System.Drawing.Point(0, 23);
            this.Browser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser1.Name = "Browser1";
            this.Browser1.Size = new System.Drawing.Size(1119, 541);
            this.Browser1.TabIndex = 0;
            this.Browser1.Url = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            this.Browser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Browser1_DocumentCompleted);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuPanel.Controls.Add(this.txtUrl);
            this.menuPanel.Controls.Add(this.btnGo);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1122, 21);
            this.menuPanel.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ZIP Code:";
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(67, 3);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(218, 20);
            this.zipBox.TabIndex = 1;
            // 
            // zipBtn
            // 
            this.zipBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.zipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zipBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zipBtn.Location = new System.Drawing.Point(284, 3);
            this.zipBtn.Name = "zipBtn";
            this.zipBtn.Size = new System.Drawing.Size(53, 20);
            this.zipBtn.TabIndex = 8;
            this.zipBtn.Text = "Check";
            this.zipBtn.UseVisualStyleBackColor = false;
            this.zipBtn.Click += new System.EventHandler(this.zipBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(355, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lat/Long:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // coBox
            // 
            this.coBox.Location = new System.Drawing.Point(416, 3);
            this.coBox.Name = "coBox";
            this.coBox.ReadOnly = true;
            this.coBox.Size = new System.Drawing.Size(270, 20);
            this.coBox.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel3.Controls.Add(this.coBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.zipBtn);
            this.panel3.Controls.Add(this.zipBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 561);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1122, 28);
            this.panel3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 661);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Browser1);
            this.Name = "Form1";
            this.Text = "Danny Rydstrom\'s Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.TextBox newMess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox messBox;
        private System.Windows.Forms.WebBrowser Browser1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.Button zipBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox coBox;
        private System.Windows.Forms.Panel panel3;
    }
}

