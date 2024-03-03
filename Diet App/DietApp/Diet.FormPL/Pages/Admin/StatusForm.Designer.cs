namespace Diet.FormPL.Pages.Admin
{
    partial class StatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusForm));
            dataGridViewMealRecord = new DataGridView();
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            Add = new Button();
            updateRePast = new Button();
            deleteRePast = new Button();
            dateTimePicker = new DateTimePicker();
            comboBoxNutrient = new ComboBox();
            comboBoxRepast = new ComboBox();
            label7 = new Label();
            porsionTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            comboBoxReport = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            comboBobRepastType = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMealRecord).BeginInit();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMealRecord
            // 
            dataGridViewMealRecord.BackgroundColor = Color.LemonChiffon;
            dataGridViewMealRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMealRecord.GridColor = Color.White;
            dataGridViewMealRecord.Location = new Point(12, 241);
            dataGridViewMealRecord.Name = "dataGridViewMealRecord";
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dataGridViewMealRecord.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMealRecord.Size = new Size(776, 162);
            dataGridViewMealRecord.TabIndex = 14;
            dataGridViewMealRecord.CellClick += dataGridViewMeal_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(groupBox4);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 141);
            panel1.TabIndex = 15;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.LemonChiffon;
            groupBox4.Controls.Add(Add);
            groupBox4.Controls.Add(updateRePast);
            groupBox4.Controls.Add(deleteRePast);
            groupBox4.Controls.Add(dateTimePicker);
            groupBox4.Controls.Add(comboBoxNutrient);
            groupBox4.Controls.Add(comboBoxRepast);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(porsionTxt);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label4);
            groupBox4.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(770, 135);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Add";
            // 
            // Add
            // 
            Add.BackColor = Color.LemonChiffon;
            Add.Cursor = Cursors.Hand;
            Add.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Add.ForeColor = Color.Black;
            Add.Location = new Point(60, 93);
            Add.Name = "Add";
            Add.Size = new Size(109, 36);
            Add.TabIndex = 19;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // updateRePast
            // 
            updateRePast.BackColor = Color.SteelBlue;
            updateRePast.Cursor = Cursors.Hand;
            updateRePast.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            updateRePast.ForeColor = Color.White;
            updateRePast.Location = new Point(336, 93);
            updateRePast.Name = "updateRePast";
            updateRePast.Size = new Size(109, 36);
            updateRePast.TabIndex = 18;
            updateRePast.Text = "Update";
            updateRePast.UseVisualStyleBackColor = false;
            updateRePast.Click += updateRePast_Click;
            // 
            // deleteRePast
            // 
            deleteRePast.BackColor = Color.IndianRed;
            deleteRePast.Cursor = Cursors.Hand;
            deleteRePast.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            deleteRePast.ForeColor = Color.White;
            deleteRePast.Location = new Point(600, 93);
            deleteRePast.Name = "deleteRePast";
            deleteRePast.Size = new Size(109, 36);
            deleteRePast.TabIndex = 17;
            deleteRePast.Text = "Delete";
            deleteRePast.UseVisualStyleBackColor = false;
            deleteRePast.Click += deleteRePast_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(553, 48);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 21);
            dateTimePicker.TabIndex = 13;
            // 
            // comboBoxNutrient
            // 
            comboBoxNutrient.BackColor = Color.LemonChiffon;
            comboBoxNutrient.FormattingEnabled = true;
            comboBoxNutrient.Location = new Point(60, 48);
            comboBoxNutrient.Name = "comboBoxNutrient";
            comboBoxNutrient.Size = new Size(121, 23);
            comboBoxNutrient.TabIndex = 12;
            // 
            // comboBoxRepast
            // 
            comboBoxRepast.BackColor = Color.LemonChiffon;
            comboBoxRepast.FormattingEnabled = true;
            comboBoxRepast.Location = new Point(226, 48);
            comboBoxRepast.Name = "comboBoxRepast";
            comboBoxRepast.Size = new Size(121, 23);
            comboBoxRepast.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.Location = new Point(404, 26);
            label7.Name = "label7";
            label7.Size = new Size(59, 19);
            label7.TabIndex = 10;
            label7.Text = "Porsion";
            // 
            // porsionTxt
            // 
            porsionTxt.BackColor = SystemColors.Info;
            porsionTxt.Location = new Point(404, 48);
            porsionTxt.Name = "porsionTxt";
            porsionTxt.Size = new Size(121, 21);
            porsionTxt.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(553, 26);
            label3.Name = "label3";
            label3.Size = new Size(40, 19);
            label3.TabIndex = 7;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(226, 26);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 6;
            label2.Text = "Repast";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(60, 26);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 2;
            label4.Text = "Nutrient";
            // 
            // comboBoxReport
            // 
            comboBoxReport.BackColor = Color.LemonChiffon;
            comboBoxReport.FormattingEnabled = true;
            comboBoxReport.Location = new Point(40, 39);
            comboBoxReport.Name = "comboBoxReport";
            comboBoxReport.Size = new Size(121, 23);
            comboBoxReport.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(40, 17);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 16;
            label1.Text = "Report Type";
            // 
            // button1
            // 
            button1.BackColor = Color.LemonChiffon;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(603, 31);
            button1.Name = "button1";
            button1.Size = new Size(109, 36);
            button1.TabIndex = 20;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LemonChiffon;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(401, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(401, 17);
            label5.Name = "label5";
            label5.Size = new Size(127, 19);
            label5.TabIndex = 21;
            label5.Text = "Day/Week/Mounth";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LemonChiffon;
            groupBox1.Controls.Add(comboBobRepastType);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxReport);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 76);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reporting";
            // 
            // comboBobRepastType
            // 
            comboBobRepastType.BackColor = Color.LemonChiffon;
            comboBobRepastType.FormattingEnabled = true;
            comboBobRepastType.Location = new Point(212, 39);
            comboBobRepastType.Name = "comboBobRepastType";
            comboBobRepastType.Size = new Size(121, 23);
            comboBobRepastType.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label6.Location = new Point(212, 17);
            label6.Name = "label6";
            label6.Size = new Size(82, 19);
            label6.TabIndex = 23;
            label6.Text = "RepastType";
            // 
            // StatusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dataGridViewMealRecord);
            Name = "StatusForm";
            Text = "StatusForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMealRecord).EndInit();
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewMealRecord;
        private Panel panel1;
        private GroupBox groupBox4;
        private ComboBox comboBoxRepast;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label4;
        private DateTimePicker dateTimePicker;
        private ComboBox comboBoxNutrient;
        private TextBox porsionTxt;
        private Button updateRePast;
        private Button deleteRePast;
        private Button Add;
        private ComboBox comboBoxReport;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label5;
        private GroupBox groupBox1;
        private ComboBox comboBobRepastType;
        private Label label6;
    }
}