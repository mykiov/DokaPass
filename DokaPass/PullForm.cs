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
using System.Windows;

namespace DokaPass
{
    public partial class PullForm : Form
    {
        public PullForm(string key, string cryptoAccKey, string cryptoBinKey, string username, int width, int height, int x, int y)
        {
            InitializeComponent();
            this.key = key;
            this.username = username;
            this.Width = width;
            this.Height = height;
            this.Location = new Point(x, y);
            this.cryptoAccKey = cryptoAccKey;
            this.cryptoBinKey = cryptoBinKey;
        }

        #region deklarace
        string key, username;
        string DisplayMode;// is for change mode between view, create, edit  delete
        int actualCell;
        string cryptoAccKey, cryptoBinKey;
        #endregion

        #region DataGridView

        private void DataGridView_Refresh()
        {
            List<string> dtgridViewData = new List<string>();
            dtGridView.Rows.Clear();
            dtGridView.ColumnCount = 4;
            dtGridView.Columns[0].Name = "Název:";
            dtGridView.Columns[1].Name = "Username:";
            dtGridView.Columns[2].Name = "Heslo:";
            dtGridView.Columns[3].Name = "Poznámka:";


            string binPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\bin";

            DirectoryInfo dd = new DirectoryInfo(binPath+"\\" + key); //vezme data z direktorie
            DirectoryInfo[] Folders = dd.GetDirectories(); //Getting all folders
            dtGridView.Rows.Clear();
            for (int i = 0; i<Folders.Count(); i++)
            {
                DirectoryInfo df = new DirectoryInfo(binPath + "\\" + key + "\\" + Folders[i]); //vezme data z direktorie
                FileInfo[] Files = df.GetFiles("*.dll"); //Getting all .dll folders
                if(Files.Count() >= 1)
                {
                    string[] contentSouboru = new string[4];

                    for (int j = 0; j < Files.Count(); j++)
                    {
                        switch (Files[j].ToString())
                        {
                            case "1.dll":
                                StreamReader strmR1 = new StreamReader(binPath + "\\" + key + "\\" + Folders[i] + "\\" + Files[j].ToString());
                                string data1 = null;
                                data1 = strmR1.ReadToEnd();
                                if (data1 != "" || data1 != " ")
                                {
                                    contentSouboru[0] = Crypter.Decrypt(data1, cryptoBinKey);
                                }
                                else contentSouboru[0] = "";
                                strmR1.Close();
                                break;

                            case "2.dll":
                                StreamReader strmR2 = new StreamReader(binPath + "\\" + key + "\\" + Folders[i] + "\\" + Files[j].ToString());
                                string data2 = null;
                                data2 = strmR2.ReadToEnd();
                                if (data2 != "" || data2 != " ")
                                {
                                    contentSouboru[1] = Crypter.Decrypt(data2, cryptoBinKey);
                                }
                                else contentSouboru[1] = "";
                                strmR2.Close();
                                break;

                            case "3.dll":
                                StreamReader strmR3 = new StreamReader(binPath + "\\" + key + "\\" + Folders[i] + "\\" + Files[j].ToString());
                                string data3 = null;
                                data3 = strmR3.ReadToEnd();
                                if (data3 != "" || data3 != " ")
                                {
                                    contentSouboru[2] = Crypter.Decrypt(data3, cryptoBinKey);
                                }
                                else contentSouboru[2] = "";
                                strmR3.Close();
                                break;

                            case "4.dll":
                                StreamReader strmR4 = new StreamReader(binPath + "\\" + key + "\\" + Folders[i] + "\\" + Files[j].ToString());
                                string data4 = null;
                                data4 = strmR4.ReadToEnd();
                                if (data4 != "" || data4 != " ")
                                {
                                    contentSouboru[3] = Crypter.Decrypt(data4, cryptoBinKey);
                                }
                                else contentSouboru[3] = "";
                                strmR4.Close();
                                break;
                        }
                    }
                    try
                    {
                        if ((contentSouboru[0] != "" && contentSouboru[0] != " ") && (contentSouboru[1] != "" && contentSouboru[1] != " ") && (contentSouboru[2] != "" && contentSouboru[2] != " ") && (contentSouboru[3] != "" && contentSouboru[3] != " "))
                        {
                            dtGridView.Rows.Add(contentSouboru[0], contentSouboru[1], contentSouboru[2], contentSouboru[3]);
                        }
                    }
                    catch { }
                }
            }
            dtGridView.Refresh();
            textbox_fill();
        }

        private void DataGridView_Edit()
        {
            string binPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\bin";

            if (dtGridView.SelectedRows == null) MessageBox.Show("Nelze nic upravit");
            else
            {

                foreach (DataGridViewRow row in dtGridView.SelectedRows)
                {
                    DirectoryInfo di = new DirectoryInfo(binPath + "\\" + key); //vezme data z direktorie
                    DirectoryInfo[] folders = di.GetDirectories();

                    if (txtWebPageName.Text == "")txtWebPageName.Text = " ";
                    for(int i = 0; i <= dtGridView.RowCount; i++)
                    {
                        if (row.Index == i)
                        {
                            StreamWriter strmUprava = new StreamWriter(binPath + "\\" + key + "\\" + (i + 1).ToString() + "\\" + (1).ToString() + ".dll");
                            strmUprava.Write(Crypter.Encrypt(txtWebPageName.Text, cryptoBinKey));
                            strmUprava.Close();
                        }
                    }

                    if (txtUsername.Text == "") txtUsername.Text = " ";
                    for (int i = 0; i <= dtGridView.RowCount; i++)
                    {
                        if (row.Index == i)
                        {
                            StreamWriter strmUprava = new StreamWriter(binPath + "\\" + key + "\\" + (i + 1).ToString() + "\\" + (2).ToString() + ".dll");
                            strmUprava.Write(Crypter.Encrypt(txtUsername.Text, cryptoBinKey));
                            strmUprava.Close();
                        }
                    }

                    if (txtPass.Text == "") txtPass.Text = " ";
                    for (int i = 0; i <= dtGridView.RowCount; i++)
                    {
                        if (row.Index == i)
                        {
                            StreamWriter strmUprava = new StreamWriter(binPath + "\\" + key + "\\" + (i + 1).ToString() + "\\" + (3).ToString() + ".dll");
                            strmUprava.Write(Crypter.Encrypt(txtPass.Text, cryptoBinKey));
                            strmUprava.Close();
                        }
                    }

                    if (txtComments.Text == "") txtComments.Text = " ";
                    for (int i = 0; i <= dtGridView.RowCount; i++)
                    {
                        if (row.Index == i)
                        {
                            StreamWriter strmUprava = new StreamWriter(binPath + "\\" + key + "\\" + (i + 1).ToString() + "\\" + (4).ToString() + ".dll");
                            strmUprava.Write(Crypter.Encrypt(txtComments.Text, cryptoBinKey));
                            strmUprava.Close();
                        }
                    }
                }
                DisplayMode = "view";
                AfterButtonClick();
            }
        }

        private void DataGridView_Upload()
        {
            if (txtWebPageName.ForeColor == Color.Gray && txtUsername.ForeColor == Color.Gray && txtPass.ForeColor == Color.Gray && txtComments.ForeColor == Color.Gray) MessageBox.Show("Zadej data!");
            else
            {
                if (txtWebPageName.ForeColor == Color.Gray) txtWebPageName.Text = "";
                if (txtUsername.ForeColor == Color.Gray) txtUsername.Text = "";
                if (txtPass.ForeColor == Color.Gray) txtPass.Text = "";
                if (txtComments.ForeColor == Color.Gray) txtComments.Text = "";
                dtGridView.Rows.Add(txtWebPageName.Text, txtUsername.Text, txtPass.Text, txtComments.Text);


                //////////////////////////////////////////////////////////// ulozeni z datagrid do souboru
                string binPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\bin";

                for (int i = 0; i < dtGridView.RowCount; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        switch (j)
                        {
                            case 0:
                                if (!Directory.Exists(binPath + "\\" + key + "\\" + (i + 1).ToString())) Directory.CreateDirectory(binPath + "\\" + key + "\\" + (i + 1).ToString()); //jestli neexistuje slozka
                                StreamWriter strmZapis1 = new StreamWriter(binPath + "\\" + key + "\\" + (i + 1).ToString() + "\\" + (j + 1).ToString() + ".dll");
                                strmZapis1.Write(Crypter.Encrypt(dtGridView.Rows[i].Cells[0].Value.ToString(), cryptoBinKey));
                                strmZapis1.Close();
                                break;
                            case 1:
                                if (!Directory.Exists(binPath + "\\" + key + "\\" + (i + 1).ToString())) Directory.CreateDirectory(binPath + "\\" + key + "\\" + (i + 1).ToString()); //jestli neexistuje slozka
                                StreamWriter strmZapis2 = new StreamWriter(binPath + "\\" + key + "\\" + (i + 1).ToString() + "\\" + (j + 1).ToString() + ".dll");
                                strmZapis2.Write(Crypter.Encrypt(dtGridView.Rows[i].Cells[1].Value.ToString(), cryptoBinKey));
                                strmZapis2.Close();
                                break;
                            case 2:
                                if (!Directory.Exists(binPath + "\\" + key + "\\" + (i + 1).ToString())) Directory.CreateDirectory(binPath + "\\" + key + "\\" + (i + 1).ToString()); //jestli neexistuje slozka
                                StreamWriter strmZapis3 = new StreamWriter(binPath + "\\" + key + "\\" + (i + 1).ToString() + "\\" + (j + 1).ToString() + ".dll");
                                strmZapis3.Write(Crypter.Encrypt(dtGridView.Rows[i].Cells[2].Value.ToString(), cryptoBinKey));
                                strmZapis3.Close();
                                break;
                            case 3:
                                if (!Directory.Exists(binPath + "\\" + key + "\\" + (i + 1).ToString())) Directory.CreateDirectory(binPath + "\\" + key + "\\" + (i + 1).ToString()); //jestli neexistuje slozka
                                StreamWriter strmZapis4 = new StreamWriter(binPath + "\\" + key + "\\" + (i + 1).ToString() + "\\" + (j + 1).ToString() + ".dll");
                                strmZapis4.Write(Crypter.Encrypt(dtGridView.Rows[i].Cells[3].Value.ToString(), cryptoBinKey));
                                strmZapis4.Close();
                                break;
                        }
                    }
                }
                DisplayMode = "view";
                AfterButtonClick();
            }
        }
        #endregion

        #region Buttons
        #region btnEvent - one button with more implementation
        private void BtnEvent_Click(object sender, EventArgs e)
        {
            BtnEventImplementation();
        }
        private void BtnEventImplementation()
        {
            if (DisplayMode == "create")
            {
                DataGridView_Upload();
            }
            else if (DisplayMode == "edit")
            {
                DataGridView_Edit();
            }
            DataGridView_Refresh();
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


        private void BtnCopyUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Jméno" || txtUsername.Text == "" || txtUsername.Text == null || txtUsername.Text == " " || txtUsername.ForeColor == Color.Gray)
            {
                MessageBox.Show("Nelze, nejsou data");
            }
            else
            {
                try
                {
                    Clipboard.SetText(txtUsername.Text);
                    MessageBox.Show(txtUsername.Text + " je uložen do clipboardu.");
                }
                catch { }
            }
        }

        private void BtnCopyPass_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "Heslo" || txtPass.Text == "" || txtPass.Text == null || txtPass.Text == " " || txtPass.ForeColor == Color.Gray)
            {
                MessageBox.Show("Nelze, nejsou data");
            }
            else
            {
                try
                {
                    Clipboard.SetText(txtPass.Text);
                    MessageBox.Show(txtPass.Text + " je uložen do clipboardu.");
                }
                catch { }
            }
        }

        private void BtnGen_Click(object sender, EventArgs e)
        {
            using (PassGenerateForm gnrForm = new PassGenerateForm())
            {
                if (gnrForm.ShowDialog() == DialogResult.OK)
                {
                    txtPass.Text = gnrForm.TheValue;
                    txtPass.ForeColor = Color.Black;
                }
            }
        }

        private void BtnADD_Click(object sender, EventArgs e)
        {
            DisplayMode = "create";
            AfterButtonClick();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DisplayMode = "edit";
            AfterButtonClick();
        }

        private void BtnSpectate_Click(object sender, EventArgs e)
        {
            DisplayMode = "view";
            AfterButtonClick();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtGridView.SelectedRows)
            {
                DialogResult msgbx = MessageBox.Show("Chcete odstránít řádek?", "", MessageBoxButtons.YesNo);
                if (msgbx == DialogResult.Yes)
                {
                    
                    string binPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\bin";
                    DirectoryInfo di = new DirectoryInfo(binPath + "\\" + key); //vezme data z direktorie
                    DirectoryInfo[] folders = di.GetDirectories();
                    for (int i = 0; i<folders.Count();i++)
                    {
                        if(i == row.Index)
                        {
                            DirectoryInfo dd = new DirectoryInfo(binPath + "\\" + key + "\\" + folders[i]);
                            foreach (FileInfo file in dd.GetFiles())
                            {
                                file.Delete();
                            }
                            folders[i].Delete(true);

                            if(folders.Count() <= 1)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    switch (j)
                                    {
                                        case 0:
                                            if (!Directory.Exists(binPath + "\\" + key + "\\" + (i + 1).ToString())) Directory.CreateDirectory(binPath + "\\" + key + "\\" + (i + 1).ToString()); //jestli neexistuje slozka
                                            StreamWriter strmZapis1 = new StreamWriter(binPath + "\\" + key + "\\" + (i + 1).ToString() + "\\" + (j + 1).ToString() + ".dll");
                                            strmZapis1.Write(Crypter.Encrypt((" "), cryptoBinKey));
                                            strmZapis1.Close();
                                            break;
                                        case 1:
                                            if (!Directory.Exists(binPath + "\\" + key + "\\" + (i + 1).ToString())) Directory.CreateDirectory(binPath + "\\" + key + "\\" + (i + 1).ToString()); //jestli neexistuje slozka
                                            StreamWriter strmZapis2 = new StreamWriter(binPath + "\\" + key + "\\" + (i + 1).ToString() + "\\" + (j + 1).ToString() + ".dll");
                                            strmZapis2.Write(Crypter.Encrypt((" "), cryptoBinKey));
                                            strmZapis2.Close();
                                            break;
                                        case 2:
                                            if (!Directory.Exists(binPath + "\\" + key + "\\" + (i + 1).ToString())) Directory.CreateDirectory(binPath + "\\" + key + "\\" + (i + 1).ToString()); //jestli neexistuje slozka
                                            StreamWriter strmZapis3 = new StreamWriter(binPath + "\\" + key + "\\" + (i + 1).ToString() + "\\" + (j + 1).ToString() + ".dll");
                                            strmZapis3.Write(Crypter.Encrypt((" "), cryptoBinKey));
                                            strmZapis3.Close();
                                            break;
                                        case 3:
                                            if (!Directory.Exists(binPath + "\\" + key + "\\" + (i + 1).ToString())) Directory.CreateDirectory(binPath + "\\" + key + "\\" + (i + 1).ToString()); //jestli neexistuje slozka
                                            StreamWriter strmZapis4 = new StreamWriter(binPath + "\\" + key + "\\" + (i + 1).ToString() + "\\" + (j + 1).ToString() + ".dll");
                                            strmZapis4.Write(Crypter.Encrypt((" "), cryptoBinKey));
                                            strmZapis4.Close();
                                            break;
                                    }
                                }
                            }
                        }
                    }
                    
                    dtGridView.Refresh();
                    DataGridView_Refresh();

                    TxtName_SetText();
                    TxtPass_SetText();
                    TxtUsername_SetText();
                    TxtComments_SetText();
                }
            }
        }


        private void AfterButtonClick()//graphics page after button click
        {
            if (DisplayMode == "view")
            {
                lblActualMode.Text = "Prohlížení";
                pnlUserPassComment.Show();
                btnSpectate.BackColor = Color.FromArgb(72, 143, 172);
                btnEdit.BackColor = Color.SkyBlue;
                btnADD.BackColor = Color.SkyBlue;
                btnDelete.BackColor = Color.DarkSalmon;
                btnCopyPass.Show();
                btnGen.Hide();
                btnEvent.Hide();
                txtWebPageName.ReadOnly = true;
                txtUsername.ReadOnly = true;
                txtPass.ReadOnly = true;
                txtComments.ReadOnly = true;

            }
            else if (DisplayMode == "create")
            {
                lblActualMode.Text = "Nový";
                pnlUserPassComment.Show();
                btnADD.BackColor = Color.FromArgb(72, 143, 172);
                btnEdit.BackColor = Color.SkyBlue;
                btnSpectate.BackColor = Color.SkyBlue;
                btnDelete.BackColor = Color.DarkSalmon;
                btnCopyPass.Hide();
                btnGen.Show();
                btnEvent.Text = "Přidat";
                btnEvent.Show();
                txtWebPageName.ReadOnly = false;
                txtUsername.ReadOnly = false;
                txtPass.ReadOnly = false;
                txtComments.ReadOnly = false;
            }
            else if (DisplayMode == "edit")
            {
                lblActualMode.Text = "Upravit";
                pnlUserPassComment.Show();
                btnEdit.BackColor = Color.FromArgb(72, 143, 172);
                btnSpectate.BackColor = Color.SkyBlue;
                btnADD.BackColor = Color.SkyBlue;
                btnDelete.BackColor = Color.DarkSalmon;
                btnCopyPass.Hide();
                btnGen.Show();
                btnEvent.Text = "Upravit";
                btnEvent.Show();
                txtWebPageName.ReadOnly = false;
                txtUsername.ReadOnly = false;
                txtPass.ReadOnly = false;
                txtComments.ReadOnly = false;

            }
            TxtName_SetText();
            TxtUsername_SetText();
            TxtPass_SetText();
            TxtComments_SetText();
            DataGridView_Refresh();
        }

        #endregion

        #region PAGE_DESIGN //// ONLY DESIGN // for transformable design
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
            //left pnl
            pnlDataGridView.Width = this.Width - pnlUserPassComment.Width;
            //username
            txtUsername.Size = new Size(pnlUserPassComment.Width / 2, 40);
            txtUsername.Location = new Point(pnlUserPassComment.Width / 2 - pnlUserPassComment.Width / 4, pnlUserPassComment.Height / 2 - pnlUserPassComment.Height / 4);
            btnCopyUsername.Size = new Size(txtUsername.Height, txtUsername.Height);
            btnCopyUsername.Location = new Point(txtUsername.Location.X + 5 + txtUsername.Width, txtUsername.Location.Y);
            //Data Name
            txtWebPageName.Size = new Size(txtUsername.Width, txtUsername.Height);
            txtWebPageName.Location = new Point(txtUsername.Location.X, txtUsername.Location.Y-txtWebPageName.Height-5);
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
        private void TxtComments_TextChanged(object sender, EventArgs e)
        {
            if (txtComments.ForeColor == Color.Black)
            {
                lblCharCounterForTxtComment.Text = txtComments.Text.Length + "/30";
            }
        }

        #region textbox gray note
        private void Textboxes_Load()
        {
            //load txtName
            this.txtWebPageName.Enter += new EventHandler(TxtName_Enter);
            this.txtWebPageName.Leave += new EventHandler(TxtName_Leave);
            TxtName_SetText();
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

        protected void TxtName_SetText()
        {
            if (DisplayMode == "view" || DisplayMode == "edit")
            {
                if (dtGridView.Rows.Count == 0)
                {
                    this.txtWebPageName.Text = "Název web stránky";
                    txtWebPageName.ForeColor = Color.Gray;
                }
                else textbox_fill();
            }
            else
            {
                this.txtWebPageName.Text = "Název";
                txtWebPageName.ForeColor = Color.Gray;
            }
        }
        private void TxtName_Leave(object sender, EventArgs e)
        {
            if (txtWebPageName.Text.Trim() == "") TxtName_SetText();
        }
        private void TxtName_Enter(object sender, EventArgs e)
        {
            if (txtWebPageName.ForeColor == Color.Black) return;
            txtWebPageName.Text = "";
            txtWebPageName.ForeColor = Color.Black;
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
            if (DisplayMode == "view" || DisplayMode == "edit")
            {
                if (dtGridView.Rows.Count == 0)
                {
                    this.txtUsername.Text = "Jméno";
                    txtUsername.ForeColor = Color.Gray;
                }
                else textbox_fill();
            }
            else
            {
                this.txtUsername.Text = "Jméno";
                txtUsername.ForeColor = Color.Gray;
            }
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
            if (DisplayMode == "view" || DisplayMode == "edit")
            {
                if (dtGridView.Rows.Count == 0)
                {
                    this.txtPass.Text = "Heslo";
                    txtPass.ForeColor = Color.Gray;
                }
                else textbox_fill();
            }
            else
            {
                this.txtPass.Text = "Heslo";
                txtPass.ForeColor = Color.Gray;
            }
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
            if (DisplayMode == "view" || DisplayMode == "edit")
            {
                if (dtGridView.Rows.Count == 0)
                {
                    this.txtComments.Text = "Poznámka";
                    lblCharCounterForTxtComment.Text = "0/30";
                    txtComments.ForeColor = Color.Gray;
                }
                else textbox_fill();
            }
            else
            {
                this.txtComments.Text = "Poznámka";
                lblCharCounterForTxtComment.Text = "0/30";
                txtComments.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region textboxes filling
        private void textbox_fill()
        {
            if (DisplayMode == "view" || DisplayMode == "edit")
            {
                foreach (DataGridViewRow row in dtGridView.SelectedRows)
                {
                    try { txtWebPageName.Text = row.Cells[0].Value.ToString(); }
                    catch { txtWebPageName.Text = ""; }

                    try { txtUsername.Text = row.Cells[1].Value.ToString(); }
                    catch { txtUsername.Text = "";}

                    try { txtPass.Text = row.Cells[2].Value.ToString(); }
                    catch { txtPass.Text = ""; }

                    try {
                        txtComments.Text = row.Cells[3].Value.ToString();
                        lblCharCounterForTxtComment.Text = row.Cells[3].Value.ToString().Count() + "/30";
                    }
                    catch { txtComments.Text = ""; }

                    txtWebPageName.ForeColor = Color.Black;
                    txtUsername.ForeColor = Color.Black;
                    txtPass.ForeColor = Color.Black;
                    txtComments.ForeColor = Color.Black;
                }
            }
        }
        #endregion
        private void PullForm_Load(object sender, EventArgs e)
        {
            lblHelloMoment.Text = "Ahoj, " + username + "!";
            DisplayMode = "view";
            actualCell = 0;
            Textboxes_Load();
            TxtComments_SetText();
            AfterButtonClick();
            PageDesign();
        }
        private void PullForm_Resize(object sender, EventArgs e)
        {
            PageDesign();
        }
        #endregion


        private void DtGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textbox_fill();
        }
    }
}
