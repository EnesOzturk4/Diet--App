using Diet.BLL.Manager.Concrete;
using Diet.BLL.Model;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using Diet.FormPL.CommenFunc;

namespace Diet.FormPL.Pages
{
    public partial class RegisterForm : Form
    {
        CommonFunc commonFunc;
        public RegisterForm()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.None;
            this.BackgroundImageLayout = ImageLayout.None;
            this.Size = this.BackgroundImage.Size;
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.CenterToScreen();
            commonFunc = new CommonFunc();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserViewModel newUser = new UserViewModel();
            UserManger userManger = new UserManger();

            if (!commonFunc.WhiteSpaceOrNull(NameTxt.Text, "Name")) return;
            newUser.Name = NameTxt.Text;

            if (!commonFunc.WhiteSpaceOrNull(SurnameTxt.Text, "Surname")) return;
            newUser.Surname = SurnameTxt.Text;

            if (!commonFunc.WhiteSpaceOrNull(EMailTxt.Text, "Email")) return;
            if (!commonFunc.ValidationEmail(EMailTxt.Text)) return;
            newUser.Email = EMailTxt.Text;

            if (!commonFunc.WhiteSpaceOrNull(PasswordTxt.Text, "Password")) return;
            if (!commonFunc.ValidationPassword(PasswordTxt.Text)) return;

            newUser.Password = commonFunc.sha256_hash(PasswordTxt.Text);

            var rePassowrd = commonFunc.sha256_hash(RePasswordTxt.Text);
            if (newUser.Password != rePassowrd)
            {
                MessageBox.Show("Sifreniz ile Sifre Tekrariniz Uyusmamaktadir!!");
                return;
            }

            if (!commonFunc.WhiteSpaceOrNull(SizeTxt.Text, "Size")) return;
            newUser.Size = Convert.ToInt32(SizeTxt.Text);

            if (!commonFunc.WhiteSpaceOrNull(WeightTxt.Text, "Weight")) return;
            newUser.Weight = Convert.ToInt32(WeightTxt.Text);

            userManger.Add(newUser);
            MessageBox.Show("Kaydiniz Basarili bir sekilde Tamamlanmistir");

            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }
        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
