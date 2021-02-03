using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DokaPass
{
    public partial class PullForm : Form
    {
        public PullForm(string key, string username)
        {
            InitializeComponent();
            this.key = key;
            this.username = username;
        }

        #region deklarace
        string binPath;
        string accsPath;
        string key, username;

        #endregion

        

        #region PAGE_DESIGN
        private void PageDesign()
        {
            this.MinimumSize = new System.Drawing.Size(800, 600);
            pnlTopButtonsAddEdit.Width = (this.Width / 100) * 45;
            btnADD.Width = (this.Width / 100) * 15;
            btnEdit.Width = (this.Width / 100) * 15;
            btnSpectate.Width = (this.Width / 100) * 15;
            pnlAcc.Width = (this.Width / 100) * 20;
            pnlWithDeleteButton.Width = (this.Width / 100) * 15;
            pnlSpace.Width = (this.Width / 100) * 5;
            pnlTop.Height = (Screen.PrimaryScreen.Bounds.Height / 100) * 7;
        }
        private void PullForm_Load(object sender, EventArgs e)
        {
            lblHelloMoment.Text = "Hi, " + username + "!";

            PageDesign();
        }
        private void PullForm_Resize(object sender, EventArgs e)
        {
            PageDesign();
        }
        #endregion

        #region LogOut
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[0].Name == "Form1") Application.OpenForms[0].Show();
            this.Hide();
        }
        private void PullForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Close();
            Application.Exit();
        }
        #endregion
    }
}
