﻿namespace DokaPass
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
            this.pnlTopWithButtons = new System.Windows.Forms.Panel();
            this.pnlTopButtonsAddEdit = new System.Windows.Forms.Panel();
            this.btnSpectate = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlSpace = new System.Windows.Forms.Panel();
            this.pnlWithDeleteButton = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlAcc = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblHelloMoment = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlUserPassComment = new System.Windows.Forms.Panel();
            this.txtWebPageName = new System.Windows.Forms.TextBox();
            this.lblCharCounterForTxtComment = new System.Windows.Forms.Label();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.lblActualMode = new System.Windows.Forms.Label();
            this.btnCopyPass = new System.Windows.Forms.Button();
            this.btnCopyUsername = new System.Windows.Forms.Button();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.pnlTopWithButtons.SuspendLayout();
            this.pnlTopButtonsAddEdit.SuspendLayout();
            this.pnlWithDeleteButton.SuspendLayout();
            this.pnlAcc.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlUserPassComment.SuspendLayout();
            this.pnlDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.pnlTopWithButtons);
            this.pnlTop.Controls.Add(this.pnlAcc);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(919, 72);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlTopWithButtons
            // 
            this.pnlTopWithButtons.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlTopWithButtons.Controls.Add(this.pnlTopButtonsAddEdit);
            this.pnlTopWithButtons.Controls.Add(this.pnlSpace);
            this.pnlTopWithButtons.Controls.Add(this.pnlWithDeleteButton);
            this.pnlTopWithButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopWithButtons.Location = new System.Drawing.Point(312, 0);
            this.pnlTopWithButtons.Name = "pnlTopWithButtons";
            this.pnlTopWithButtons.Size = new System.Drawing.Size(605, 70);
            this.pnlTopWithButtons.TabIndex = 1;
            // 
            // pnlTopButtonsAddEdit
            // 
            this.pnlTopButtonsAddEdit.Controls.Add(this.btnSpectate);
            this.pnlTopButtonsAddEdit.Controls.Add(this.btnADD);
            this.pnlTopButtonsAddEdit.Controls.Add(this.btnEdit);
            this.pnlTopButtonsAddEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTopButtonsAddEdit.Location = new System.Drawing.Point(229, 0);
            this.pnlTopButtonsAddEdit.Name = "pnlTopButtonsAddEdit";
            this.pnlTopButtonsAddEdit.Size = new System.Drawing.Size(376, 70);
            this.pnlTopButtonsAddEdit.TabIndex = 5;
            // 
            // btnSpectate
            // 
            this.btnSpectate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSpectate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSpectate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpectate.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpectate.Location = new System.Drawing.Point(0, 0);
            this.btnSpectate.Name = "btnSpectate";
            this.btnSpectate.Size = new System.Drawing.Size(116, 70);
            this.btnSpectate.TabIndex = 3;
            this.btnSpectate.Text = "PROHLÍŽET";
            this.btnSpectate.UseVisualStyleBackColor = false;
            this.btnSpectate.Click += new System.EventHandler(this.BtnSpectate_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.SkyBlue;
            this.btnADD.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnADD.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnADD.Location = new System.Drawing.Point(260, 0);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(116, 70);
            this.btnADD.TabIndex = 0;
            this.btnADD.Text = "NOVÝ";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.BtnADD_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(376, 70);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "UPRAVIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // pnlSpace
            // 
            this.pnlSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpace.Location = new System.Drawing.Point(141, 0);
            this.pnlSpace.Name = "pnlSpace";
            this.pnlSpace.Size = new System.Drawing.Size(464, 70);
            this.pnlSpace.TabIndex = 4;
            // 
            // pnlWithDeleteButton
            // 
            this.pnlWithDeleteButton.Controls.Add(this.btnDelete);
            this.pnlWithDeleteButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlWithDeleteButton.Location = new System.Drawing.Point(0, 0);
            this.pnlWithDeleteButton.Name = "pnlWithDeleteButton";
            this.pnlWithDeleteButton.Size = new System.Drawing.Size(141, 70);
            this.pnlWithDeleteButton.TabIndex = 2;
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
            this.btnDelete.Size = new System.Drawing.Size(141, 70);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "SMAZAT";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // pnlAcc
            // 
            this.pnlAcc.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlAcc.Controls.Add(this.btnLogOut);
            this.pnlAcc.Controls.Add(this.lblHelloMoment);
            this.pnlAcc.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAcc.Location = new System.Drawing.Point(0, 0);
            this.pnlAcc.Name = "pnlAcc";
            this.pnlAcc.Size = new System.Drawing.Size(312, 70);
            this.pnlAcc.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Helvetica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogOut.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnLogOut.Location = new System.Drawing.Point(0, 29);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(312, 41);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Odhlásit se";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // lblHelloMoment
            // 
            this.lblHelloMoment.AutoSize = true;
            this.lblHelloMoment.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHelloMoment.ForeColor = System.Drawing.Color.DimGray;
            this.lblHelloMoment.Location = new System.Drawing.Point(3, 0);
            this.lblHelloMoment.Name = "lblHelloMoment";
            this.lblHelloMoment.Size = new System.Drawing.Size(68, 18);
            this.lblHelloMoment.TabIndex = 0;
            this.lblHelloMoment.Text = "Hi, user!";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlUserPassComment);
            this.pnlBody.Controls.Add(this.pnlDataGridView);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 72);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(919, 447);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlUserPassComment
            // 
            this.pnlUserPassComment.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlUserPassComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserPassComment.Controls.Add(this.txtWebPageName);
            this.pnlUserPassComment.Controls.Add(this.lblCharCounterForTxtComment);
            this.pnlUserPassComment.Controls.Add(this.btnEvent);
            this.pnlUserPassComment.Controls.Add(this.btnGen);
            this.pnlUserPassComment.Controls.Add(this.lblActualMode);
            this.pnlUserPassComment.Controls.Add(this.btnCopyPass);
            this.pnlUserPassComment.Controls.Add(this.btnCopyUsername);
            this.pnlUserPassComment.Controls.Add(this.txtComments);
            this.pnlUserPassComment.Controls.Add(this.txtPass);
            this.pnlUserPassComment.Controls.Add(this.txtUsername);
            this.pnlUserPassComment.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUserPassComment.Location = new System.Drawing.Point(568, 0);
            this.pnlUserPassComment.Name = "pnlUserPassComment";
            this.pnlUserPassComment.Size = new System.Drawing.Size(351, 447);
            this.pnlUserPassComment.TabIndex = 1;
            // 
            // txtWebPageName
            // 
            this.txtWebPageName.Location = new System.Drawing.Point(14, 43);
            this.txtWebPageName.MaxLength = 20;
            this.txtWebPageName.Name = "txtWebPageName";
            this.txtWebPageName.Size = new System.Drawing.Size(221, 22);
            this.txtWebPageName.TabIndex = 9;
            this.txtWebPageName.Enter += new System.EventHandler(this.TxtName_Enter);
            this.txtWebPageName.Leave += new System.EventHandler(this.TxtName_Leave);
            // 
            // lblCharCounterForTxtComment
            // 
            this.lblCharCounterForTxtComment.AutoSize = true;
            this.lblCharCounterForTxtComment.Location = new System.Drawing.Point(241, 287);
            this.lblCharCounterForTxtComment.Name = "lblCharCounterForTxtComment";
            this.lblCharCounterForTxtComment.Size = new System.Drawing.Size(36, 17);
            this.lblCharCounterForTxtComment.TabIndex = 8;
            this.lblCharCounterForTxtComment.Text = "0/30";
            // 
            // btnEvent
            // 
            this.btnEvent.BackColor = System.Drawing.Color.MintCream;
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEvent.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEvent.Location = new System.Drawing.Point(14, 326);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(221, 30);
            this.btnEvent.TabIndex = 7;
            this.btnEvent.Text = "Přidat";
            this.btnEvent.UseVisualStyleBackColor = false;
            this.btnEvent.Click += new System.EventHandler(this.BtnEvent_Click);
            // 
            // btnGen
            // 
            this.btnGen.BackColor = System.Drawing.Color.LightBlue;
            this.btnGen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGen.Location = new System.Drawing.Point(270, 99);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(46, 23);
            this.btnGen.TabIndex = 6;
            this.btnGen.Text = "GEN";
            this.btnGen.UseVisualStyleBackColor = false;
            this.btnGen.Click += new System.EventHandler(this.BtnGen_Click);
            // 
            // lblActualMode
            // 
            this.lblActualMode.AutoSize = true;
            this.lblActualMode.Font = new System.Drawing.Font("Helvetica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActualMode.ForeColor = System.Drawing.Color.DimGray;
            this.lblActualMode.Location = new System.Drawing.Point(138, 3);
            this.lblActualMode.Name = "lblActualMode";
            this.lblActualMode.Size = new System.Drawing.Size(86, 20);
            this.lblActualMode.TabIndex = 5;
            this.lblActualMode.Text = "Prohlížení";
            // 
            // btnCopyPass
            // 
            this.btnCopyPass.BackColor = System.Drawing.Color.LightBlue;
            this.btnCopyPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyPass.Location = new System.Drawing.Point(241, 99);
            this.btnCopyPass.Name = "btnCopyPass";
            this.btnCopyPass.Size = new System.Drawing.Size(23, 23);
            this.btnCopyPass.TabIndex = 4;
            this.btnCopyPass.Text = "C";
            this.btnCopyPass.UseVisualStyleBackColor = false;
            this.btnCopyPass.Click += new System.EventHandler(this.BtnCopyPass_Click);
            // 
            // btnCopyUsername
            // 
            this.btnCopyUsername.BackColor = System.Drawing.Color.LightBlue;
            this.btnCopyUsername.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyUsername.Location = new System.Drawing.Point(241, 70);
            this.btnCopyUsername.Name = "btnCopyUsername";
            this.btnCopyUsername.Size = new System.Drawing.Size(23, 23);
            this.btnCopyUsername.TabIndex = 3;
            this.btnCopyUsername.Text = "C";
            this.btnCopyUsername.UseVisualStyleBackColor = false;
            this.btnCopyUsername.Click += new System.EventHandler(this.BtnCopyUsername_Click);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(14, 147);
            this.txtComments.MaxLength = 30;
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComments.Size = new System.Drawing.Size(221, 157);
            this.txtComments.TabIndex = 2;
            this.txtComments.TextChanged += new System.EventHandler(this.TxtComments_TextChanged);
            this.txtComments.Enter += new System.EventHandler(this.TxtComments_Enter);
            this.txtComments.Leave += new System.EventHandler(this.TxtComments_Leave);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(14, 99);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(221, 22);
            this.txtPass.TabIndex = 1;
            this.txtPass.Enter += new System.EventHandler(this.TxtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.TxtPass_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(14, 71);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(221, 22);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Enter += new System.EventHandler(this.TxtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.TxtUsername_Leave);
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.Controls.Add(this.dtGridView);
            this.pnlDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(919, 447);
            this.pnlDataGridView.TabIndex = 0;
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.AllowUserToDeleteRows = false;
            this.dtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGridView.Location = new System.Drawing.Point(0, 0);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersVisible = false;
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridView.Size = new System.Drawing.Size(919, 447);
            this.dtGridView.TabIndex = 0;
            this.dtGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtGridView_CellMouseClick);
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
            this.Text = "Doka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PullForm_FormClosing);
            this.Load += new System.EventHandler(this.PullForm_Load);
            this.Resize += new System.EventHandler(this.PullForm_Resize);
            this.pnlTop.ResumeLayout(false);
            this.pnlTopWithButtons.ResumeLayout(false);
            this.pnlTopButtonsAddEdit.ResumeLayout(false);
            this.pnlWithDeleteButton.ResumeLayout(false);
            this.pnlAcc.ResumeLayout(false);
            this.pnlAcc.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlUserPassComment.ResumeLayout(false);
            this.pnlUserPassComment.PerformLayout();
            this.pnlDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlTopWithButtons;
        private System.Windows.Forms.Panel pnlWithDeleteButton;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Panel pnlAcc;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlUserPassComment;
        private System.Windows.Forms.Panel pnlDataGridView;
        private System.Windows.Forms.Panel pnlTopButtonsAddEdit;
        private System.Windows.Forms.Button btnSpectate;
        private System.Windows.Forms.Panel pnlSpace;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblHelloMoment;
        private System.Windows.Forms.Button btnCopyPass;
        private System.Windows.Forms.Button btnCopyUsername;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblActualMode;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Label lblCharCounterForTxtComment;
        private System.Windows.Forms.TextBox txtWebPageName;
        private System.Windows.Forms.DataGridView dtGridView;
    }
}