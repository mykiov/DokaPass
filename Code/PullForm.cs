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
    public partial class PullForm : Form
    {
        string key;
        public PullForm(string key)
        {
            InitializeComponent();
            this.key = key;
        }

        private void PullForm_Load(object sender, EventArgs e)
        {
            
        }

        private void PullForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms[0].Name == "Form1") Application.OpenForms[0].Show();
            this.Hide();
        }
    }
}
