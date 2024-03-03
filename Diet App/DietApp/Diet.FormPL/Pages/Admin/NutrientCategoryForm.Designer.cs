namespace Diet.FormPL.Pages.Admin
{
    partial class NutrientCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NutrientCategoryForm));
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            nutrientNameTxt = new TextBox();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            calorieTxt = new TextBox();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            comboBoxFoodCateg = new ComboBox();
            pictureBoxNutrient = new PictureBox();
            addNutrient = new Button();
            dataGridViewNutrient = new DataGridView();
            updateFood = new Button();
            deleteFood = new Button();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNutrient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNutrient).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Khaki;
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 95);
            panel2.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LemonChiffon;
            groupBox1.Controls.Add(nutrientNameTxt);
            groupBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nutrient Name";
            // 
            // nutrientNameTxt
            // 
            nutrientNameTxt.Location = new Point(6, 40);
            nutrientNameTxt.Name = "nutrientNameTxt";
            nutrientNameTxt.Size = new Size(226, 22);
            nutrientNameTxt.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(groupBox2);
            panel1.Location = new Point(10, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 95);
            panel1.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LemonChiffon;
            groupBox2.Controls.Add(calorieTxt);
            groupBox2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(238, 88);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Calorie";
            // 
            // calorieTxt
            // 
            calorieTxt.Location = new Point(6, 40);
            calorieTxt.Name = "calorieTxt";
            calorieTxt.Size = new Size(226, 22);
            calorieTxt.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Khaki;
            panel3.Controls.Add(groupBox3);
            panel3.Location = new Point(10, 214);
            panel3.Name = "panel3";
            panel3.Size = new Size(243, 95);
            panel3.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LemonChiffon;
            groupBox3.Controls.Add(comboBoxFoodCateg);
            groupBox3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(238, 88);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Food Category";
            // 
            // comboBoxFoodCateg
            // 
            comboBoxFoodCateg.FormattingEnabled = true;
            comboBoxFoodCateg.Location = new Point(6, 38);
            comboBoxFoodCateg.Name = "comboBoxFoodCateg";
            comboBoxFoodCateg.Size = new Size(226, 24);
            comboBoxFoodCateg.TabIndex = 2;
            // 
            // pictureBoxNutrient
            // 
            pictureBoxNutrient.BackColor = Color.LemonChiffon;
            pictureBoxNutrient.Location = new Point(10, 312);
            pictureBoxNutrient.Name = "pictureBoxNutrient";
            pictureBoxNutrient.Size = new Size(245, 95);
            pictureBoxNutrient.TabIndex = 9;
            pictureBoxNutrient.TabStop = false;
            // 
            // addNutrient
            // 
            addNutrient.BackColor = Color.LemonChiffon;
            addNutrient.Cursor = Cursors.Hand;
            addNutrient.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            addNutrient.Location = new Point(12, 413);
            addNutrient.Name = "addNutrient";
            addNutrient.Size = new Size(243, 36);
            addNutrient.TabIndex = 11;
            addNutrient.Text = "Add Nutrient";
            addNutrient.UseVisualStyleBackColor = false;
            addNutrient.Click += addNutrient_Click;
            // 
            // dataGridViewNutrient
            // 
            dataGridViewNutrient.BackgroundColor = Color.LemonChiffon;
            dataGridViewNutrient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNutrient.Location = new Point(504, 16);
            dataGridViewNutrient.Name = "dataGridViewNutrient";
            dataGridViewNutrient.Size = new Size(284, 307);
            dataGridViewNutrient.TabIndex = 12;
            dataGridViewNutrient.CellClick += dataGridViewNutrient_CellClick;
            // 
            // updateFood
            // 
            updateFood.BackColor = Color.SteelBlue;
            updateFood.Cursor = Cursors.Hand;
            updateFood.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            updateFood.ForeColor = Color.White;
            updateFood.Location = new Point(515, 332);
            updateFood.Name = "updateFood";
            updateFood.Size = new Size(109, 36);
            updateFood.TabIndex = 14;
            updateFood.Text = "Update";
            updateFood.UseVisualStyleBackColor = false;
            updateFood.Click += updateFood_Click;
            // 
            // deleteFood
            // 
            deleteFood.BackColor = Color.IndianRed;
            deleteFood.Cursor = Cursors.Hand;
            deleteFood.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            deleteFood.ForeColor = Color.White;
            deleteFood.Location = new Point(679, 329);
            deleteFood.Name = "deleteFood";
            deleteFood.Size = new Size(109, 36);
            deleteFood.TabIndex = 13;
            deleteFood.Text = "Delete";
            deleteFood.UseVisualStyleBackColor = false;
            deleteFood.Click += deleteFood_Click;
            // 
            // NutrientCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(updateFood);
            Controls.Add(deleteFood);
            Controls.Add(dataGridViewNutrient);
            Controls.Add(addNutrient);
            Controls.Add(pictureBoxNutrient);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "NutrientCategoryForm";
            Text = "NutrientCategoryForm";
            Load += NutrientCategoryForm_Load;
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxNutrient).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNutrient).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox nutrientNameTxt;
        private Panel panel1;
        private GroupBox groupBox2;
        private TextBox calorieTxt;
        private Panel panel3;
        private GroupBox groupBox3;
        private ComboBox comboBoxFoodCateg;
        private PictureBox pictureBoxNutrient;
        private Button addNutrient;
        private DataGridView dataGridViewNutrient;
        private Button updateFood;
        private Button deleteFood;
    }
}