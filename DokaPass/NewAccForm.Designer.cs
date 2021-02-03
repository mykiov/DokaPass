namespace DokaPass
{
    partial class NewAccForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.grpPIN = new System.Windows.Forms.GroupBox();
            this.lblDec = new System.Windows.Forms.Label();
            this.txtVerifyPIN = new System.Windows.Forms.TextBox();
            this.lblInfoVerifyPIN = new System.Windows.Forms.Label();
            this.lblnfoPIN = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.grpUsername = new System.Windows.Forms.GroupBox();
            this.lblInfoMinimumChars = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnZpet = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.grpPIN.SuspendLayout();
            this.grpUsername.SuspendLayout();
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
            this.pnlTop.Size = new System.Drawing.Size(800, 85);
            this.pnlTop.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Helvetica", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(318, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(144, 33);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Nový účet";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.btnCreate);
            this.pnlBody.Controls.Add(this.grpPIN);
            this.pnlBody.Controls.Add(this.grpUsername);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlBody.Location = new System.Drawing.Point(0, 85);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(800, 376);
            this.pnlBody.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(168, 251);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(422, 39);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Vytvořit";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // grpPIN
            // 
            this.grpPIN.Controls.Add(this.lblDec);
            this.grpPIN.Controls.Add(this.txtVerifyPIN);
            this.grpPIN.Controls.Add(this.lblInfoVerifyPIN);
            this.grpPIN.Controls.Add(this.lblnfoPIN);
            this.grpPIN.Controls.Add(this.txtPIN);
            this.grpPIN.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpPIN.Location = new System.Drawing.Point(168, 129);
            this.grpPIN.Name = "grpPIN";
            this.grpPIN.Size = new System.Drawing.Size(422, 103);
            this.grpPIN.TabIndex = 6;
            this.grpPIN.TabStop = false;
            this.grpPIN.Text = "PIN";
            // 
            // lblDec
            // 
            this.lblDec.AutoSize = true;
            this.lblDec.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDec.Location = new System.Drawing.Point(10, 48);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(116, 17);
            this.lblDec.TabIndex = 7;
            this.lblDec.Text = "a ještě jednou...";
            // 
            // txtVerifyPIN
            // 
            this.txtVerifyPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVerifyPIN.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtVerifyPIN.Location = new System.Drawing.Point(6, 66);
            this.txtVerifyPIN.Name = "txtVerifyPIN";
            this.txtVerifyPIN.Size = new System.Drawing.Size(268, 25);
            this.txtVerifyPIN.TabIndex = 6;
            this.txtVerifyPIN.TextChanged += new System.EventHandler(this.TxtVerifyPIN_TextChanged);
            // 
            // lblInfoVerifyPIN
            // 
            this.lblInfoVerifyPIN.AutoSize = true;
            this.lblInfoVerifyPIN.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoVerifyPIN.ForeColor = System.Drawing.Color.Red;
            this.lblInfoVerifyPIN.Location = new System.Drawing.Point(280, 69);
            this.lblInfoVerifyPIN.Name = "lblInfoVerifyPIN";
            this.lblInfoVerifyPIN.Size = new System.Drawing.Size(116, 17);
            this.lblInfoVerifyPIN.TabIndex = 4;
            this.lblInfoVerifyPIN.Text = "nejsou schodné";
            // 
            // lblnfoPIN
            // 
            this.lblnfoPIN.AutoSize = true;
            this.lblnfoPIN.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblnfoPIN.ForeColor = System.Drawing.Color.Red;
            this.lblnfoPIN.Location = new System.Drawing.Point(280, 26);
            this.lblnfoPIN.Name = "lblnfoPIN";
            this.lblnfoPIN.Size = new System.Drawing.Size(65, 17);
            this.lblnfoPIN.TabIndex = 2;
            this.lblnfoPIN.Text = "4-8 čísel";
            // 
            // txtPIN
            // 
            this.txtPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPIN.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPIN.Location = new System.Drawing.Point(6, 21);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(268, 25);
            this.txtPIN.TabIndex = 1;
            this.txtPIN.TextChanged += new System.EventHandler(this.TxtPIN_TextChanged);
            // 
            // grpUsername
            // 
            this.grpUsername.Controls.Add(this.lblInfoMinimumChars);
            this.grpUsername.Controls.Add(this.txtUsername);
            this.grpUsername.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpUsername.Location = new System.Drawing.Point(168, 57);
            this.grpUsername.Name = "grpUsername";
            this.grpUsername.Size = new System.Drawing.Size(422, 66);
            this.grpUsername.TabIndex = 1;
            this.grpUsername.TabStop = false;
            this.grpUsername.Text = "Username";
            // 
            // lblInfoMinimumChars
            // 
            this.lblInfoMinimumChars.AutoSize = true;
            this.lblInfoMinimumChars.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoMinimumChars.ForeColor = System.Drawing.Color.Red;
            this.lblInfoMinimumChars.Location = new System.Drawing.Point(280, 23);
            this.lblInfoMinimumChars.Name = "lblInfoMinimumChars";
            this.lblInfoMinimumChars.Size = new System.Drawing.Size(90, 17);
            this.lblInfoMinimumChars.TabIndex = 4;
            this.lblInfoMinimumChars.Text = "Min. 4 znaků";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUsername.Location = new System.Drawing.Point(6, 21);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(268, 25);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            // 
            // btnZpet
            // 
            this.btnZpet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(109)))), ((int)(((byte)(159)))));
            this.btnZpet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnZpet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZpet.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZpet.ForeColor = System.Drawing.Color.White;
            this.btnZpet.Location = new System.Drawing.Point(738, 0);
            this.btnZpet.Name = "btnZpet";
            this.btnZpet.Size = new System.Drawing.Size(60, 83);
            this.btnZpet.TabIndex = 1;
            this.btnZpet.Text = "Zpět";
            this.btnZpet.UseVisualStyleBackColor = false;
            this.btnZpet.Click += new System.EventHandler(this.BtnZpet_Click);
            // 
            // NewAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTop);
            this.Name = "NewAccForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewAccForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewAccForm_FormClosing);
            this.Load += new System.EventHandler(this.NewAccForm_Load);
            this.Resize += new System.EventHandler(this.NewAccForm_Resize);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.grpPIN.ResumeLayout(false);
            this.grpPIN.PerformLayout();
            this.grpUsername.ResumeLayout(false);
            this.grpUsername.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.GroupBox grpUsername;
        private System.Windows.Forms.Label lblInfoMinimumChars;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox grpPIN;
        private System.Windows.Forms.Label lblInfoVerifyPIN;
        private System.Windows.Forms.Label lblnfoPIN;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.TextBox txtVerifyPIN;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnZpet;
    }
}