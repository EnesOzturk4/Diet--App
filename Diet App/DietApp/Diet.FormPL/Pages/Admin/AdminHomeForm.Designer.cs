namespace Diet.FormPL.Pages.Admin
{
    partial class AdminHomeForm
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            menuStrip1 = new MenuStrip();
            yourInformationToolStripMenuItem = new ToolStripMenuItem();
            userInformationToolStripMenuItem = new ToolStripMenuItem();
            categoryiesToolStripMenuItem = new ToolStripMenuItem();
            foodCategoryToolStripMenuItem = new ToolStripMenuItem();
            nutrientCategoryToolStripMenuItem = new ToolStripMenuItem();
            repastCategoryToolStripMenuItem = new ToolStripMenuItem();
            statusToolStripMenuItem = new ToolStripMenuItem();
            reportingToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { yourInformationToolStripMenuItem, userInformationToolStripMenuItem, categoryiesToolStripMenuItem, statusToolStripMenuItem, reportingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(771, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // yourInformationToolStripMenuItem
            // 
            yourInformationToolStripMenuItem.Name = "yourInformationToolStripMenuItem";
            yourInformationToolStripMenuItem.Size = new Size(109, 20);
            yourInformationToolStripMenuItem.Text = "Your Information";
            yourInformationToolStripMenuItem.Click += yourInformationToolStripMenuItem_Click;
            // 
            // userInformationToolStripMenuItem
            // 
            userInformationToolStripMenuItem.Name = "userInformationToolStripMenuItem";
            userInformationToolStripMenuItem.Size = new Size(108, 20);
            userInformationToolStripMenuItem.Text = "User Information";
            userInformationToolStripMenuItem.Click += userInformationToolStripMenuItem_Click;
            // 
            // categoryiesToolStripMenuItem
            // 
            categoryiesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { foodCategoryToolStripMenuItem, nutrientCategoryToolStripMenuItem, repastCategoryToolStripMenuItem });
            categoryiesToolStripMenuItem.Name = "categoryiesToolStripMenuItem";
            categoryiesToolStripMenuItem.Size = new Size(81, 20);
            categoryiesToolStripMenuItem.Text = "Categoryies";
            // 
            // foodCategoryToolStripMenuItem
            // 
            foodCategoryToolStripMenuItem.Name = "foodCategoryToolStripMenuItem";
            foodCategoryToolStripMenuItem.Size = new Size(169, 22);
            foodCategoryToolStripMenuItem.Text = "Food Category";
            foodCategoryToolStripMenuItem.Click += foodCategoryToolStripMenuItem_Click;
            // 
            // nutrientCategoryToolStripMenuItem
            // 
            nutrientCategoryToolStripMenuItem.Name = "nutrientCategoryToolStripMenuItem";
            nutrientCategoryToolStripMenuItem.Size = new Size(169, 22);
            nutrientCategoryToolStripMenuItem.Text = "Nutrient Category";
            nutrientCategoryToolStripMenuItem.Click += nutrientCategoryToolStripMenuItem_Click;
            // 
            // repastCategoryToolStripMenuItem
            // 
            repastCategoryToolStripMenuItem.Name = "repastCategoryToolStripMenuItem";
            repastCategoryToolStripMenuItem.Size = new Size(169, 22);
            repastCategoryToolStripMenuItem.Text = "Repast Category";
            repastCategoryToolStripMenuItem.Click += repastCategoryToolStripMenuItem_Click;
            // 
            // statusToolStripMenuItem
            // 
            statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            statusToolStripMenuItem.Size = new Size(51, 20);
            statusToolStripMenuItem.Text = "Status";
            statusToolStripMenuItem.Click += statusToolStripMenuItem_Click;
            // 
            // reportingToolStripMenuItem
            // 
            reportingToolStripMenuItem.Name = "reportingToolStripMenuItem";
            reportingToolStripMenuItem.Size = new Size(71, 20);
            reportingToolStripMenuItem.Text = "Reporting";
            // 
            // AdminHomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(771, 493);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "AdminHomeForm";
            Text = "AdminHome";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem yourInformationToolStripMenuItem;
        private ToolStripMenuItem userInformationToolStripMenuItem;
        private ToolStripMenuItem categoryiesToolStripMenuItem;
        private ToolStripMenuItem foodCategoryToolStripMenuItem;
        private ToolStripMenuItem nutrientCategoryToolStripMenuItem;
        private ToolStripMenuItem repastCategoryToolStripMenuItem;
        private ToolStripMenuItem statusToolStripMenuItem;
        private ToolStripMenuItem reportingToolStripMenuItem;
    }
}