using Diet.BLL.Manager.Abstarct;
using Diet.BLL.Manager.Concrete;
using Diet.BLL.Model;
using Diet.FormPL.CommenFunc;
using Diet.FormPL.Pages;
using Diet.FormPL.Pages.Admin;
using Diet.FormPL.Pages.User;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;




namespace Diet.FormPL
{

    public partial class Form1 : Form
    {
        CommonFunc commonFunc;
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.None;
            this.BackgroundImageLayout = ImageLayout.None;
            this.Size = this.BackgroundImage.Size;
            this.CenterToScreen();

            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);

            var rgb1 = new List<int> { 255, 240, 245 };
            var rgbHover = new List<int> { 247, 221, 227 };
            ButonHoverEffect(button1, rgb1, rgbHover);
            ButonHoverEffect(GirisBtn, rgb1, rgbHover);

            commonFunc = new CommonFunc();

        }
        private void ButonHoverEffect(Button button, List<int> rgb, List<int> rgbHover)
        {
            button.BackColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(rgbHover[0], rgbHover[1], rgbHover[2]);
        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            UserManger userManger = new UserManger();
            var password = SifreTxt.Text;
            var eMail = EMailTxt.Text;

            var user = userManger.GetAll()
                                 .FirstOrDefault(m => m.Password == commonFunc.sha256_hash(password) &&
                                                 m.Email == eMail);

            if (user != null)
            {
                if (user.IsAdmin)
                {
                    AdminHomeForm adminHome = new AdminHomeForm(user);
                    this.Hide();
                    adminHome.ShowDialog();
                }
                else
                {
                    UserHomeForm userHome = new UserHomeForm(user);
                    this.Hide();
                    userHome.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Kullanici bulunamadi. Email adresinizi ve sifrenizi tekara giriniz. Hata Alirsaniz Admin ile Gorusunuz");
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
