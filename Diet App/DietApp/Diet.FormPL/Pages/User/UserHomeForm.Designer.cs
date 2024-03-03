namespace Diet.FormPL.Pages.User
{
    partial class UserHomeForm
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
            menuStrip1 = new MenuStrip();
            userInformationToolStripMenuItem = new ToolStripMenuItem();
            statusUserToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { userInformationToolStripMenuItem, statusUserToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // userInformationToolStripMenuItem
            // 
            userInformationToolStripMenuItem.Name = "userInformationToolStripMenuItem";
            userInformationToolStripMenuItem.Size = new Size(108, 20);
            userInformationToolStripMenuItem.Text = "User Information";
            userInformationToolStripMenuItem.Click += userInformationToolStripMenuItem_Click;
            // 
            // statusUserToolStripMenuItem
            // 
            statusUserToolStripMenuItem.Name = "statusUserToolStripMenuItem";
            statusUserToolStripMenuItem.Size = new Size(77, 20);
            statusUserToolStripMenuItem.Text = "Status User";
            statusUserToolStripMenuItem.Click += statusUserToolStripMenuItem_Click;
            // 
            // UserHomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserHomeForm";
            Text = "UserHome";
            Load += UserHomeForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem userInformationToolStripMenuItem;
        private ToolStripMenuItem statusUserToolStripMenuItem;
    }
}