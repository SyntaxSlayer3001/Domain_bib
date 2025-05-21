namespace inlogformulier
{
    partial class ToevoegGebruiker
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
            label1 = new Label();
            textBox1 = new TextBox();
            btnToevoegenGebruiker = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 84);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(460, 23);
            textBox1.TabIndex = 1;
            // 
            // btnToevoegenGebruiker
            // 
            btnToevoegenGebruiker.Location = new Point(121, 227);
            btnToevoegenGebruiker.Name = "btnToevoegenGebruiker";
            btnToevoegenGebruiker.Size = new Size(559, 23);
            btnToevoegenGebruiker.TabIndex = 2;
            btnToevoegenGebruiker.Text = "Voeg gebruiker toe";
            btnToevoegenGebruiker.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 173);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "Wachtwoord";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(460, 23);
            textBox2.TabIndex = 4;
            // 
            // ToevoegGebruiker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(btnToevoegenGebruiker);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ToevoegGebruiker";
            Text = "ToevoegGebruiker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnToevoegenGebruiker;
        private Label label2;
        private TextBox textBox2;
    }
}