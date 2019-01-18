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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            lsvFornitori.ColumnWidthChanging += new ColumnWidthChangingEventHandler(lsvFornitori_ColumnWidthChanging);
            lsvProdotti.ColumnWidthChanging += new ColumnWidthChangingEventHandler(lsvProdotti_ColumnWidthChanging);
            lsvOrdiniTotali.ColumnWidthChanging += new ColumnWidthChangingEventHandler(lsvOrdini_ColumnWidthChanging);
            Magazzino.CaricaDati();
            AggiornaFornitori();
            Magazzino.ControllaScorte();
            AggiornaProdotti();
            AggiornaOrdiniTotali();
            Magazzino.SalvaDati();
        }

        #region Metodi
        void AggiornaFornitori()
        {
            lsvFornitori.Items.Clear();
            foreach(Fornitore _f in Magazzino.Fornitori)
                lsvFornitori.Items.Add(new ListViewItem(new string[] { _f.Codice.ToString(), _f.RagioneSociale, _f.Cognome, _f.Nome, _f.Ruolo }));
            lblNumeroFornitori.Text = Magazzino.NumeroFornitori.ToString();
        }
        void AggiornaProdotti()
        {
            lsvProdotti.Items.Clear();
            foreach (Prodotto _p in Magazzino.Prodotti)
                lsvProdotti.Items.Add(new ListViewItem(new string[] { _p.CodiceFornitore.ToString(), _p.CodiceProdotto.ToString(), _p.Nome,
                    _p.PrezzoUnitario.ToString(), _p.QuantitaInMagazzino.ToString(), _p.ScortaMinima.ToString(), _p.QuantitaBloccoOrdine.ToString() }));
            lblNumeroProdotti.Text = Magazzino.NumeroProdotti.ToString();
            //popola ComboBox dei prodotti vendita
            cmbVenditaProdotti.Items.Clear();
            foreach (Prodotto _p in Magazzino.Prodotti)
                cmbVenditaProdotti.Items.Add(_p.CodiceProdotto + " - " + _p.Nome);
            cmbVenditaProdotti.SelectedIndex = 0;
            txbVenditaNumeroProdotti.Text = "";
        }
        void AggiornaOrdiniTotali()
        {
            lsvOrdiniTotali.Items.Clear();
            foreach (Ordine _o in Magazzino.OrdiniTotali)
                lsvOrdiniTotali.Items.Add(new ListViewItem(new string[] { _o.CodiceFornitore.ToString(), _o.CodiceProdotto.ToString(), _o.NomeProdotto,
                    _o.QuantitaBloccoOrdine.ToString(), _o.NumeroOrdini.ToString() }));
            lblNumeroOrdiniTotali.Text = Magazzino.NumeroOrdiniTotali.ToString();
        }
        #endregion

        #region Eventi
        private void btnNuovoFornitore_Click(object sender, EventArgs e)
        {
            NuovoFornitore _NuovoFornitore = new NuovoFornitore();
            _NuovoFornitore.ShowDialog();
            AggiornaFornitori();
            Magazzino.SalvaDati();
        }
        private void btnNuovoProdotto_Click(object sender, EventArgs e)
        {
            NuovoProdotto _NuovoProdotto = new NuovoProdotto();
            _NuovoProdotto.ShowDialog();
            Magazzino.ControllaScorte();
            AggiornaProdotti();
            AggiornaOrdiniTotali();
            Magazzino.SalvaDati();
        }
        private void btnVendiProdotti_Click(object sender, EventArgs e)
        {
            //controlla eccezioni
            try
            {
                if (!int.TryParse(txbVenditaNumeroProdotti.Text, out int _intResultFlag))
                    throw new ArgumentException("Il valore inserito non è valido.");
                double _prezzoTotale = Magazzino.Prodotti[cmbVenditaProdotti.SelectedIndex].Vendi(_intResultFlag);
                Magazzino.ControllaScorte();
                MessageBox.Show("Sono stati venduti " + _intResultFlag + " pezzi del prodotto numero "
                    + cmbVenditaProdotti.SelectedItem + ", per un totale di " + _prezzoTotale + "€.");
                AggiornaProdotti();
                AggiornaOrdiniTotali();
            }
            catch (ArgumentException _e)
            {
                MessageBox.Show(_e.Message);
            }
            Magazzino.SalvaDati();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => Magazzino.SalvaDati();
        //impedisce resize delle ListView
        void lsvFornitori_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lsvFornitori.Columns[e.ColumnIndex].Width;
        }
        void lsvProdotti_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lsvProdotti.Columns[e.ColumnIndex].Width;
        }
        void lsvOrdini_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lsvOrdiniTotali.Columns[e.ColumnIndex].Width;
        }
        #endregion
    }
}
