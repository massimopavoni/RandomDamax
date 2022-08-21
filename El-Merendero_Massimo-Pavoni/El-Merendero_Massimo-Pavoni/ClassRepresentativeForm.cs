using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace El_Merendero_Massimo_Pavoni
{
    public partial class ClassRepresentativeForm : Form
    {
        Utente _loggedUtente;
        Classe _classeRappresentata;
        List<Utente> _utentiClasse;
        List<Ordine> _ordiniClasseToday;
        
        public ClassRepresentativeForm(Utente loggedUtente)
        {
            _loggedUtente = loggedUtente;
            _classeRappresentata = DataManager.Classi.Find(c => c.IdClasse == _loggedUtente.ClasseRappresentata);
            _utentiClasse = DataManager.Utenti.Where(u => u.ClasseDiAppartenenza == _classeRappresentata.IdClasse).ToList();
            InitializeComponent();
        }

        #region Events

        private void ClassRepresentativeForm_Load(object sender, EventArgs e)
        {
            //show utente's classe
            lblClasse.Text = _classeRappresentata.Anno + "°" + _classeRappresentata.Sezione + ' ' + _classeRappresentata.Indirizzo;
            RefreshData();
        }

        //confirm payment and delivery of merende
        private void btnConfermaOrdini_Click(object sender, EventArgs e)
        {
            if (!DataManager.ConfirmOrdini(_ordiniClasseToday, out string output))
                MessageBox.Show("Uno o più ordini non possono essere confermati, si prega di riprovare.\n\n" + output,
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Gli ordini sono stati confermati con successo.", "Esito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnConfermaOrdini.Enabled = false;
            RefreshData();
        }

        //data refresh timer
        private void tmrDataRefresh_Tick(object sender, EventArgs e) => RefreshData();

        private void btnClose_Click(object sender, EventArgs e) => Close();

        //block listview's columns resize
        private void lsv_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = ((ListView)sender).Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        //disable data refresh timer when closing form
        private void ClassRepresentativeForm_FormClosing(object sender, FormClosingEventArgs e) => tmrDataRefresh.Enabled = false;

        #endregion

        //data refresh method
        private void RefreshData()
        {
            _ordiniClasseToday = DataManager.Ordini.Where(o => _utentiClasse.Where(u => u.IdUtente == o.IdUtente).ToList().Count != 0
                && o.DataRichiesta > DateTime.Today && o.DataPagamento == DateTime.MinValue && DateTime.Now.TimeOfDay < Properties.Settings.Default.EndConfirmOrdini).ToList();
            decimal costoTotaleClasse = 0;
            //refresh merende listview data
            lsvOrdiniClasseToday.Items.Clear();
            foreach (Ordine ordine in _ordiniClasseToday)
            {
                Merenda tempMerenda = DataManager.Merende.Find(m => m.IdMerenda == ordine.IdMerenda);
                lsvOrdiniClasseToday.Items.Add(new ListViewItem(new string[] {
                    _utentiClasse.Find(u => u.IdUtente == ordine.IdUtente).Username, tempMerenda.Nome + " (" + tempMerenda.Variante + ')',
                    ordine.Quantita.ToString(), (ordine.Quantita * tempMerenda.CostoUnitario).ToString() }));
                costoTotaleClasse += ordine.Quantita * tempMerenda.CostoUnitario;
            }
            //refresh costo totale classe value
            lblCostoTotaleClasseValue.Text = costoTotaleClasse + " €";
            //enable confirm button if there are ordini to confirm
            btnConfermaOrdini.Enabled = _ordiniClasseToday.Count != 0 ? true : false;
        }
    }
}
