using Diet.BLL.Manager.Concrete;
using Diet.BLL.Model;
using Diet.DAL.Entites.Concrete;
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
    public partial class NutrientCategoryForm : Form
    {
        NutrientManager _nutrientManager;
        FoodCategoryManager _foodCategoryManager;

        NutrientViewModel _nutrientViewModel = new NutrientViewModel();
        NutrientViewModel _selectNutrient;


        CommonFunc _commonFunc = new CommonFunc();


        public NutrientCategoryForm(UserViewModel admin)
        {
            InitializeComponent();
            InitFoodCategory();
            InitNutrietGrid();
        }
        private void InitFoodCategory()
        {
            _foodCategoryManager = new FoodCategoryManager();
            comboBoxFoodCateg.DataSource = _foodCategoryManager.GetAll();
            comboBoxFoodCateg.DisplayMember = "Name";
            comboBoxFoodCateg.ValueMember = "Id";
        }

        private void InitNutrietGrid()
        {
            _nutrientManager = new NutrientManager();
            dataGridViewNutrient.DataSource = null;
            var a = _nutrientManager.GetAll()
                                    .OrderBy(x => x.FoodCategoryId)
                                    .ThenBy(x => x.Name)
                                    .ToList();
            dataGridViewNutrient.DataSource = _nutrientManager.GetAll()
                                                              .OrderBy(x => x.FoodCategoryId)
                                                              .ThenBy(x => x.Name).ToList();

            dataGridViewNutrient.Columns["Id"].Visible = false;

        }


        private void addNutrient_Click(object sender, EventArgs e)
        {
            _nutrientManager = new NutrientManager();

            if (!_commonFunc.WhiteSpaceOrNull(nutrientNameTxt.Text, "Nutrient Name")) return;
            _nutrientViewModel.Name = nutrientNameTxt.Text;

            if (!_commonFunc.WhiteSpaceOrNull(calorieTxt.Text, "Calorie")) return;
            _nutrientViewModel.Calorie = Convert.ToInt64(calorieTxt.Text);

            _nutrientViewModel.FoodCategoryId = (int)comboBoxFoodCateg.SelectedValue;

            OpenPictureDialog(_nutrientViewModel);

            _nutrientManager.Add(_nutrientViewModel);

            DePicture(_nutrientViewModel);

            MessageBox.Show("Basarili bir sekilde ekleme islemi gerceklesmistir");
            InitNutrietGrid();
        }

        private void OpenPictureDialog(NutrientViewModel ntv)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    byte[] imageData = File.ReadAllBytes(filePath);
                    ntv.Picture = imageData;

                }
            }
        }
        private void DePicture(NutrientViewModel ntv)
        {
            using (MemoryStream ms = new MemoryStream(ntv.Picture))
            {
                pictureBoxNutrient.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxNutrient.Image = Image.FromStream(ms);
            }
        }
        private void deleteFood_Click(object sender, EventArgs e)
        {
            if (_selectNutrient != null)
            {
                _nutrientManager = new NutrientManager();

                _nutrientManager.Delete(_selectNutrient);

                MessageBox.Show("Besin basarli bir sekilde silindi");

                InitNutrietGrid();
            }
            else MessageBox.Show("Once secim yapiniz!");

            _selectNutrient = null;

        }

        private void dataGridViewNutrient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _selectNutrient = (NutrientViewModel)dataGridViewNutrient.SelectedRows[0].DataBoundItem;

                nutrientNameTxt.Text = _selectNutrient.Name;
                calorieTxt.Text = _selectNutrient.Calorie.ToString();
                comboBoxFoodCateg.SelectedValue = _selectNutrient.FoodCategoryId;
                DePicture(_selectNutrient);

            }
            catch (Exception ex)
            {
                _selectNutrient = null;
                MessageBox.Show(ex.Message);
            }
        }

        private void updateFood_Click(object sender, EventArgs e)
        {
            if (_selectNutrient != null)
            {
                _nutrientManager = new NutrientManager();

                if (!_commonFunc.WhiteSpaceOrNull(nutrientNameTxt.Text, "Nutrient Name")) return;
                _selectNutrient.Name = nutrientNameTxt.Text;

                if (!_commonFunc.WhiteSpaceOrNull(calorieTxt.Text, "Calorie")) return;
                _selectNutrient.Calorie = Convert.ToInt64(calorieTxt.Text);

                _selectNutrient.FoodCategoryId = (int)comboBoxFoodCateg.SelectedValue;

                OpenPictureDialog(_selectNutrient);

                _nutrientManager.Update(_selectNutrient);

                MessageBox.Show("Besin basarli bir sekilde Guncellendi");

                InitNutrietGrid();
            }
            else MessageBox.Show("Once secim yapiniz!");

            _selectNutrient = null;

        }

        private void NutrientCategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}

