namespace Diet.FormPL.Pages.Admin
{
    partial class FoodCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodCategoryForm));
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            foodTxt = new TextBox();
            dataGridViewFood = new DataGridView();
            deleteFood = new Button();
            addFood = new Button();
            updateFood = new Button();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFood).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Khaki;
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(29, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 95);
            panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LemonChiffon;
            groupBox1.Controls.Add(foodTxt);
            groupBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Category Name";
            // 
            // foodTxt
            // 
            foodTxt.Location = new Point(6, 40);
            foodTxt.Name = "foodTxt";
            foodTxt.Size = new Size(226, 22);
            foodTxt.TabIndex = 1;
            // 
            // dataGridViewFood
            // 
            dataGridViewFood.BackgroundColor = Color.LemonChiffon;
            dataGridViewFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFood.GridColor = Color.White;
            dataGridViewFood.Location = new Point(527, 31);
            dataGridViewFood.Name = "dataGridViewFood";
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dataGridViewFood.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewFood.Size = new Size(240, 311);
            dataGridViewFood.TabIndex = 6;
            dataGridViewFood.CellClick += dataGridViewFood_CellClick;
            // 
            // deleteFood
            // 
            deleteFood.BackColor = Color.IndianRed;
            deleteFood.Cursor = Cursors.Hand;
            deleteFood.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            deleteFood.ForeColor = Color.White;
            deleteFood.Location = new Point(658, 348);
            deleteFood.Name = "deleteFood";
            deleteFood.Size = new Size(109, 36);
            deleteFood.TabIndex = 7;
            deleteFood.Text = "Delete";
            deleteFood.UseVisualStyleBackColor = false;
            deleteFood.Click += deleteFood_Click;
            // 
            // addFood
            // 
            addFood.BackColor = Color.LemonChiffon;
            addFood.Cursor = Cursors.Hand;
            addFood.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            addFood.Location = new Point(29, 224);
            addFood.Name = "addFood";
            addFood.Size = new Size(243, 36);
            addFood.TabIndex = 10;
            addFood.Text = "Add Food Category";
            addFood.UseVisualStyleBackColor = false;
            addFood.Click += addFood_Click;
            // 
            // updateFood
            // 
            updateFood.BackColor = Color.SteelBlue;
            updateFood.Cursor = Cursors.Hand;
            updateFood.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            updateFood.ForeColor = Color.White;
            updateFood.Location = new Point(527, 348);
            updateFood.Name = "updateFood";
            updateFood.Size = new Size(109, 36);
            updateFood.TabIndex = 11;
            updateFood.Text = "Update";
            updateFood.UseVisualStyleBackColor = false;
            updateFood.Click += updateFood_Click;
            // 
            // FoodCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(updateFood);
            Controls.Add(addFood);
            Controls.Add(deleteFood);
            Controls.Add(dataGridViewFood);
            Controls.Add(panel2);
            Name = "FoodCategoryForm";
            Text = "Food Category Form";
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox foodTxt;
        private DataGridView dataGridViewFood;
        private Button deleteFood;
        private Button addFood;
        private Button updateFood;
    }
}