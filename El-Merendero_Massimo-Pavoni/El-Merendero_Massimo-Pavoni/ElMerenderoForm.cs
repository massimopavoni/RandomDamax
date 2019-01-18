using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace El_Merendero_Massimo_Pavoni
{
    public partial class ElMerenderoForm : Form
    {
        private Utente _loggedUtente;
        private Classe _selectedClasse;
        private Merenda _selectedMerenda;
        private List<Utente> _utentiSelectedClasse;
        private List<Ordine> _ordiniUtentiSelectedClasseToday;
        private DialogResult confirmDialog;

        public ElMerenderoForm(Utente loggedUtente)
        {
            _loggedUtente = loggedUtente;
            InitializeComponent();
        }

        #region Events

        private void ElMerenderoForm_Load(object sender, EventArgs e)
        {
            //show logged utente's username
            string[] loggedUtenteArgs = _loggedUtente.Username.Split('.');
            loggedUtenteArgs[0] = loggedUtenteArgs[0].First().ToString().ToUpper() + loggedUtenteArgs[0].Substring(1);
            loggedUtenteArgs[1] = loggedUtenteArgs[1].First().ToString().ToUpper() + loggedUtenteArgs[1].Substring(1);
            lblUsername.Text = loggedUtenteArgs[0] + ' ' + loggedUtenteArgs[1];
            //insert tipi merenda combobox items collection
            cmbTipoMerendaValue.Items.AddRange(new string[] { "Salato", "Dolce", "Bevanda" });
            cmbTipoMerendaValue.SelectedIndex = 0;
            //refresh classi combobox items collection
            foreach (Classe classe in DataManager.Classi)
                cmbClassi.Items.Add(classe.Anno + "°" + classe.Sezione + ' ' + classe.Indirizzo);
            //select first classe, initialize selected merenda and date time pickers
            cmbClassi.SelectedIndex = 0;
            _selectedClasse = DataManager.Classi[0];
            _selectedMerenda = null;
            dtpEndInsertOrdine.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day,
                Properties.Settings.Default.EndInsertOrdine.Hours, Properties.Settings.Default.EndInsertOrdine.Minutes,
                Properties.Settings.Default.EndInsertOrdine.Seconds);
            dtpEndConfirmOrdini.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day,
                Properties.Settings.Default.EndConfirmOrdini.Hours, Properties.Settings.Default.EndConfirmOrdini.Minutes,
                Properties.Settings.Default.EndConfirmOrdini.Seconds);
            RefreshData();
        }

        //data refresh timer
        private void tmrDataRefresh_Tick(object sender, EventArgs e)
        {
            //refresh combobox items collection
            cmbClassi.Items.Clear();
            foreach (Classe classe in DataManager.Classi)
                cmbClassi.Items.Add(classe.Anno + "°" + classe.Sezione + ' ' + classe.Indirizzo);
            //select first classe
            cmbClassi.SelectedIndex = 0;
            _selectedClasse = DataManager.Classi[0];
            RefreshData();
        }

        //view merenda's info to edit or delete it
        private void lsvMerende_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvMerende.SelectedIndices.Count > 0)
            {
                if (!CompareMerende())
                {
                    confirmDialog = _selectedMerenda == null ? MessageBox.Show("Vuoi inserire la nuova merenda?", "Conferma inserimento", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        : MessageBox.Show("Vuoi salvare le modifiche effettuate?", "Conferma modifica", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmDialog == DialogResult.Yes)
                        if (_selectedMerenda == null)
                        {
                            if (!DataManager.InsertMerenda(new Merenda(txbNomeMerendaValue.Text, txbVarianteMerendaValue.Text, (TipoMerenda)cmbTipoMerendaValue.SelectedIndex,
                                nudCostoUnitarioMerendaValue.Value, Convert.ToInt16(nudDisponibilitaMerendaValue.Value)), out string output))
                                MessageBox.Show("La merenda non può essere inserita, si prega di riprovare.\n\n" + output,
                                                "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                MessageBox.Show("La merenda è stata inserita con successo.", "Esito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearMerendaView();
                                RefreshData();
                            }
                        }
                        else
                        {
                            if (!DataManager.UpdateMerenda(new Merenda(txbNomeMerendaValue.Text, txbVarianteMerendaValue.Text, (TipoMerenda)cmbTipoMerendaValue.SelectedIndex,
                                nudCostoUnitarioMerendaValue.Value, Convert.ToInt16(nudDisponibilitaMerendaValue.Value), _selectedMerenda.IdMerenda), out string output))
                                MessageBox.Show("La merenda non può essere modificata, si prega di riprovare.\n\n" + output,
                                             "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                MessageBox.Show("La merenda è stata modificata con successo.", "Esito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UpdateMerendaView();
                                RefreshData();
                            }
                        }
                    else UpdateMerendaView();
                }
                else UpdateMerendaView();
                btnMerendaAction.Enabled = true;
            }
        }

        //verify if user is editing merenda
        private void merendaView_SomethingChanged(object sender, EventArgs e)
        {
            if (_selectedMerenda != null)
                if (!CompareMerende()) btnMerendaAction.Text = "Modifica";
                else btnMerendaAction.Text = "Elimina";
            btnInsertMerenda.Enabled = (String.IsNullOrWhiteSpace(txbNomeMerendaValue.Text) || String.IsNullOrWhiteSpace(txbVarianteMerendaValue.Text)) ? false : true;
        }        

        //update or delete selected merenda
        private void btnMerendaAction_Click(object sender, EventArgs e)
        {
            if (btnMerendaAction.Text == "Modifica")
            {
                confirmDialog = MessageBox.Show("Vuoi salvare le modifiche effettuate?", "Conferma modifica", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmDialog == DialogResult.Yes)
                    if (!DataManager.UpdateMerenda(new Merenda(txbNomeMerendaValue.Text, txbVarianteMerendaValue.Text, (TipoMerenda)cmbTipoMerendaValue.SelectedIndex,
                                   nudCostoUnitarioMerendaValue.Value, Convert.ToInt16(nudDisponibilitaMerendaValue.Value), _selectedMerenda.IdMerenda), out string output))
                        MessageBox.Show("La merenda non può essere modificata, si prega di riprovare.\n\n" + output,
                                     "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show("La merenda è stata modificata con successo.", "Esito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearMerendaView();
                    }
                RefreshData();
            }
            else
            {
                confirmDialog = MessageBox.Show("Vuoi eliminare la merenda?", "Conferma eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmDialog == DialogResult.Yes)
                    if (!DataManager.DeleteMerenda(_selectedMerenda.IdMerenda, out string output))
                        MessageBox.Show("La merenda non può essere eliminata, si prega di riprovare.\n\n" + output,
                                        "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show("La merenda è stata eliminata con successo.", "Esito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearMerendaView();
                    }
                RefreshData();
            }
        }

        //insert new merenda
        private void btnInsertMerenda_Click(object sender, EventArgs e)
        {
            confirmDialog = MessageBox.Show("Vuoi inserire la nuova merenda?", "Conferma inserimento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmDialog == DialogResult.Yes)
            {
                if (!DataManager.InsertMerenda(new Merenda(txbNomeMerendaValue.Text, txbVarianteMerendaValue.Text, (TipoMerenda)cmbTipoMerendaValue.SelectedIndex,
                    nudCostoUnitarioMerendaValue.Value, Convert.ToInt16(nudDisponibilitaMerendaValue.Value)), out string output))
                    MessageBox.Show("La merenda non può essere inserita, si prega di riprovare.\n\n" + output,
                                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("La merenda è stata inserita con successo.", "Esito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearMerendaView();
                }
            }
            RefreshData();
        }

        //change end insert ordine in settings
        private void dtpEndInsertOrdine_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EndInsertOrdine = new TimeSpan(dtpEndInsertOrdine.Value.Hour, dtpEndInsertOrdine.Value.Minute, dtpEndInsertOrdine.Value.Second);
            Properties.Settings.Default.Save();
        }

        //change end confirm ordini in settings
        private void dtpEndConfirmOrdini_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EndConfirmOrdini = new TimeSpan(dtpEndConfirmOrdini.Value.Hour, dtpEndConfirmOrdini.Value.Minute, dtpEndConfirmOrdini.Value.Second);
            Properties.Settings.Default.Save();
        }

        //change selected classe
        private void cmbClassi_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedClasse = DataManager.Classi[cmbClassi.SelectedIndex];
            RefreshData();
        }

        private void btnLogout_Click(object sender, EventArgs e) => Close();

        //block listview's columns resize
        private void lsv_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = ((ListView)sender).Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        //disable data refresh timer when closing form
        private void ElMerenderoForm_FormClosing(object sender, FormClosingEventArgs e) => tmrDataRefresh.Enabled = false;

        #endregion

        #region Methods

        //data refresh method
        private void RefreshData()
        {
            //refresh ordini by classe listview data
            lsvOrdiniByClasse.Items.Clear();
            _utentiSelectedClasse = DataManager.Utenti.Where(u => u.ClasseDiAppartenenza == _selectedClasse.IdClasse).ToList();
            _ordiniUtentiSelectedClasseToday = DataManager.Ordini.Where(o => _utentiSelectedClasse.Where(u => u.IdUtente == o.IdUtente).ToList().Count != 0
                && o.DataRichiesta > DateTime.Today && o.DataPagamento == DateTime.MinValue && DateTime.Now.TimeOfDay < Properties.Settings.Default.EndConfirmOrdini).ToList();
            lblTotalClasseValue.Text = "0";
            foreach (Ordine ordine in _ordiniUtentiSelectedClasseToday)
            {
                Merenda tempMerenda = DataManager.Merende.Find(m => m.IdMerenda == ordine.IdMerenda);
                lsvOrdiniByClasse.Items.Add(new ListViewItem(new string[] {
                    _utentiSelectedClasse.Find(u => u.IdUtente == ordine.IdUtente).Username, tempMerenda.Nome + " (" + tempMerenda.Variante + ')',
                    ordine.Quantita.ToString(), (ordine.Quantita * tempMerenda.CostoUnitario).ToString() }));
                lblTotalClasseValue.Text = (Convert.ToDecimal(lblTotalClasseValue.Text) + (ordine.Quantita * tempMerenda.CostoUnitario)).ToString();
            }
            lblTotalClasseValue.Text += " €";

            //refresh ordini by merenda and merende listview data
            lsvOrdiniByMerenda.Items.Clear();
            lsvMerende.Items.Clear();
            foreach (Merenda merenda in DataManager.Merende)
            {
                List<Ordine> tempOrdini = DataManager.Ordini.Where(o => o.IdMerenda == merenda.IdMerenda &&
                    o.DataRichiesta > DateTime.Today && o.DataPagamento == DateTime.MinValue && DateTime.Now.TimeOfDay < Properties.Settings.Default.EndConfirmOrdini).ToList();
                lsvOrdiniByMerenda.Items.Add(new ListViewItem(new string[] {
                    merenda.Nome, merenda.Variante, merenda.Tipo.ToString(),
                    tempOrdini.Sum(o => o.Quantita).ToString(), tempOrdini.Sum(o => o.Quantita * merenda.CostoUnitario).ToString() }));
                lsvMerende.Items.Add(new ListViewItem(new string[] {
                    merenda.Nome, merenda.Variante, merenda.Tipo.ToString(), merenda.CostoUnitario.ToString(), merenda.Disponibilita.ToString() }));
            }
        }

        //view selected merenda's info
        private void UpdateMerendaView()
        {
            if (lsvMerende.SelectedIndices.Count > 0)
            {
                _selectedMerenda = DataManager.Merende[lsvMerende.SelectedIndices[0]];
                txbNomeMerendaValue.Text = _selectedMerenda.Nome;
                txbVarianteMerendaValue.Text = _selectedMerenda.Variante;
                cmbTipoMerendaValue.SelectedIndex = (int)_selectedMerenda.Tipo;
                nudCostoUnitarioMerendaValue.Value = _selectedMerenda.CostoUnitario;
                nudDisponibilitaMerendaValue.Value = _selectedMerenda.Disponibilita;
                btnMerendaAction.Text = "Elimina";
            }
        }

        //clear the merenda's info
        private void ClearMerendaView()
        {
            _selectedMerenda = null;
            txbNomeMerendaValue.Text = "";
            txbVarianteMerendaValue.Text = "";
            cmbTipoMerendaValue.SelectedIndex = 0;
            nudCostoUnitarioMerendaValue.Value = 0.01M;
            nudDisponibilitaMerendaValue.Value = 1;
            btnMerendaAction.Text = "Elimina";
            btnMerendaAction.Enabled = false;
        }

        //verify if merenda viewed is equal to selected merenda
        private bool CompareMerende()
        {
            if (_selectedMerenda == null)
                if (txbNomeMerendaValue.Text == "" && txbVarianteMerendaValue.Text == "")
                    return true;
                else
                    return false;
            else
            {
                Merenda tempMerenda = new Merenda(txbNomeMerendaValue.Text, txbVarianteMerendaValue.Text, (TipoMerenda)cmbTipoMerendaValue.SelectedIndex,
                       nudCostoUnitarioMerendaValue.Value, Convert.ToInt16(nudDisponibilitaMerendaValue.Value), _selectedMerenda.IdMerenda);
                if (txbNomeMerendaValue.Text != "" && txbVarianteMerendaValue.Text != "")
                {
                    foreach (var property in tempMerenda.GetType().GetProperties())
                        if (!property.GetValue(tempMerenda).Equals(property.GetValue(_selectedMerenda))) return false;
                    return true;
                }
                return false;
            }
        }

        #endregion
    }
}
