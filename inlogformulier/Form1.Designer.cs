namespace inlogformulier
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbEmail = new TextBox();
            tbWachtwoord = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginButton = new Button();
            SuspendLayout();
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(142, 36);
            tbEmail.Margin = new Padding(3, 2, 3, 2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(491, 23);
            tbEmail.TabIndex = 0;
            // 
            // tbWachtwoord
            // 
            tbWachtwoord.Location = new Point(142, 131);
            tbWachtwoord.Margin = new Padding(3, 2, 3, 2);
            tbWachtwoord.Name = "tbWachtwoord";
            tbWachtwoord.Size = new Size(491, 23);
            tbWachtwoord.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 36);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 131);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "Wachtwoord";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(18, 196);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(671, 56);
            loginButton.TabIndex = 4;
            loginButton.Text = "Inloggen";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbWachtwoord);
            Controls.Add(tbEmail);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEmail;
        private TextBox tbWachtwoord;
        private Label label1;
        private Label label2;
        private Button loginButton;
    }
}
