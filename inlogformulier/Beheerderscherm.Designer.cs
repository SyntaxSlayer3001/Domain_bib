﻿namespace inlogformulier
{
    partial class Beheerderscherm
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
            tbBoekenlijst = new ListBox();
            btnAddboek = new Button();
            btnAddUser = new Button();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // tbBoekenlijst
            // 
            tbBoekenlijst.FormattingEnabled = true;
            tbBoekenlijst.ItemHeight = 15;
            tbBoekenlijst.Location = new Point(12, 12);
            tbBoekenlijst.Name = "tbBoekenlijst";
            tbBoekenlijst.Size = new Size(443, 424);
            tbBoekenlijst.TabIndex = 2;
            // 
            // btnAddboek
            // 
            btnAddboek.Location = new Point(481, 12);
            btnAddboek.Name = "btnAddboek";
            btnAddboek.Size = new Size(307, 37);
            btnAddboek.TabIndex = 3;
            btnAddboek.Text = "Voeg boek toe";
            btnAddboek.UseVisualStyleBackColor = true;
            btnAddboek.Click += btnAddboek_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(481, 73);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(307, 37);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "Voeg een gebruiker toe";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(481, 139);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(71, 50);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Beheerderscherm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddUser);
            Controls.Add(btnAddboek);
            Controls.Add(tbBoekenlijst);
            Name = "Beheerderscherm";
            Text = "Beheerderscherm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox tbBoekenlijst;
        private Button btnAddboek;
        private Button btnAddUser;
        private Button btnRefresh;
    }
}