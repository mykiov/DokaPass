namespace DokaPass
{
    partial class PullForm
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
            this.pnlAcc = new System.Windows.Forms.Panel();
            this.pnlTopWithButtons = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlListView = new System.Windows.Forms.Panel();
            this.pnlUserPassComment = new System.Windows.Forms.Panel();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlWithDeleeButton = new System.Windows.Forms.Panel();
            this.lblHelloMoment = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lstView = new System.Windows.Forms.ListView();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlSpace = new System.Windows.Forms.Panel();
            this.pnlTopButtonsAddEdit = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.btnCopyUsername = new System.Windows.Forms.Button();
            this.btnCopyPass = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlAcc.SuspendLayout();
            this.pnlTopWithButtons.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlListView.SuspendLayout();
            this.pnlUserPassComment.SuspendLayout();
            this.pnlWithDeleeButton.SuspendLayout();
            this.pnlTopButtonsAddEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pnlTopWithButtons);
            this.pnlTop.Controls.Add(this.pnlAcc);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(919, 72);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlAcc
            // 
            this.pnlAcc.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlAcc.Controls.Add(this.btnLogOut);
            this.pnlAcc.Controls.Add(this.lblHelloMoment);
            this.pnlAcc.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAcc.Location = new System.Drawing.Point(0, 0);
            this.pnlAcc.Name = "pnlAcc";
            this.pnlAcc.Size = new System.Drawing.Size(312, 72);
            this.pnlAcc.TabIndex = 0;
            // 
            // pnlTopWithButtons
            // 
            this.pnlTopWithButtons.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlTopWithButtons.Controls.Add(this.pnlTopButtonsAddEdit);
            this.pnlTopWithButtons.Controls.Add(this.pnlSpace);
            this.pnlTopWithButtons.Controls.Add(this.pnlWithDeleeButton);
            this.pnlTopWithButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopWithButtons.Location = new System.Drawing.Point(312, 0);
            this.pnlTopWithButtons.Name = "pnlTopWithButtons";
            this.pnlTopWithButtons.Size = new System.Drawing.Size(607, 72);
            this.pnlTopWithButtons.TabIndex = 1;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlUserPassComment);
            this.pnlBody.Controls.Add(this.pnlListView);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 72);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(919, 447);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlListView
            // 
            this.pnlListView.Controls.Add(this.lstView);
            this.pnlListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlListView.Location = new System.Drawing.Point(0, 0);
            this.pnlListView.Name = "pnlListView";
            this.pnlListView.Size = new System.Drawing.Size(568, 447);
            this.pnlListView.TabIndex = 0;
            // 
            // pnlUserPassComment
            // 
            this.pnlUserPassComment.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlUserPassComment.Controls.Add(this.btnCopyPass);
            this.pnlUserPassComment.Controls.Add(this.btnCopyUsername);
            this.pnlUserPassComment.Controls.Add(this.txtComments);
            this.pnlUserPassComment.Controls.Add(this.txtPass);
            this.pnlUserPassComment.Controls.Add(this.txtUsername);
            this.pnlUserPassComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserPassComment.Location = new System.Drawing.Point(568, 0);
            this.pnlUserPassComment.Name = "pnlUserPassComment";
            this.pnlUserPassComment.Size = new System.Drawing.Size(351, 447);
            this.pnlUserPassComment.TabIndex = 1;
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Turquoise;
            this.btnADD.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnADD.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnADD.Location = new System.Drawing.Point(260, 0);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(116, 72);
            this.btnADD.TabIndex = 0;
            this.btnADD.Text = "NOVÝ";
            this.btnADD.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(376, 72);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "UPRAVIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 72);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "SMAZAT";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // pnlWithDeleeButton
            // 
            this.pnlWithDeleeButton.Controls.Add(this.btnDelete);
            this.pnlWithDeleeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlWithDeleeButton.Location = new System.Drawing.Point(0, 0);
            this.pnlWithDeleeButton.Name = "pnlWithDeleeButton";
            this.pnlWithDeleeButton.Size = new System.Drawing.Size(141, 72);
            this.pnlWithDeleeButton.TabIndex = 2;
            // 
            // lblHelloMoment
            // 
            this.lblHelloMoment.AutoSize = true;
            this.lblHelloMoment.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHelloMoment.ForeColor = System.Drawing.Color.DimGray;
            this.lblHelloMoment.Location = new System.Drawing.Point(12, 9);
            this.lblHelloMoment.Name = "lblHelloMoment";
            this.lblHelloMoment.Size = new System.Drawing.Size(68, 18);
            this.lblHelloMoment.TabIndex = 0;
            this.lblHelloMoment.Text = "Hi, user!";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Helvetica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogOut.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnLogOut.Location = new System.Drawing.Point(0, 31);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(312, 41);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Odhlásit se";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // lstView
            // 
            this.lstView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstView.HideSelection = false;
            this.lstView.Location = new System.Drawing.Point(0, 0);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(568, 447);
            this.lstView.TabIndex = 0;
            this.lstView.UseCompatibleStateImageBehavior = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(67, 36);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(221, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 72);
            this.button1.TabIndex = 3;
            this.button1.Text = "PROHLÍŽET";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnlSpace
            // 
            this.pnlSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpace.Location = new System.Drawing.Point(141, 0);
            this.pnlSpace.Name = "pnlSpace";
            this.pnlSpace.Size = new System.Drawing.Size(466, 72);
            this.pnlSpace.TabIndex = 4;
            // 
            // pnlTopButtonsAddEdit
            // 
            this.pnlTopButtonsAddEdit.Controls.Add(this.button1);
            this.pnlTopButtonsAddEdit.Controls.Add(this.btnADD);
            this.pnlTopButtonsAddEdit.Controls.Add(this.btnEdit);
            this.pnlTopButtonsAddEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTopButtonsAddEdit.Location = new System.Drawing.Point(231, 0);
            this.pnlTopButtonsAddEdit.Name = "pnlTopButtonsAddEdit";
            this.pnlTopButtonsAddEdit.Size = new System.Drawing.Size(376, 72);
            this.pnlTopButtonsAddEdit.TabIndex = 5;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(67, 64);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(221, 22);
            this.txtPass.TabIndex = 1;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(67, 107);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(221, 157);
            this.txtComments.TabIndex = 2;
            // 
            // btnCopyUsername
            // 
            this.btnCopyUsername.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyUsername.Location = new System.Drawing.Point(294, 36);
            this.btnCopyUsername.Name = "btnCopyUsername";
            this.btnCopyUsername.Size = new System.Drawing.Size(23, 23);
            this.btnCopyUsername.TabIndex = 3;
            this.btnCopyUsername.Text = "C";
            this.btnCopyUsername.UseVisualStyleBackColor = true;
            // 
            // btnCopyPass
            // 
            this.btnCopyPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyPass.Location = new System.Drawing.Point(294, 63);
            this.btnCopyPass.Name = "btnCopyPass";
            this.btnCopyPass.Size = new System.Drawing.Size(23, 23);
            this.btnCopyPass.TabIndex = 4;
            this.btnCopyPass.Text = "C";
            this.btnCopyPass.UseVisualStyleBackColor = true;
            // 
            // PullForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 519);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTop);
            this.Name = "PullForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DokaPass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PullForm_FormClosing);
            this.Load += new System.EventHandler(this.PullForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlAcc.ResumeLayout(false);
            this.pnlAcc.PerformLayout();
            this.pnlTopWithButtons.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlListView.ResumeLayout(false);
            this.pnlUserPassComment.ResumeLayout(false);
            this.pnlUserPassComment.PerformLayout();
            this.pnlWithDeleeButton.ResumeLayout(false);
            this.pnlTopButtonsAddEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlTopWithButtons;
        private System.Windows.Forms.Panel pnlWithDeleeButton;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Panel pnlAcc;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlUserPassComment;
        private System.Windows.Forms.Panel pnlListView;
        private System.Windows.Forms.Panel pnlTopButtonsAddEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlSpace;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblHelloMoment;
        private System.Windows.Forms.Button btnCopyPass;
        private System.Windows.Forms.Button btnCopyUsername;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ListView lstView;
    }
}