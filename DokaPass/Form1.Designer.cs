namespace DokaPass
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnNewAcc = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogIn.Location = new System.Drawing.Point(354, 212);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(249, 40);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Příhlásit se";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            this.btnLogIn.MouseLeave += new System.EventHandler(this.BtnLogIn_MouseLeave);
            this.btnLogIn.MouseHover += new System.EventHandler(this.BtnLogIn_MouseHover);
            // 
            // btnNewAcc
            // 
            this.btnNewAcc.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNewAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewAcc.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewAcc.Location = new System.Drawing.Point(354, 258);
            this.btnNewAcc.Name = "btnNewAcc";
            this.btnNewAcc.Size = new System.Drawing.Size(249, 40);
            this.btnNewAcc.TabIndex = 1;
            this.btnNewAcc.Text = "Nový účet";
            this.btnNewAcc.UseVisualStyleBackColor = false;
            this.btnNewAcc.Click += new System.EventHandler(this.BtnNewAcc_Click);
            this.btnNewAcc.MouseLeave += new System.EventHandler(this.BtnNewAcc_MouseLeave);
            this.btnNewAcc.MouseHover += new System.EventHandler(this.BtnNewAcc_MouseHover);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTop.Controls.Add(this.lblHeader);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(981, 100);
            this.pnlTop.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Helvetica", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(397, 32);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(402, 38);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Doka - Password manager";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 570);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnNewAcc);
            this.Controls.Add(this.btnLogIn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doka - Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnNewAcc;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblHeader;
    }
}

