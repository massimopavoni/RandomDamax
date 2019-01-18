using System;
using System.Text;
using System.Windows.Forms;

namespace El_Merendero_Massimo_Pavoni
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        #region Events

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //connect before showing login form
            if(!DataManager.Connect(out string output))
            {
                MessageBox.Show("La connessione al database non può essere aperta.\nSi prega di controllare il motivo o di riprovare più tardi.\n\n" + output,
                    "Errore fatale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            //used to insert users' passwords during development
            //string hash = BitConverter.ToString(Encoding.UTF8.GetBytes(PasswordHash.HashPassword("password"))).Replace("-", "");
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //disable data refresh timer when closing form
            tmrDataRefresh.Enabled = false;
            //if connection to database is still opened
            if (DataManager.IsConnected())
                //disconnect before closing application
                if (!DataManager.Disconnect(out string output))
                    MessageBox.Show("La connessione al database non può essere chiusa.\nSi prega di controllare il motivo o di riprovare più tardi.\n\n" + output,
                        "Errore fatale", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //update data to avoid logging in without the correct password
            if (!DataManager.RefreshData(out string output))
                MessageBox.Show("I dati non possono essere aggiornati.\nSi prega di controllare il motivo o di riprovare più tardi.\n\n" + output,
                         "Errore fatale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //rerieve logging utente (username is unique)
                Utente loggingUtente = DataManager.Utenti.Find(u => u.Username == txbUsername.Text);
                if (loggingUtente != null)
                {
                    //validate inserted password
                    if (PasswordHash.ValidatePassword(txbPassword.Text, Encoding.UTF8.GetString(loggingUtente.PasswordHash)))
                    {
                        txbPassword.Text = "";
                        lblLoginError.Visible = false;
                        Hide();
                        //view student form or elmerendero form based on user's specific field
                        if (!loggingUtente.ElMerendero)
                            new StudentForm(loggingUtente).ShowDialog();
                        else
                            new ElMerenderoForm(loggingUtente).ShowDialog();
                        Show();
                    }
                    else
                    {
                        lblLoginError.Text = "La password è errata.";
                        lblLoginError.Visible = true;
                        lblLoginError.Left = (lblLoginError.Parent.Width - lblLoginError.Width) / 2;
                    }
                }
                else
                {
                    lblLoginError.Text = "L'username specificato non esiste.";
                    lblLoginError.Visible = true;
                    lblLoginError.Left = (lblLoginError.Parent.Width - lblLoginError.Width) / 2;
                }                
            }
        }

        //data refresh timer
        private void tmrDataRefresh_Tick(object sender, EventArgs e)
        {
            //close form if data cannot be refreshed
            if (!DataManager.RefreshData(out string output))
            {
                MessageBox.Show("I dati non possono essere aggiornati.\nSi prega di controllare il motivo o di riprovare più tardi.\n\n" + output,
                         "Errore fatale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void txb_KeyDown(object sender, KeyEventArgs e)
        {
            //allow use of enter key to log into the platform
            if (e.KeyData == Keys.Enter) { btnLogin.PerformClick(); }
        }

        #endregion

        private void HideErrorWhenTryingAgain (object sender, EventArgs e) => lblLoginError.Visible = false;
    }
}
