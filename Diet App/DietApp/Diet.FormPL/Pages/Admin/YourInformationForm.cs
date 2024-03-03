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
    public partial class YourInformationForm : Form
    {
        UserViewModel _admin;
        CommonFunc commonFunc;
        public YourInformationForm(UserViewModel admin)
        {
            InitializeComponent();
            commonFunc = new CommonFunc();
            _admin = admin;

            this.Width = 880;
            this.Height = 630;

            InitLabel();
            InitChanger();
        }

        private void InitLabel()
        {
            fullNameLabel.Text = $"{_admin.Name} {_admin.Surname}";
            sizeLabel.Text = $"{_admin.Size.ToString()} cm";
            weightLabel.Text = $"{_admin.Weight.ToString()} kg";
            emailLabel.Text = $"{_admin.Email}";
        }
        private void InitChanger()
        {
            nameTxt.Text = _admin.Name;
            surnameTxt.Text = _admin.Surname;
            sizeTxt.Text = _admin.Size.ToString();
            weighTxt.Text = _admin.Weight.ToString();
            emailTxt.Text = _admin.Email.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserManger userManger = new UserManger();

            if (!commonFunc.WhiteSpaceOrNull(nameTxt.Text, "Name")) return;
            _admin.Name = nameTxt.Text;

            if (!commonFunc.WhiteSpaceOrNull(surnameTxt.Text, "Surname")) return;
            _admin.Surname = surnameTxt.Text;

            if (!commonFunc.WhiteSpaceOrNull(sizeTxt.Text, "Size")) return;
            _admin.Size = Convert.ToInt64(sizeTxt.Text);

            if (!commonFunc.WhiteSpaceOrNull(weighTxt.Text, "Weight")) return;
            _admin.Weight = Convert.ToInt64(weighTxt.Text);

            if (!commonFunc.WhiteSpaceOrNull(emailTxt.Text, "Email")) return;
            if (!commonFunc.ValidationEmail(emailTxt.Text)) return;
            _admin.Email = emailTxt.Text;


            userManger.Update(_admin);
            MessageBox.Show("Basarili bir sekilde guncellendi");

            InitLabel();


        }


    }
}
