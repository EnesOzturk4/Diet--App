namespace Diet.FormPL.Pages.Admin
{
    partial class RePastForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RePastForm));
            updateRePast = new Button();
            addRePast = new Button();
            deleteRePast = new Button();
            dataGridViewRePast = new DataGridView();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            rePastTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRePast).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // updateRePast
            // 
            updateRePast.BackColor = Color.SteelBlue;
            updateRePast.Cursor = Cursors.Hand;
            updateRePast.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            updateRePast.ForeColor = Color.White;
            updateRePast.Location = new Point(529, 366);
            updateRePast.Name = "updateRePast";
            updateRePast.Size = new Size(109, 36);
            updateRePast.TabIndex = 16;
            updateRePast.Text = "Update";
            updateRePast.UseVisualStyleBackColor = false;
            updateRePast.Click += updateRePast_Click;
            // 
            // addRePast
            // 
            addRePast.BackColor = Color.LemonChiffon;
            addRePast.Cursor = Cursors.Hand;
            addRePast.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            addRePast.Location = new Point(31, 242);
            addRePast.Name = "addRePast";
            addRePast.Size = new Size(243, 36);
            addRePast.TabIndex = 15;
            addRePast.Text = "Add RePast Category";
            addRePast.UseVisualStyleBackColor = false;
            addRePast.Click += addRePast_Click;
            // 
            // deleteRePast
            // 
            deleteRePast.BackColor = Color.IndianRed;
            deleteRePast.Cursor = Cursors.Hand;
            deleteRePast.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            deleteRePast.ForeColor = Color.White;
            deleteRePast.Location = new Point(660, 366);
            deleteRePast.Name = "deleteRePast";
            deleteRePast.Size = new Size(109, 36);
            deleteRePast.TabIndex = 14;
            deleteRePast.Text = "Delete";
            deleteRePast.UseVisualStyleBackColor = false;
            deleteRePast.Click += deleteRePast_Click;
            // 
            // dataGridViewRePast
            // 
            dataGridViewRePast.BackgroundColor = Color.LemonChiffon;
            dataGridViewRePast.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRePast.GridColor = Color.White;
            dataGridViewRePast.Location = new Point(529, 49);
            dataGridViewRePast.Name = "dataGridViewRePast";
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dataGridViewRePast.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRePast.Size = new Size(240, 311);
            dataGridViewRePast.TabIndex = 13;
            dataGridViewRePast.CellClick += dataGridViewRePast_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Khaki;
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(31, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 95);
            panel2.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LemonChiffon;
            groupBox1.Controls.Add(rePastTxt);
            groupBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "RePast Name";
            // 
            // rePastTxt
            // 
            rePastTxt.Location = new Point(6, 40);
            rePastTxt.Name = "rePastTxt";
            rePastTxt.Size = new Size(226, 22);
            rePastTxt.TabIndex = 1;
            // 
            // RePastForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(updateRePast);
            Controls.Add(addRePast);
            Controls.Add(deleteRePast);
            Controls.Add(dataGridViewRePast);
            Controls.Add(panel2);
            Name = "RePastForm";
            Text = "RePastForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRePast).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button updateRePast;
        private Button addRePast;
        private Button deleteRePast;
        private DataGridView dataGridViewRePast;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox rePastTxt;
    }
}