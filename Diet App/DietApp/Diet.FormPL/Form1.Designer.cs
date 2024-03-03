namespace Diet.FormPL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            EMailTxt = new TextBox();
            SifreTxt = new TextBox();
            GirisBtn = new Button();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // EMailTxt
            // 
            EMailTxt.BackColor = Color.White;
            EMailTxt.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 162);
            EMailTxt.Location = new Point(53, 122);
            EMailTxt.Name = "EMailTxt";
            EMailTxt.PlaceholderText = "Email";
            EMailTxt.Size = new Size(212, 29);
            EMailTxt.TabIndex = 2;
            // 
            // SifreTxt
            // 
            SifreTxt.BackColor = Color.White;
            SifreTxt.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 162);
            SifreTxt.Location = new Point(53, 192);
            SifreTxt.Name = "SifreTxt";
            SifreTxt.PasswordChar = '*';
            SifreTxt.PlaceholderText = "Password";
            SifreTxt.Size = new Size(212, 29);
            SifreTxt.TabIndex = 3;
            // 
            // GirisBtn
            // 
            GirisBtn.BackColor = Color.White;
            GirisBtn.Cursor = Cursors.Hand;
            GirisBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 162);
            GirisBtn.ForeColor = Color.MidnightBlue;
            GirisBtn.Location = new Point(53, 244);
            GirisBtn.Name = "GirisBtn";
            GirisBtn.Size = new Size(212, 37);
            GirisBtn.TabIndex = 4;
            GirisBtn.Text = "Login";
            GirisBtn.UseVisualStyleBackColor = false;
            GirisBtn.Click += GirisBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
            label4.ForeColor = Color.LavenderBlush;
            label4.Location = new Point(68, 296);
            label4.Name = "label4";
            label4.Size = new Size(187, 25);
            label4.TabIndex = 21;
            label4.Text = "Still Not a Member?";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(53, 341);
            button1.Name = "button1";
            button1.Size = new Size(212, 36);
            button1.TabIndex = 20;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += RegisterBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 22F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(176, 51);
            label3.Name = "label3";
            label3.Size = new Size(284, 34);
            label3.TabIndex = 19;
            label3.Text = "Personalize Your Diet";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(EMailTxt);
            panel1.Controls.Add(GirisBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(SifreTxt);
            panel1.Location = new Point(176, 193);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 448);
            panel1.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.LavenderBlush;
            label7.Location = new Point(84, 40);
            label7.Name = "label7";
            label7.Size = new Size(139, 26);
            label7.TabIndex = 25;
            label7.Text = "Log In Now!";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.LavenderBlush;
            label2.Location = new Point(53, 167);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 23;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(53, 97);
            label1.Name = "label1";
            label1.Size = new Size(50, 19);
            label1.TabIndex = 22;
            label1.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 22F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(141, 104);
            label6.Name = "label6";
            label6.Size = new Size(368, 35);
            label6.TabIndex = 24;
            label6.Text = "Achieve Your Dream Shape:";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(637, 703);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(label3);
            ForeColor = Color.Transparent;
            Name = "Form1";
            Text = "DietApp";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox EMailTxt;
        private TextBox SifreTxt;
        private Button GirisBtn;
        private Label label4;
        private Button button1;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
    }
}
