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
        public PullForm(string key, string username, int width, int height, int x, int y)
        {
            InitializeComponent();
            this.key = key;
            this.username = username;
            this.Width = width;
            this.Height = height;
            this.Location = new Point(x, y);
        }

        #region deklarace
        string binPath;
        string accsPath;
        string key, username;
        string DisplayMode;// is for change mode between view, create, edit  delete
        #endregion

        private void FuncDisplayMode()
        {
            AfterButtonClick();
            if (DisplayMode == "view")
            {


            }
            else if (DisplayMode == "create")
            {


            }
            else if (DisplayMode == "edit")
            {


            }
            else if (DisplayMode == "delete")
            {


            }

        }

        #region Buttons
        private void BtnADD_Click(object sender, EventArgs e)
        {
            DisplayMode = "create";
            FuncDisplayMode();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DisplayMode = "edit";
            FuncDisplayMode();
        }

        private void BtnSpectate_Click(object sender, EventArgs e)
        {
            DisplayMode = "view";
            FuncDisplayMode();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DisplayMode = "delete";
            FuncDisplayMode();
        }
        #endregion

        #region PAGE_DESIGN //// ONLY DESIGN
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


            //body
            //right pnl
            pnlUserPassComment.Size = new Size(((this.Width / 100) * 35), this.Height - pnlTop.Height);
            lblActualMode.Location = new Point(20, 20);
            //username
            txtUsername.Size = new Size(pnlUserPassComment.Width / 2, 40);
            txtUsername.Location = new Point(pnlUserPassComment.Width / 2 - pnlUserPassComment.Width / 4, pnlUserPassComment.Height / 2 - pnlUserPassComment.Height / 4);
            btnCopyUsername.Size = new Size(txtUsername.Height, txtUsername.Height);
            btnCopyUsername.Location = new Point(txtUsername.Location.X + 5 + txtUsername.Width, txtUsername.Location.Y);
            //pass
            txtPass.Size = txtUsername.Size;
            txtPass.Location = new Point(txtUsername.Location.X, txtUsername.Location.Y + 5 + txtUsername.Height);
            btnCopyPass.Size = new Size(txtUsername.Height, txtUsername.Height);
            btnCopyPass.Location = new Point(txtPass.Location.X + 5 + txtPass.Width, txtPass.Location.Y);
            btnGen.Size = new Size(btnCopyPass.Width * 2, btnCopyPass.Height);
            btnGen.Location = new Point(btnCopyPass.Location.X, btnCopyPass.Location.Y);
            //comment
            txtComments.Size = new Size(txtPass.Width, 150);
            txtComments.Location = new Point(txtPass.Location.X, txtPass.Location.Y + 5 + txtPass.Height);
            lblCharCounterForTxtComment.Location = new Point(txtComments.Location.X + txtComments.Width + 5, txtComments.Location.Y + txtComments.Height);
            //btnPridat
            btnEvent.Size = new Size(txtPass.Width, 30);
            btnEvent.Location = new Point(txtComments.Location.X, txtComments.Location.Y + txtComments.Height + 5);

        }

        #region textbox gray note
        private void Textboxes_Load()
        {
            //load txtUsername
            this.txtUsername.Enter += new EventHandler(TxtUsername_Enter);
            this.txtUsername.Leave += new EventHandler(TxtUsername_Leave);
            TxtUsername_SetText();
            //load txtPass
            this.txtPass.Enter += new EventHandler(TxtPass_Enter);
            this.txtPass.Leave += new EventHandler(TxtPass_Leave);
            TxtPass_SetText();
            //load txtComments
            this.txtComments.Enter += new EventHandler(TxtComments_Enter);
            this.txtComments.Leave += new EventHandler(TxtComments_Leave);
            TxtComments_SetText();
        }

        //txtUsername - gray note
        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "") TxtUsername_SetText();
        }
        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.ForeColor == Color.Black) return;
            txtUsername.Text = "";
            txtUsername.ForeColor = Color.Black;
        }
        protected void TxtUsername_SetText()
        {
            this.txtUsername.Text = "Jméno";
            txtUsername.ForeColor = Color.Gray;
        }


        //txtPass - gray note
        private void TxtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim() == "") TxtPass_SetText();
        }
        private void TxtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.ForeColor == Color.Black) return;
            txtPass.Text = "";
            txtPass.ForeColor = Color.Black;
        }
        protected void TxtPass_SetText()
        {
            this.txtPass.Text = "Heslo";
            txtPass.ForeColor = Color.Gray;
        }


        //txtComments - gray note
        private void TxtComments_Leave(object sender, EventArgs e)
        {
            if (txtComments.Text.Trim() == "") TxtComments_SetText();
        }
        private void TxtComments_Enter(object sender, EventArgs e)
        {
            if (txtComments.ForeColor == Color.Black) return;
            txtComments.Text = "";
            txtComments.ForeColor = Color.Black;
        }
        protected void TxtComments_SetText()
        {
            this.txtComments.Text = "Poznámka";
            lblCharCounterForTxtComment.Text = "0/250";
            txtComments.ForeColor = Color.Gray;
        }
        #endregion

        private void TxtComments_TextChanged(object sender, EventArgs e)
        {
            if (txtComments.ForeColor == Color.Black)
            {
                lblCharCounterForTxtComment.Text = txtComments.Text.Length + "/250";
            }
        }

        private void AfterButtonClick()//graphics page after button click
        {
            if (DisplayMode == "view")
            {
                lblActualMode.Text = "Prohlížení";
                pnlUserPassComment.Show();
                btnSpectate.BackColor = Color.FromArgb(28, 188, 172);
                btnEdit.BackColor = Color.Turquoise;
                btnADD.BackColor = Color.Turquoise;
                btnDelete.BackColor = Color.DarkSalmon;
                btnCopyPass.Show();
                btnGen.Hide();
                btnEvent.Hide();


            }
            else if (DisplayMode == "create")
            {
                lblActualMode.Text = "Nový";
                pnlUserPassComment.Show();
                btnADD.BackColor = Color.FromArgb(28, 188, 172);
                btnEdit.BackColor = Color.Turquoise;
                btnSpectate.BackColor = Color.Turquoise;
                btnDelete.BackColor = Color.DarkSalmon;
                btnCopyPass.Hide();
                btnGen.Show();
                btnEvent.Text = "Přidat";
                btnEvent.Show();
            }
            else if (DisplayMode == "edit")
            {
                lblActualMode.Text = "Upravit";
                pnlUserPassComment.Show();
                btnEdit.BackColor = Color.FromArgb(28, 188, 172);
                btnSpectate.BackColor = Color.Turquoise;
                btnADD.BackColor = Color.Turquoise;
                btnDelete.BackColor = Color.DarkSalmon;
                btnCopyPass.Hide();
                btnGen.Show();
                btnEvent.Text = "Upravit";
                btnEvent.Show();

            }
            else if (DisplayMode == "delete")
            {
                lblActualMode.Text = "";
                pnlUserPassComment.Hide();
                btnDelete.BackColor = Color.FromArgb(198, 115, 87);
                btnEdit.BackColor = Color.Turquoise;
                btnADD.BackColor = Color.Turquoise;
                btnSpectate.BackColor = Color.Turquoise;

            }
            TxtUsername_SetText();
            TxtPass_SetText();
            TxtComments_SetText();
        }
        private void PullForm_Load(object sender, EventArgs e)
        {
            lblHelloMoment.Text = "Hi, " + username + "!";
            DisplayMode = "view";
            Textboxes_Load();
            FuncDisplayMode();
            PageDesign();
        }
        private void PullForm_Resize(object sender, EventArgs e)
        {
            PageDesign();
        }
        #endregion

        #region LogOut/Close Form
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
