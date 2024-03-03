using Diet.BLL.Manager.Concrete;
using Diet.BLL.Model;
using Diet.DAL.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diet.FormPL.Pages.Admin
{
    public partial class StatusForm : Form
    {
        UserViewModel _admin;

        MealDietRecordManager _mealDietRecordManager;
        NutrientManager _nutrientManager;
        RepastManager _repastManager;


        int id;
        public StatusForm(UserViewModel admin)
        {
            _nutrientManager = new NutrientManager();
            _repastManager = new RepastManager();
            _mealDietRecordManager = new MealDietRecordManager();

            _admin = admin;

            InitializeComponent();
            InitMealDietRecord();
            InitcomboBoxs();
        }
        private void InitMealDietRecord()
        {
            MealDietRecordManager manager = new MealDietRecordManager();

            List<MealDietRecordViewModel> records = manager.Search(x => x.UserId == _admin.Id && x.DateTime.Date == DateTime.Now.Date).ToList();

            dataGridViewMealRecord.Rows.Clear();

            dataGridViewMealRecord.ColumnCount = 6;
            dataGridViewMealRecord.Columns[0].Name = "Id";
            dataGridViewMealRecord.Columns[1].Name = "Nutrient";
            dataGridViewMealRecord.Columns[2].Name = "RePast";
            dataGridViewMealRecord.Columns[3].Name = "Portion";
            dataGridViewMealRecord.Columns[4].Name = "DateTime";

            dataGridViewMealRecord.Columns[0].Visible = false;

            foreach (var record in records)
            {
                dataGridViewMealRecord.Rows.Add(record.Id, record.Nutrient.Name, record.Repast.Name, record.Portion, record.DateTime);
            }
            //dataGridViewMealRecord.DataSource = records;
        }

        private void InitcomboBoxs()
        {
            comboBoxNutrient.DataSource = _nutrientManager.GetAll();
            comboBoxNutrient.DisplayMember = "Name";
            comboBoxNutrient.ValueMember = "Id";

            comboBoxRepast.DataSource = _repastManager.GetAll();
            comboBoxRepast.ValueMember = "Id";
            comboBoxRepast.DisplayMember = "Name";

            comboBobRepastType.DataSource = _repastManager.GetAll();
            comboBobRepastType.DisplayMember = "Name";
            comboBobRepastType.ValueMember = "Id";


            comboBoxReport.Items.Add("End Day");
            comboBoxReport.Items.Add("Total Calorie");
            comboBoxReport.Items.Add("Comparison Of Week");
            comboBoxReport.Items.Add("Comparison Of Mounth");
            comboBoxReport.Items.Add("Food Type");


            comboBoxReport.SelectedIndex = 0;

        }
        private void Comparison(int number, string message)
        {
            UserManger users = new UserManger();
            List<UserViewModel> weeekReports = users.GetAll().ToList();
            double totalCalorie = 0;
            int sumPerson = 0;
            foreach (var weeekReport in weeekReports)
            {
                if (weeekReport.MealDietRecords != null)
                {
                    sumPerson++;
                    foreach (var item1 in weeekReport.MealDietRecords)
                    {
                        if (item1.DateTime.Date >= DateTime.Now.Date.AddDays(-number))
                        {
                            totalCalorie += item1.Nutrient.Calorie;
                        }
                    }
                }
            }
            MessageBox.Show($" {message} =  {totalCalorie / sumPerson}");
        }

        private void EndReport()
        {
            var endReports = _mealDietRecordManager.Search(x => x.DateTime.Date == DateTime.Now.Date);

            double calorieType = 0;

            foreach (var item in endReports)
            {
                if (item.RepastId == (int)comboBobRepastType.SelectedValue)
                {
                    calorieType += item.Nutrient.Calorie;

                }
            }
            MessageBox.Show($"{((RepastViewModel)comboBobRepastType.SelectedItem).Name} totla calorie = {calorieType}");
        }
        private void TotalCalorie()
        {
            var endReports = _mealDietRecordManager.Search(x => x.DateTime.Date == DateTime.Now.Date);

            double total = 0;

            foreach (var item in endReports)
            {
                total += item.Nutrient.Calorie;
            }
            MessageBox.Show($"Totla calorie = {total}");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            MealDietRecordViewModel diet = new MealDietRecordViewModel();

            try
            {
                diet.UserId = _admin.Id;
                diet.NutrientId = Convert.ToInt32(comboBoxNutrient.SelectedValue);
                diet.RepastId = Convert.ToInt32(comboBoxRepast.SelectedValue);
                diet.Portion = Convert.ToInt64(porsionTxt.Text);
                diet.DateTime = DateTime.Now.Date;


                _mealDietRecordManager.Add(diet);

                InitMealDietRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void deleteRePast_Click(object sender, EventArgs e)
        {

            if (id != 0)
            {
                try
                {
                    var deletDiet = _mealDietRecordManager.GetById(id);
                    _mealDietRecordManager.Remove(deletDiet);

                    MessageBox.Show("Kullanici Basarli bir sekilde silindi");
                    InitMealDietRecord();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else MessageBox.Show("Once secim yapiniz!");

        }

        private void dataGridViewMeal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = (int)dataGridViewMealRecord.SelectedRows[0].Cells["Id"].Value;
                var dietRecord = _mealDietRecordManager.GetById(id);

                porsionTxt.Text = dietRecord.Portion.ToString();
                comboBoxNutrient.SelectedValue = dietRecord.NutrientId;
                comboBoxRepast.SelectedValue = dietRecord.RepastId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateRePast_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var updateDietRecord = _mealDietRecordManager.GetById(id);

                updateDietRecord.Portion = Convert.ToInt64(porsionTxt.Text);
                updateDietRecord.NutrientId = Convert.ToInt32(comboBoxNutrient.SelectedValue);
                updateDietRecord.RepastId = Convert.ToInt32(comboBoxRepast.SelectedValue);

                _mealDietRecordManager.Update(updateDietRecord);
                InitMealDietRecord();
            }

        }

        private void FoodType()
        {
            var mealDietRecordManager = new MealDietRecordManager();
            var mealReport = new Dictionary<string, float>();

            foreach (var item in mealDietRecordManager.GetAll())
            {
                if (!mealReport.ContainsKey(item.Repast.Name))
                {
                    mealReport[item.Repast.Name] = item.Portion;
                }
                else
                {
                    mealReport[item.Repast.Name] += item.Portion;
                }
            }

            foreach (var repastName in mealReport.Keys)
            {
                MessageBox.Show($"{repastName}: {mealReport[repastName]} ");

                
                var mostConsumedFood = mealDietRecordManager.GetAll()
                    .Where(x => x.Repast.Name == repastName)
                    .OrderByDescending(x => x.Portion)
                    .FirstOrDefault();

                if (mostConsumedFood != null)
                {
                    MessageBox.Show($"En çok tüketilen yemek ({repastName}): {mostConsumedFood.Nutrient.Name}, Toplam miktar: {mostConsumedFood.Portion} porsion");
                }
                else
                {
                    MessageBox.Show($"({repastName}) için hiç kayıt bulunamadı.");
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBoxReport.SelectedIndex)
            {
                case 0:
                    EndReport();
                    break;
                case 1:
                    TotalCalorie();
                    break;
                case 2:
                    Comparison(7, "Hatalik");
                    break;
                case 3:
                    Comparison(30, "Aylik");
                    break;
                case 4:
                    FoodType();
                    break;
            }
        }
    }
}
