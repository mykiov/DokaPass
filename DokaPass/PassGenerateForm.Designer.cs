namespace DokaPass
{
    partial class PassGenerateForm
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDelkaHesla = new System.Windows.Forms.Label();
            this.grpBxTypy = new System.Windows.Forms.GroupBox();
            this.chkMalaPismena = new System.Windows.Forms.CheckBox();
            this.chkVelkaPismena = new System.Windows.Forms.CheckBox();
            this.chkCisla = new System.Windows.Forms.CheckBox();
            this.chkSymboly = new System.Windows.Forms.CheckBox();
            this.btnGenerovat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.grpBxTypy.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(99, 12);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(311, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Délka hesla";
            // 
            // lblDelkaHesla
            // 
            this.lblDelkaHesla.AutoSize = true;
            this.lblDelkaHesla.Location = new System.Drawing.Point(416, 21);
            this.lblDelkaHesla.Name = "lblDelkaHesla";
            this.lblDelkaHesla.Size = new System.Drawing.Size(16, 17);
            this.lblDelkaHesla.TabIndex = 2;
            this.lblDelkaHesla.Text = "4";
            // 
            // grpBxTypy
            // 
            this.grpBxTypy.Controls.Add(this.chkSymboly);
            this.grpBxTypy.Controls.Add(this.chkCisla);
            this.grpBxTypy.Controls.Add(this.chkVelkaPismena);
            this.grpBxTypy.Controls.Add(this.chkMalaPismena);
            this.grpBxTypy.Location = new System.Drawing.Point(14, 58);
            this.grpBxTypy.Name = "grpBxTypy";
            this.grpBxTypy.Size = new System.Drawing.Size(456, 100);
            this.grpBxTypy.TabIndex = 3;
            this.grpBxTypy.TabStop = false;
            // 
            // chkMalaPismena
            // 
            this.chkMalaPismena.AutoSize = true;
            this.chkMalaPismena.Location = new System.Drawing.Point(115, 26);
            this.chkMalaPismena.Name = "chkMalaPismena";
            this.chkMalaPismena.Size = new System.Drawing.Size(117, 21);
            this.chkMalaPismena.TabIndex = 0;
            this.chkMalaPismena.Text = "Malá písmena";
            this.chkMalaPismena.UseVisualStyleBackColor = true;
            // 
            // chkVelkaPismena
            // 
            this.chkVelkaPismena.AutoSize = true;
            this.chkVelkaPismena.Location = new System.Drawing.Point(115, 57);
            this.chkVelkaPismena.Name = "chkVelkaPismena";
            this.chkVelkaPismena.Size = new System.Drawing.Size(122, 21);
            this.chkVelkaPismena.TabIndex = 1;
            this.chkVelkaPismena.Text = "Velká písmena";
            this.chkVelkaPismena.UseVisualStyleBackColor = true;
            // 
            // chkCisla
            // 
            this.chkCisla.AutoSize = true;
            this.chkCisla.Location = new System.Drawing.Point(256, 26);
            this.chkCisla.Name = "chkCisla";
            this.chkCisla.Size = new System.Drawing.Size(60, 21);
            this.chkCisla.TabIndex = 2;
            this.chkCisla.Text = "Čísla";
            this.chkCisla.UseVisualStyleBackColor = true;
            // 
            // chkSymboly
            // 
            this.chkSymboly.AutoSize = true;
            this.chkSymboly.Location = new System.Drawing.Point(256, 57);
            this.chkSymboly.Name = "chkSymboly";
            this.chkSymboly.Size = new System.Drawing.Size(83, 21);
            this.chkSymboly.TabIndex = 3;
            this.chkSymboly.Text = "Symboly";
            this.chkSymboly.UseVisualStyleBackColor = true;
            // 
            // btnGenerovat
            // 
            this.btnGenerovat.Location = new System.Drawing.Point(129, 164);
            this.btnGenerovat.Name = "btnGenerovat";
            this.btnGenerovat.Size = new System.Drawing.Size(224, 38);
            this.btnGenerovat.TabIndex = 4;
            this.btnGenerovat.Text = "Generovat";
            this.btnGenerovat.UseVisualStyleBackColor = true;
            this.btnGenerovat.Click += new System.EventHandler(this.BtnGenerovat_Click);
            // 
            // PassGenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.btnGenerovat);
            this.Controls.Add(this.grpBxTypy);
            this.Controls.Add(this.lblDelkaHesla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "PassGenerateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassGenerateForm";
            this.Load += new System.EventHandler(this.PassGenerateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.grpBxTypy.ResumeLayout(false);
            this.grpBxTypy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDelkaHesla;
        private System.Windows.Forms.GroupBox grpBxTypy;
        private System.Windows.Forms.CheckBox chkSymboly;
        private System.Windows.Forms.CheckBox chkCisla;
        private System.Windows.Forms.CheckBox chkVelkaPismena;
        private System.Windows.Forms.CheckBox chkMalaPismena;
        private System.Windows.Forms.Button btnGenerovat;
    }
}