using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DokaPass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            LogInForm loginForm = new DokaPass.LogInForm(this.Width,this.Height, this.Location.X, this.Location.Y);
            loginForm.Show();
            this.Hide();
        }

        private void BtnNewAcc_Click(object sender, EventArgs e)
        {
            NewAccForm newAccForm = new DokaPass.NewAccForm(this.Width, this.Height, this.Location.X, this.Location.Y);
            newAccForm.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        #region PAGE_DESIGN
        private void PageDesign()
        {
            this.MinimumSize = new System.Drawing.Size(760, 600);

            //fonts
            lblHeader.Font = new Font(lblHeader.Font.FontFamily, 20);
            btnLogIn.Font = new Font(btnLogIn.Font.FontFamily, 10);
            btnNewAcc.Font = new Font(btnNewAcc.Font.FontFamily, 10);

            //top
            pnlTop.Height = (Screen.PrimaryScreen.Bounds.Height / 100) * 10;
            lblHeader.Location = new Point(this.Width/2-7*25,pnlTop.Height/2-25/2);//   /2(center)   -4(words)    25(= 20pt to px)

            //body
            btnLogIn.Size = new Size(250,50);
            btnNewAcc.Size = new Size(250, 50);
            btnLogIn.Location = new Point(this.Width/2-150, this.Height/100*30);
            btnNewAcc.Location = new Point(btnLogIn.Location.X,btnLogIn.Location.Y+15+btnLogIn.Height);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            PageDesign();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            PageDesign();
        }

        private void BtnLogIn_MouseHover(object sender, EventArgs e)
        {
            btnLogIn.BackColor = Color.FromArgb(119, 218, 119);
        }

        private void BtnLogIn_MouseLeave(object sender, EventArgs e)
        {
            btnLogIn.BackColor = Color.PaleGreen;
        }

        private void BtnNewAcc_MouseHover(object sender, EventArgs e)
        {
            btnNewAcc.BackColor = Color.FromArgb(119, 218, 119);
        }

        private void BtnNewAcc_MouseLeave(object sender, EventArgs e)
        {
            btnNewAcc.BackColor = Color.PaleGreen;
        }
        #endregion
    }
}
