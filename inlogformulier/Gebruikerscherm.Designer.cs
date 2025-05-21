namespace inlogformulier
{
    partial class Gebruikerscherm
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
            btnRefresh = new Button();
            btnAflopend = new Button();
            btnOplopend = new Button();
            SuspendLayout();
            // 
            // tbBoekenlijst
            // 
            tbBoekenlijst.FormattingEnabled = true;
            tbBoekenlijst.ItemHeight = 15;
            tbBoekenlijst.Location = new Point(12, 12);
            tbBoekenlijst.Name = "tbBoekenlijst";
            tbBoekenlijst.Size = new Size(443, 424);
            tbBoekenlijst.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(492, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(71, 50);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAflopend
            // 
            btnAflopend.Location = new Point(596, 12);
            btnAflopend.Name = "btnAflopend";
            btnAflopend.Size = new Size(71, 50);
            btnAflopend.TabIndex = 2;
            btnAflopend.Text = "Aflopend";
            btnAflopend.UseVisualStyleBackColor = true;
            btnAflopend.Click += btnAflopend_Click;
            // 
            // btnOplopend
            // 
            btnOplopend.Location = new Point(702, 12);
            btnOplopend.Name = "btnOplopend";
            btnOplopend.Size = new Size(71, 50);
            btnOplopend.TabIndex = 3;
            btnOplopend.Text = "Oplopend";
            btnOplopend.UseVisualStyleBackColor = true;
            btnOplopend.Click += btnOplopend_Click;
            // 
            // Gebruikerscherm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOplopend);
            Controls.Add(btnAflopend);
            Controls.Add(btnRefresh);
            Controls.Add(tbBoekenlijst);
            Name = "Gebruikerscherm";
            Text = "Gebruikerscherm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox tbBoekenlijst;
        private Button btnRefresh;
        private Button btnAflopend;
        private Button btnOplopend;
    }
}