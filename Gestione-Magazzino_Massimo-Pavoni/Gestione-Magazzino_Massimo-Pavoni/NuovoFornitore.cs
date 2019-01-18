using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestione_Magazzino_Massimo_Pavoni
{
    public partial class NuovoFornitore : Form
    {
        public NuovoFornitore()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            //controlla eccezioni
            try
            {
                if (txbRagioneSociale.Text == "")
                    Magazzino.AggiungiFornitore("Indefinita", txbCognome.Text, txbNome.Text, txbRuolo.Text);
                else
                    Magazzino.AggiungiFornitore(txbRagioneSociale.Text, txbCognome.Text, txbNome.Text, txbRuolo.Text);
                Close();
            }
            catch (ArgumentException _e)
            {
                MessageBox.Show(_e.Message);
            }
        }
    }
}
