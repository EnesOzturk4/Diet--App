using Diet.BLL.Model;
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
    public partial class AdminHomeForm : Form
    {
        UserViewModel _admin;
        public AdminHomeForm(UserViewModel admin)
        {
            InitializeComponent();
            this.Width = 830;
            this.Height = 620;
            this.CenterToScreen();
            _admin = admin;
            foreach (Control item in this.Controls)
            {
                if (item is MdiClient)
                {
                    ((MdiClient)item).BackgroundImage = Image.FromFile("C:\\Users\\Cihan\\source\\repos\\Diet\\DietApp\\Diet.FormPL\\Assets\\Img\\desktop-wallpaper-funny-ninja-on-diet-funny-background-and-cute-funny (1).png");
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

        private void yourInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new YourInformationForm(_admin));
        }

        private void userInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new UserInfomation(_admin));
        }

        private void foodCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new FoodCategoryForm(_admin));
        }

        private void nutrientCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new NutrientCategoryForm(_admin));
        }

        private void repastCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new RePastForm());
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new StatusForm(_admin));
        }
    }
}
