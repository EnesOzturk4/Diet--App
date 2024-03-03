using Diet.BLL.Manager.Concrete;
using Diet.BLL.Model;
using Diet.FormPL.CommenFunc;
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
    public partial class FoodCategoryForm : Form
    {
        UserViewModel _admin;
        CommonFunc _commonFunc;

        FoodCategoryViewModel _foodCategory;
        List<FoodCategoryViewModel> _foods;

        public FoodCategoryForm(UserViewModel admin)
        {
            InitializeComponent();
            _admin = admin;
            _commonFunc = new CommonFunc();

            InitFoodCategory();
        }

        private void InitFoodCategory()
        {
            FoodCategoryManager foodManager = new FoodCategoryManager();

            _foods = foodManager.GetAll()
                                .OrderBy(x => x.Name)
                                .ThenBy(x => x.Id)
                                .ToList();

            dataGridViewFood.DataSource = null;
            dataGridViewFood.DataSource = _foods;

            dataGridViewFood.Columns["Id"].Visible = false;

        }
        private void addFood_Click(object sender, EventArgs e)
        {
            FoodCategoryManager foodManager = new FoodCategoryManager();
            FoodCategoryViewModel food = new FoodCategoryViewModel();

            if (!_commonFunc.WhiteSpaceOrNull(foodTxt.Text, "Food")) return;
            food.Name = foodTxt.Text;

            try
            {
                foodManager.Add(food);
                MessageBox.Show("Basarili bir sekilde kategori eklenmistir.");
            }
            catch
            {
                MessageBox.Show("Ayni isimde bir kategori bulunmaktadir.");
            }

            InitFoodCategory();
        }
        private void updateFood_Click(object sender, EventArgs e)
        {
            FoodCategoryManager foodManager = new FoodCategoryManager();

            if (!_commonFunc.WhiteSpaceOrNull(foodTxt.Text, "Food")) return;
            _foodCategory.Name = foodTxt.Text;

            try
            {
                foodManager.Update(_foodCategory);
                MessageBox.Show("Basarili bir sekilde kategori guncellenmistir.");
            }
            catch
            {
                MessageBox.Show("Ayni isimde bir kategori bulunmaktadir.");
            }

            InitFoodCategory();


        }

        private void deleteFood_Click(object sender, EventArgs e)
        {

            FoodCategoryManager foodManager = new FoodCategoryManager();

            foodManager.Delete(_foodCategory);
            InitFoodCategory();
        }

        private void dataGridViewFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _foodCategory = (FoodCategoryViewModel)dataGridViewFood.SelectedRows[0].DataBoundItem;
                foodTxt.Text = _foodCategory.Name;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
