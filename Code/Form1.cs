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

        #region
        generation key;
        #endregion

        #region Forms
        #endregion

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            LogInForm loginForm = new DokaPass.LogInForm();
            loginForm.Show();
            this.Hide();
        }

        private void BtnNewAcc_Click(object sender, EventArgs e)
        {
            NewAccForm newAccForm = new DokaPass.NewAccForm();
            newAccForm.Show();
            this.Hide();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            key = new generation();
            txttest.Text = key.generate(true, true, true, true, 25);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
