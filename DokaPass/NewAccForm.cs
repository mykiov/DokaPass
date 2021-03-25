using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Security.Cryptography;

namespace DokaPass
{
    public partial class NewAccForm : Form
    {
        public NewAccForm(int width, int height, int x, int y)
        {
            InitializeComponent();
            this.Width = width;
            this.Height = height;
            this.Location = new Point(x,y);
        }

        string key;
        generate k;
        int delka;

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if(lblInfoMinimumChars.ForeColor == System.Drawing.Color.Green && lblnfoPIN.ForeColor == System.Drawing.Color.Green && lblInfoVerifyPIN.ForeColor == System.Drawing.Color.Green)
            {
                k = new generate();
                key = k.gen(true,true,true,true,25);//generate key
                NewAcc(txtUsername.Text,txtPIN.Text,key);
            }
        }
        private void NewAcc(string name, string pin, string key)//create new acc
        {
            string res, textToEncrypt;
            string cryptoAccKey = null;
            string cryptoBinKey = null;
            DialogResult dialogResult = MessageBox.Show("Jméno: " + name + Environment.NewLine + "PIN: " + pin + Environment.NewLine + "Správně?", "Ověření", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                string accsPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\accs";
                string binPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\bin";

                if (!Directory.Exists(binPath))// jestli existuje slozka bin
                {
                    Directory.CreateDirectory(binPath);//vytvorit
                }
                if (!Directory.Exists(accsPath))// jestli existuje slozka s uzivateli
                {
                    Directory.CreateDirectory(accsPath);//vytvorit
                }

                if (!File.Exists(accsPath + "\\key.xml"))//vytvori klic pro spravu uctu
                {
                    RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

                    StreamWriter SaveKey = new StreamWriter(accsPath + "\\key.xml");
                    SaveKey.Write(cryptoAccKey = (RSA.ToXmlString(true)));
                    SaveKey.Close();
                }
                else//nebo precte pokud ma
                {
                    try
                    {
                        RSACryptoServiceProvider RSAacc = new RSACryptoServiceProvider();

                        StreamReader OpenKey = new StreamReader(accsPath + "\\key.xml");
                        cryptoAccKey = OpenKey.ReadToEnd();
                        OpenKey.Close();
                        RSAacc.FromXmlString(cryptoAccKey);
                    }
                    catch//pokud precte a bude v key.xml chyba
                    {
                        MessageBox.Show("Chyba v souboru: " + accsPath + "\\key.xml");

                        Application.OpenForms[0].Show();
                        this.Hide();
                    }
                }

                if (!File.Exists(accsPath + "\\" + name + ".dll"))//zda neexistuje soubor s takovym uctem
                {
                    res = "";
                    textToEncrypt = name + ";" + pin + ";" + key;
                    res = Crypter.Encrypt(textToEncrypt, cryptoAccKey);//zasifruje

                    StreamWriter strmAccWrite = new StreamWriter(accsPath + "\\" + name + ".dll");
                    strmAccWrite.Write(res);
                    strmAccWrite.Close();

                    while (true)
                    {
                        if (!Directory.Exists(binPath + "\\" + key + "\\"))//zepta se jestli je slozka a soubor pro ulozeni dat
                        {
                            Directory.CreateDirectory(binPath + "\\" + key + "\\");//vytvori se direktorie

                            #region ziskani klice cryptoBinKey
                            if (!File.Exists(binPath + "\\" + key + "\\" + "key.xml"))//vytvori se unikatni klic pro slozku s hesly
                            {
                                Directory.CreateDirectory(binPath + "\\" + key);
                                RSACryptoServiceProvider RSAbin = new RSACryptoServiceProvider();

                                StreamWriter SaveKey = new StreamWriter(binPath + "\\" + key + "\\" + "key.xml");
                                SaveKey.Write(cryptoBinKey = (RSAbin.ToXmlString(true)));
                                SaveKey.Close();
                            }
                            else
                            {
                                try
                                {
                                    RSACryptoServiceProvider RSAbin = new RSACryptoServiceProvider();

                                    StreamReader OpenKey = new StreamReader(binPath + "\\" + key + "\\" + "key.xml");
                                    cryptoBinKey = OpenKey.ReadToEnd();
                                    OpenKey.Close();
                                    RSAbin.FromXmlString(cryptoAccKey);
                                }
                                catch//pokud precte a bude v key.xml chyba
                                {
                                    MessageBox.Show("Chyba v souboru: " + binPath + "\\" + key + "\\" + "key.xml");

                                    Application.OpenForms[0].Show();
                                    this.Hide();
                                }
                            }
                            #endregion

                            Directory.CreateDirectory(binPath + "\\" + key + "\\" + "1");//vytvori se direktorie

                            string[] data = new string[] { " ", " ", " ", " "};
                            for (int i = 0; i<4; i++)
                            {
                                StreamWriter strmBinWrite = new StreamWriter(binPath + "\\" + key + "\\1\\" + (i+1).ToString() + ".dll");
                                strmBinWrite.Write(Crypter.Encrypt(data[i], cryptoBinKey));
                                strmBinWrite.Close();
                            }

                            StreamWriter strmAccWrite2 = new StreamWriter(accsPath + "\\" + name + ".dll");
                            res = "";
                            textToEncrypt = name + ";" + pin + ";" + key;
                            res = Crypter.Encrypt(textToEncrypt, cryptoAccKey);
                            strmAccWrite2.Write(res);
                            strmAccWrite2.Close();


                            MessageBox.Show("Účet je vytvořen :)");
                            if (Application.OpenForms[0].Name == "Form1") Application.OpenForms[0].Show();
                            this.Hide();
                            break;
                        }
                        else
                        {
                            k = new generate();
                            key = k.gen(true, true, true, true, 25);
                        }
                    }
                }
                else MessageBox.Show("Účet jíž existuje, vytvořte jiný");
            }

            else if(dialogResult == DialogResult.No)
            {
                txtPIN.Text = "";
                txtUsername.Text = "";
                txtVerifyPIN.Text = "";
                txtPIN.ForeColor = Color.Red;
                txtVerifyPIN.ForeColor = Color.Red;
                txtUsername.ForeColor = Color.Red;
            }
        }

        //txtbx verify
        #region textbox verify
        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            //osetreni pri spatnym znakum
            if (txtUsername.Text.Length != 0)
            {
                char[] allowedChars = new char[] { 'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e', 'F', 'f', 'G', 'g', 'H', 'h', 'I', 'i', 'J', 'j', 'K', 'k', 'L', 'l', 'M', 'm', 'N', 'n', 'O', 'o', 'P', 'p', 'Q', 'q', 'R', 'r', 'S', 's', 'T', 't', 'U', 'u', 'V', 'v', 'W', 'w', 'X', 'x', 'Y', 'y', 'Z', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                delka = txtUsername.Text.Length;

                for (int i = 0; i < txtUsername.Text.Length; i++)
                {
                    for (int j = 0; j < allowedChars.Length; j++)
                    {
                        if (Convert.ToChar(txtUsername.Text.ElementAt(i))== allowedChars[j])
                        {
                            delka = delka - 1;
                        }
                    }
                }

                if (txtUsername.Text.Length >= 4)
                {
                    if (delka == 0)
                    {
                        lblInfoMinimumChars.ForeColor = Color.Green;
                    }
                    else lblInfoMinimumChars.ForeColor = Color.Red;
                }
                else
                {
                    lblInfoMinimumChars.ForeColor = Color.Red;
                }

            }
        }

        //username

        private void TxtPIN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtPIN.Text.Length) >= 4 && Convert.ToInt32(txtPIN.Text.Length) <= 8)
                {
                    char[] allowedChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                    delka = txtPIN.Text.Length;

                    for (int i = 0; i < txtPIN.Text.Length; i++)
                    {
                        for (int j = 0; j < allowedChars.Length; j++)
                        {
                            if (Convert.ToChar(txtPIN.Text.ElementAt(i)) == allowedChars[j])
                            {
                                delka = delka - 1;
                            }
                        }
                    }

                    if (delka == 0)
                    {
                        lblnfoPIN.ForeColor = Color.Green;
                    }
                    else lblnfoPIN.ForeColor = Color.Red;
                }
                else
                {
                    lblnfoPIN.ForeColor = Color.Red;
                }
            }
            catch
            {

            }
            try
            {
                if (Convert.ToInt32(txtVerifyPIN.Text) == Convert.ToInt32(txtPIN.Text))
                {
                    lblInfoVerifyPIN.Text = "schodné";
                    lblInfoVerifyPIN.ForeColor = Color.Green;
                }
                else
                {
                    lblInfoVerifyPIN.Text = "nejsou schodné";
                    lblInfoVerifyPIN.ForeColor = Color.Red;
                }
            }
            catch
            {

            }
        }//pin

        private void TxtVerifyPIN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtVerifyPIN.Text) == Convert.ToInt32(txtPIN.Text))
                {
                    lblInfoVerifyPIN.Text = "schodné";
                    lblInfoVerifyPIN.ForeColor = Color.Green;
                }
                else
                {
                    lblInfoVerifyPIN.Text = "nejsou schodné";
                    lblInfoVerifyPIN.ForeColor = Color.Red;
                }
            }
            catch
            {}
        }//pin verify
        #endregion


        private void NewAccForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Close();
            Application.Exit();
        }


        //Design
        #region PAGE_DESIGN
        private void PageDesign()
        {
            this.MinimumSize = new System.Drawing.Size(760, 600);

            //fonts
            lblHeader.Font = new Font(lblHeader.Font.FontFamily, 20);
            lblInfoMinimumChars.Font = new Font(lblInfoMinimumChars.Font.FontFamily, 10);
            lblInfoVerifyPIN.Font = new Font(lblInfoVerifyPIN.Font.FontFamily, 10);
            lblnfoPIN.Font = new Font(lblnfoPIN.Font.FontFamily, 10);
            btnCreate.Font = new Font(btnCreate.Font.FontFamily,13);

            //top
            pnlTop.Height = (Screen.PrimaryScreen.Bounds.Height / 100) * 10;
            lblHeader.Location = new Point(this.Width / 2 - 3 * 25, pnlTop.Height / 2 - 25 / 2);//   /2(center)   -4(words)    25(= 20pt to px)
            btnZpet.Width = 60;

            //body
            btnCreate.Size = new Size(this.Width / 2, 50);
            txtUsername.Size = new Size(250,25);
            txtPIN.Size = new Size(250, 25);
            txtVerifyPIN.Size = new Size(250, 25);
            txtUsername.Location = new Point(1,grpUsername.Height/2 - 2);
            lblInfoMinimumChars.Location = new Point(5+txtUsername.Width,txtUsername.Location.Y);
            txtPIN.Location = new Point(txtUsername.Location.X, grpPIN.Height/4-3);
            lblnfoPIN.Location = new Point(5+txtPIN.Width, txtPIN.Location.Y);
            lblDec.Location = new Point(txtPIN.Location.X, 5+txtPIN.Location.Y+txtPIN.Height);
            txtVerifyPIN.Location = new Point(txtPIN.Location.X, 5+lblDec.Location.Y+lblDec.Height);
            lblInfoVerifyPIN.Location = new Point(txtVerifyPIN.Location.X + 5 + txtVerifyPIN.Width, txtVerifyPIN.Location.Y);
            grpPIN.Size = new Size(this.Width/2, txtVerifyPIN.Location.Y+5+txtVerifyPIN.Height);
            grpUsername.Size = new Size(this.Width / 2, txtUsername.Location.Y + 5+txtUsername.Height);

            grpUsername.Location = new Point(this.Width / 4, this.Height / 100 * 15);
            grpPIN.Location = new Point(grpUsername.Location.X, grpUsername.Location.Y + 15 + grpUsername.Height);
            btnCreate.Location = new Point(grpPIN.Location.X, grpPIN.Location.Y + 15 + grpPIN.Height);

        }
        private void NewAccForm_Load(object sender, EventArgs e)
        {
            PageDesign();
        }

        private void NewAccForm_Resize(object sender, EventArgs e)
        {
            PageDesign();
        }
        #endregion

        private void BtnZpet_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[0].Name == "Form1") Application.OpenForms[0].Show();
            this.Hide();
        }
    }
}
