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
    public partial class NuovoProdotto : Form
    {
        public NuovoProdotto()
        {
            InitializeComponent();
            CenterToParent();
            //popola ComboBox dei fornitori
            foreach (Fornitore _f in Magazzino.Fornitori)
                cmbFornitore.Items.Add(_f.Codice + " - " + _f.Cognome + " " + _f.Nome);
            cmbFornitore.SelectedIndex = 0;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            //controlla eccezioni
            try
            {
                if (!(double.TryParse(txbPrezzoUnitario.Text.Replace(',', '.'), out double _doubleResultFlag) && int.TryParse(txbQuantitaInMagazzino.Text, out int _intResultFlag) &&
                    int.TryParse(txbScortaMinima.Text, out _intResultFlag) && int.TryParse(txbQuantitaBloccoOrdine.Text, out _intResultFlag)))
                    throw new ArgumentException("I valori inseriti nei campi non sono validi.");
                Magazzino.AggiungiProdotto(Magazzino.Fornitori[cmbFornitore.SelectedIndex].Codice, txbNomeProdotto.Text, Convert.ToDouble(txbPrezzoUnitario.Text.Replace(',', '.')),
                        Convert.ToInt32(txbQuantitaInMagazzino.Text), Convert.ToInt32(txbScortaMinima.Text), Convert.ToInt32(txbQuantitaBloccoOrdine.Text));
                Close();
            }
            catch (ArgumentException _e)
            {
                MessageBox.Show(_e.Message);
            }
        }
    }
}
