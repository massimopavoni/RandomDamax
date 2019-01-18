using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace El_Merendero_Massimo_Pavoni
{
    public partial class StudentForm : Form
    {
        private Utente _loggedUtente;
        private Merenda _selectedMerenda;

        public StudentForm(Utente loggedUtente)
        {
            _loggedUtente = loggedUtente;
            InitializeComponent();
        }

        #region Events

        private void StudentForm_Load(object sender, EventArgs e)
        {
            //show logged utente's username
            string[] loggedUtenteArgs = _loggedUtente.Username.Split('.');
            loggedUtenteArgs[0] = loggedUtenteArgs[0].First().ToString().ToUpper() + loggedUtenteArgs[0].Substring(1);
            loggedUtenteArgs[1] = loggedUtenteArgs[1].First().ToString().ToUpper() + loggedUtenteArgs[1].Substring(1);
            lblUsername.Text = loggedUtenteArgs[0] + ' ' + loggedUtenteArgs[1];
            //show utente's classe
            Classe classeUtente = DataManager.Classi.Find(c => c.IdClasse == _loggedUtente.ClasseDiAppartenenza);
            lblClasse.Text = classeUtente.Anno + "°" + classeUtente.Sezione + ' ' + classeUtente.Indirizzo;
            lblClasse.Left = (lblClasse.Parent.Width - lblClasse.Width) / 2;
            //view total ordini if utente is rappresentante of a classe
            if (_loggedUtente.ClasseRappresentata != -1) btnOrdiniClasse.Visible = true;
            RefreshData();
        }

        //open form for classe's representative
        private void btnOrdiniClasse_Click(object sender, EventArgs e) =>
            new ClassRepresentativeForm(_loggedUtente).ShowDialog();

        //view merenda's info to make a ordine
        private void lsvMerende_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvMerende.SelectedIndices.Count > 0)
            {
                _selectedMerenda = DataManager.Merende[lsvMerende.SelectedIndices[0]];
                lblNomeMerendaValue.Text = _selectedMerenda.Nome;
                lblVarianteMerendaValue.Text = _selectedMerenda.Variante;
                nudQuantitaMerendaValue.Enabled = true;
                nudQuantitaMerendaValue.Maximum = _selectedMerenda.Disponibilita;
                nudQuantitaMerendaValue.Value = 1;
                lblCostoTotaleMerendaValue.Text = (nudQuantitaMerendaValue.Value * _selectedMerenda.CostoUnitario).ToString() + " €";
                btnSendOrdine.Enabled = true;
            }
        }

        //change costo totale when quantita is changed
        private void nudQuantitaMerendaValue_ValueChanged(object sender, EventArgs e) =>
            lblCostoTotaleMerendaValue.Text = (nudQuantitaMerendaValue.Value * _selectedMerenda.CostoUnitario).ToString() + " €";

        //send an ordine
        private void btnSendOrdine_Click(object sender, EventArgs e)
        {
            Ordine ordine = new Ordine(_loggedUtente.IdUtente, _selectedMerenda.IdMerenda, Convert.ToInt16(nudQuantitaMerendaValue.Value), DateTime.Now);
            if (!DataManager.InsertOrdine(ordine, out string output))
                MessageBox.Show("L'ordine non può essere inviato, si prega di riprovare.\n\n" + output,
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("L'ordine è stato inviato con successo.", "Esito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblNomeMerendaValue.Text = "";
            lblVarianteMerendaValue.Text = "";
            nudQuantitaMerendaValue.Enabled = false;
            nudQuantitaMerendaValue.Maximum = 255;
            nudQuantitaMerendaValue.Value = 1;
            lblCostoTotaleMerendaValue.Text = "";
            btnSendOrdine.Enabled = false;
            RefreshData();
        }

        //data refresh timer
        private void tmrDataRefresh_Tick(object sender, EventArgs e) => RefreshData();

        private void btnLogout_Click(object sender, EventArgs e) => Close();

        //disable data refresh timer when closing form
        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e) => tmrDataRefresh.Enabled = false;

        //block listviews' columns resize
        private void lsv_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = ((ListView)sender).Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        #endregion

        //data refresh method
        private void RefreshData()
        {
            //create list with available merende (those not gone yet)
            List<Merenda> merendeAncoraDisponibili = DataManager.Merende.Where(m => m.Disponibilita > 0).ToList();
            //if all merende are gone, close form
            if (merendeAncoraDisponibili == null)
            {
                MessageBox.Show("Spiacenti, ma non ci sono più merende disponibili.\nSi prega di riprovare più tardi.",
                        "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            //refresh merende listview data
            lsvMerende.Items.Clear();
            foreach (Merenda merenda in merendeAncoraDisponibili)
                lsvMerende.Items.Add(new ListViewItem(new string[] {
                    merenda.Nome, merenda.Variante, merenda.Tipo.ToString(), merenda.CostoUnitario.ToString(), merenda.Disponibilita.ToString() }));
            //refresh ordini utente today listview data
            lsvOrdiniUtenteToday.Items.Clear();
            foreach (Ordine ordine in DataManager.Ordini.Where(o => o.IdUtente == _loggedUtente.IdUtente && o.DataRichiesta > DateTime.Today).ToList())
            {
                Merenda tempMerenda = DataManager.Merende.Find(m => m.IdMerenda == ordine.IdMerenda);
                lsvOrdiniUtenteToday.Items.Add(new ListViewItem(new string[] {
                    tempMerenda.Nome + " (" + tempMerenda.Variante + ')', ordine.Quantita.ToString(),
                    ordine.DataPagamento != DateTime.MinValue ? "Pagato" : DateTime.Now.TimeOfDay < Properties.Settings.Default.EndConfirmOrdini ? "In attesa" : "Scaduto" }));
            }
        }
    }
}
