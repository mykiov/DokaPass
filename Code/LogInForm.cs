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
        public LogInForm()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            string accsPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\accs";
            string binPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\bin";

            if(File.Exists(accsPath+"\\"+txtUsername.Text+".csv"))
            {
                StreamReader strmReadAcc = new StreamReader(accsPath+"\\"+txtUsername.Text+".csv");
                string[] accFile = new string[3];
                accFile[0] = strmReadAcc.ReadLine().ToString();
                accFile[1] = strmReadAcc.ReadLine().ToString();
                accFile[2] = strmReadAcc.ReadLine().ToString();
                strmReadAcc.Close();

                string name = accFile[0];
                string pin = accFile[1];
                string key = accFile[2];

                if(pin == txtPIN.Text)
                {
                    if(File.Exists(binPath + "\\" + key + ".csv"))
                    {
                        PullForm pullForm = new DokaPass.PullForm(key);
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
            if (Application.OpenForms[0].Name == "Form1") Application.OpenForms[0].Show();
            this.Hide();
        }
    }
}
