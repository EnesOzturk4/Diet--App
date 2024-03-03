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
    public partial class RePastForm : Form
    {
        CommonFunc _commonFunc;
        RepastManager _repastManager;
        RepastViewModel _repastViewModel;
        public RePastForm()
        {
            InitializeComponent();
            InitRePastCategory();
            _commonFunc = new CommonFunc();
            _repastViewModel = new RepastViewModel();
        }

        private void InitRePastCategory()
        {
            RepastManager repastManager = new RepastManager();

            dataGridViewRePast.DataSource = null;

            dataGridViewRePast.DataSource = repastManager.GetAll()
                                .OrderBy(x => x.Name)
                                .ThenBy(x => x.Id)
                                .ToList();

            dataGridViewRePast.Columns["Id"].Visible = false;

        }

        private void addRePast_Click(object sender, EventArgs e)
        {
            _repastManager = new RepastManager();
            RepastViewModel reapst = new RepastViewModel();
            if (!_commonFunc.WhiteSpaceOrNull(rePastTxt.Text, "Repast Name")) return;
            reapst.Name = rePastTxt.Text;

            try
            {
                _repastManager.Add(reapst);
                MessageBox.Show("Basarili bir sekilde ogun eklenmistir.");
            }
            catch
            {
                MessageBox.Show("Ayni isimde bir ogun bulunmaktadir.");
            }
            InitRePastCategory();
        }

        private void updateRePast_Click(object sender, EventArgs e)
        {
            _repastManager = new RepastManager();


            if (!_commonFunc.WhiteSpaceOrNull(rePastTxt.Text, "Repast Name")) return;
            _repastViewModel.Name = rePastTxt.Text;

            try
            {
                _repastManager.Update(_repastViewModel);
                MessageBox.Show("Basarili bir sekilde ogun guncellenmistir.");
            }
            catch
            {
                MessageBox.Show("Ayni isimde bir kategori bulunmaktadir.");
            }
            _repastViewModel = null;
            InitRePastCategory();
        }

        private void deleteRePast_Click(object sender, EventArgs e)
        {
            _repastManager = new RepastManager();
            if (_repastViewModel != null)
            {
                _repastManager.Delete(_repastViewModel);

            }
            else
            {
                MessageBox.Show("Lutfen tekrardan secim yapiniz");
            }

            _repastViewModel = null;

            InitRePastCategory();

        }

        private void dataGridViewRePast_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _repastViewModel = null;
            try
            {
                _repastViewModel = (RepastViewModel)dataGridViewRePast.SelectedRows[0].DataBoundItem;
                rePastTxt.Text = _repastViewModel.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
