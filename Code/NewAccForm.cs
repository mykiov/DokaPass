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

namespace DokaPass
{
    public partial class NewAccForm : Form
    {
        public NewAccForm()
        {
            InitializeComponent();
        }

        string key;
        generation gen;

        #region forms
        #endregion

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if(lblInfoMinimumChars.ForeColor == System.Drawing.Color.Green && lblnfoPIN.ForeColor == System.Drawing.Color.Green && lblInfoVerifyPIN.ForeColor == System.Drawing.Color.Green)
            {
                gen = new generation();
                key = gen.generate(true,true,true,true,25);//generate key
                NewAcc(txtUsername.Text,txtPIN.Text,key);
            }
        }



        private void NewAcc(string name, string pin, string key)//create new acc
        {
            DialogResult dialogResult = MessageBox.Show("Name: " + name + Environment.NewLine + "PIN: " + pin + Environment.NewLine + "RIGHT?", "Verify", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                string accsPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\accs";
                string binPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\bin";

                if (!Directory.Exists(accsPath))//jestli existuje slozka acc
                {
                    Directory.CreateDirectory(accsPath);//vytvorit
                }
                if (!Directory.Exists(binPath))// jestli existuje slozka bin
                {
                    Directory.CreateDirectory(binPath);//vytvorit
                }

                if (!File.Exists(accsPath + "\\" + name + ".csv"))//zda existuje soubor 
                {
                    StreamWriter strmAccWrite = new StreamWriter(accsPath + "\\" + name + ".csv");
                    strmAccWrite.WriteLine(name);
                    strmAccWrite.WriteLine(pin);
                    strmAccWrite.WriteLine(key);
                    strmAccWrite.Close();

                    if (!File.Exists(binPath + "\\" + key + ".csv"))//zepta se jestli ma unikatni klic
                    {
                        StreamWriter strmBinWrite = new StreamWriter(binPath + "\\" + key + ".csv");
                        strmBinWrite.Write("");
                        strmBinWrite.Close();

                        MessageBox.Show("Účet je vytvořen :)");
                        if (Application.OpenForms[0].Name == "Form1") Application.OpenForms[0].Show();
                        this.Hide();
                    }
                    else
                    {
                        gen = new generation();
                        key = gen.generate(true, true, true, true, 25);

                        StreamWriter strmAccWrite2 = new StreamWriter(accsPath + "\\" + name + ".csv");
                        strmAccWrite2.WriteLine(name);
                        strmAccWrite2.WriteLine(pin);
                        strmAccWrite2.WriteLine(key);
                        strmAccWrite2.Close();

                        StreamWriter strmBinWrite2 = new StreamWriter(binPath + "\\" + key + ".csv");
                        strmBinWrite2.Write("");
                        strmBinWrite2.Close();

                        MessageBox.Show("Účet je vytvořen :)");
                        txtPIN.Text = "";
                        txtVerifyPIN.Text = "";
                        txtUsername.Text = "";
                        lblInfoMinimumChars.ForeColor = Color.Red;
                        lblInfoVerifyPIN.ForeColor = Color.Red;
                        lblnfoPIN.ForeColor = Color.Red;
                        this.Hide();

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



        #region textbox verify
        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length >= 4)
            {
                lblInfoMinimumChars.ForeColor = Color.Green;
            }
            else
            {
                lblInfoMinimumChars.ForeColor = Color.Red;
            }
        }//username

        private void TxtPIN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtPIN.Text.Length) >= 4 && Convert.ToInt32(txtPIN.Text.Length) <= 8)
                {
                    lblnfoPIN.ForeColor = Color.Green;
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
                if (Convert.ToInt32(txtPIN.Text.Length) >= 4 && Convert.ToInt32(txtPIN.Text.Length) <= 8)
                {
                    lblnfoPIN.ForeColor = Color.Green;
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
        }//pin verify
        #endregion

        private void NewAccForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms[0].Name == "Form1") Application.OpenForms[0].Show();
            this.Hide();
        }
    }
}
