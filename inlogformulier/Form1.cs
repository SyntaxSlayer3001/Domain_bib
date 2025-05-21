using Domain_bib.Business;

namespace inlogformulier
{
    public partial class Form1 : Form
    {
        private Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = tbGebruikersnaam.Text;
            string password = tbWachtwoord.Text;

            if (controller.ValidateLogin(username, password))
            {
                MessageBox.Show("Login successful!");
                // Proceed to next form or main application
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
    }
}
