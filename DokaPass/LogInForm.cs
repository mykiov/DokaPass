using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace DokaPass
{
    public partial class LogInForm : Form
    {
        public LogInForm(int width, int height, int x, int y)
        {
            InitializeComponent();
            this.Width = width;
            this.Height = height;
            this.Location = new Point(x,y);
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            //cesta do slozek
            string accsPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\accs";
            string binPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\bin";

            string decryptedContent = null;

            if (File.Exists(accsPath+"\\"+txtUsername.Text+ ".dll"))
            {
                StreamReader strmReadAcc = new StreamReader(accsPath+"\\"+txtUsername.Text+ ".dll");
                decryptedContent = Crypter.Decrypt(strmReadAcc.ReadToEnd());//rozsifruje

                string[] accFile = new string[3];
                accFile[0] = decryptedContent.Split(';')[0];
                accFile[1] = decryptedContent.Split(';')[1];
                accFile[2] = decryptedContent.Split(';')[2];
                strmReadAcc.Close(); 

                string name = accFile[0];
                string pin = accFile[1];
                string key = accFile[2];

                if(pin == txtPIN.Text)
                {
                    if(File.Exists(binPath + "\\" + key + ".dll"))
                    {
                        PullForm pullForm = new DokaPass.PullForm(key, txtUsername.Text, this.Width, this.Height, this.Location.X, this.Location.Y);
                        pullForm.Show();
                        txtPIN.Text = "";
                        txtUsername.Text = "";
                        if (Application.OpenForms[0].Name == "Form1") Application.OpenForms[0].Hide();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Data s heslama jsou utrácené");
                    }
                }
                else
                {
                    MessageBox.Show("Špatný pin");
                    txtPIN.Text = "";
                }
            }
            else
            {
                MessageBox.Show(txtUsername.Text + " neexistuje, zadejte správně jméno. :(");
                txtPIN.Text = "";
                txtUsername.Text = "";
            }
        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Close();
            Application.Exit();
        }

        private void BtnZpet_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[0].Name == "Form1") Application.OpenForms[0].Show();
            this.Hide();
        }



        #region DESIGN_PAGE
        private void PageDesign()
        {
            this.MinimumSize = new System.Drawing.Size(760, 600);

            //fonts
            lblHeader.Font = new Font(lblHeader.Font.FontFamily, 20);
            btnLogIn.Font = new Font(btnLogIn.Font.FontFamily, 13);

            //top
            pnlTop.Height = (Screen.PrimaryScreen.Bounds.Height / 100) * 10;
            lblHeader.Location = new Point(this.Width / 2 - 3 * 25, pnlTop.Height / 2 - 25 / 2);//   /2(center)   -4(words)    25(= 20pt to px)
            btnZpet.Width = 60;

            //body
            btnLogIn.Size = new Size(this.Width / 2, 50);
            txtUsername.Size = new Size(this.Width/2-2, 25);
            txtPIN.Size = new Size(this.Width/2 - 2, 25);
            txtUsername.Location = new Point(1, grpUsername.Height / 2 - 2);
            txtPIN.Location = new Point(1, grpPIN.Height / 2 - 2);
            grpPIN.Size = new Size(this.Width / 2, txtPIN.Location.Y + 5 + txtPIN.Height);
            grpUsername.Size = new Size(this.Width / 2, txtUsername.Location.Y + 5 + txtUsername.Height);

            grpUsername.Location = new Point(this.Width / 4, this.Height / 100 * 30);
            grpPIN.Location = new Point(grpUsername.Location.X, grpUsername.Location.Y + 15 + grpUsername.Height);
            btnLogIn.Location = new Point(grpPIN.Location.X, grpPIN.Location.Y + 15 + grpPIN.Height);

        }


        private void LogInForm_Load(object sender, EventArgs e)
        {
            PageDesign();
        }

        private void LogInForm_Resize(object sender, EventArgs e)
        {
            PageDesign();
        }
        #endregion
    }
}
