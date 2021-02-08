namespace DokaPass
{
    partial class LogInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnZpet = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpUsername = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.grpPIN = new System.Windows.Forms.GroupBox();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpUsername.SuspendLayout();
            this.grpPIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.btnZpet);
            this.pnlTop.Controls.Add(this.lblHeader);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 84);
            this.pnlTop.TabIndex = 0;
            // 
            // btnZpet
            // 
            this.btnZpet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnZpet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZpet.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZpet.ForeColor = System.Drawing.Color.White;
            this.btnZpet.Location = new System.Drawing.Point(723, 0);
            this.btnZpet.Name = "btnZpet";
            this.btnZpet.Size = new System.Drawing.Size(75, 82);
            this.btnZpet.TabIndex = 1;
            this.btnZpet.Text = "Zpět";
            this.btnZpet.UseVisualStyleBackColor = true;
            this.btnZpet.Click += new System.EventHandler(this.BtnZpet_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Helvetica", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(332, 28);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(114, 33);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Přihlásit";
            // 
            // grpUsername
            // 
            this.grpUsername.Controls.Add(this.txtUsername);
            this.grpUsername.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpUsername.Location = new System.Drawing.Point(189, 140);
            this.grpUsername.Name = "grpUsername";
            this.grpUsername.Size = new System.Drawing.Size(422, 55);
            this.grpUsername.TabIndex = 1;
            this.grpUsername.TabStop = false;
            this.grpUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUsername.Location = new System.Drawing.Point(6, 21);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(410, 25);
            this.txtUsername.TabIndex = 0;
            // 
            // grpPIN
            // 
            this.grpPIN.Controls.Add(this.txtPIN);
            this.grpPIN.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpPIN.Location = new System.Drawing.Point(189, 201);
            this.grpPIN.Name = "grpPIN";
            this.grpPIN.Size = new System.Drawing.Size(422, 53);
            this.grpPIN.TabIndex = 2;
            this.grpPIN.TabStop = false;
            this.grpPIN.Text = "PIN";
            // 
            // txtPIN
            // 
            this.txtPIN.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPIN.Location = new System.Drawing.Point(6, 21);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.PasswordChar = '*';
            this.txtPIN.Size = new System.Drawing.Size(410, 25);
            this.txtPIN.TabIndex = 0;
            this.txtPIN.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogIn.Location = new System.Drawing.Point(189, 260);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(422, 39);
            this.btnLogIn.TabIndex = 8;
            this.btnLogIn.Text = "Příhlásit se";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.grpPIN);
            this.Controls.Add(this.grpUsername);
            this.Controls.Add(this.pnlTop);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DokaPass - Přihlášení";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogInForm_FormClosing);
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.Resize += new System.EventHandler(this.LogInForm_Resize);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpUsername.ResumeLayout(false);
            this.grpUsername.PerformLayout();
            this.grpPIN.ResumeLayout(false);
            this.grpPIN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox grpPIN;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnZpet;
    }
}