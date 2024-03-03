using Diet.BLL.Model;
using Diet.FormPL.Pages.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diet.FormPL.Pages.User
{
    public partial class UserHomeForm : Form
    {
        UserViewModel _user;
        public UserHomeForm(UserViewModel user)
        {
            InitializeComponent();
            this.Width = 830;
            this.Height = 620;
            this.CenterToScreen();
            _user = user;
            foreach (Control item in this.Controls)
            {
                if (item is MdiClient)
                {
                    ((MdiClient)item).BackgroundImage = Image.FromFile("C:\\Users\\Cihan\\Desktop\\Diet2\\Diet\\DietApp\\Diet.FormPL\\Assets\\Img\\desktop-wallpaper-funny-ninja-on-diet-funny-background-and-cute-funny (1).png");
                }
            }
        }
        private void ShowForm(Form form)
        {
            if (!MdiChildren.Contains(form.MdiParent = this))
            {
                foreach (Form formDown in MdiChildren)
                {
                    if (form.Text == formDown.Text)
                    {
                        formDown.Show();
                        formDown.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        formDown.Close();
                    }
                }
            }
        }

        private void userInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new UserInfomation(_user));
        }

        private void statusUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new StatusUsersForm(_user));
        }

        private void UserHomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
