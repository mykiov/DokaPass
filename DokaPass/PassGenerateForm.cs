using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DokaPass
{
    public partial class PassGenerateForm : Form
    {
        public PassGenerateForm()
        {
            InitializeComponent();
        }

        int delka;
        string heslo;

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            switch (trackBar1.Value)
            {
                case 0:
                    delka = 4;
                    break;
                case 1:
                    delka = 8;
                    break;
                case 2:
                    delka = 12;
                    break;
                case 3:
                    delka = 16;
                    break;
                case 4:
                    delka = 20;
                    break;
                case 5:
                    delka = 24;
                    break;
                case 6:
                    delka = 28;
                    break;
                case 7:
                    delka = 32;
                    break;
                case 8:
                    delka = 64;
                    break;
                case 9:
                    delka = 96;
                    break;
                case 10:
                    delka = 128;
                    break;
            }
            lblDelkaHesla.Text = delka.ToString();
        }

        private void BtnGenerovat_Click(object sender, EventArgs e)
        {
            if (chkMalaPismena.Checked == false && chkVelkaPismena.Checked == false && chkSymboly.Checked == false && chkCisla.Checked == false) MessageBox.Show("Chyba, zvol si něco");
            else
            {
                generation gen = new generation();
                heslo = gen.generate(chkMalaPismena.Checked, chkVelkaPismena.Checked, chkCisla.Checked, chkSymboly.Checked, delka);
                DialogResult = DialogResult.OK;
            }
        }

        public string TheValue
        {
            get { return heslo; }
        }

        private void PassGenerateForm_Load(object sender, EventArgs e)
        {
            heslo = "";
            delka = 4;
            chkMalaPismena.Checked = true;
            chkVelkaPismena.Checked = true;
            chkCisla.Checked = true;
            chkSymboly.Checked = true;
        }
    }
}
