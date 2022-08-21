namespace Gestione_Magazzino_Massimo_Pavoni
{
    partial class MainForm
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
            this.lsvFornitori = new System.Windows.Forms.ListView();
            this.chCodice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRagioneSociale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCognome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRuolo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFornitori = new System.Windows.Forms.Label();
            this.lblProdotti = new System.Windows.Forms.Label();
            this.lsvProdotti = new System.Windows.Forms.ListView();
            this.chCodiceFornitore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCodiceProdotto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDenominazione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrezzoUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuantitaInMagazzino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chScortaMinima = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuantitaBloccoOrdine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOrdiniTotali = new System.Windows.Forms.Label();
            this.lsvOrdiniTotali = new System.Windows.Forms.ListView();
            this.chCodiceFornitoreORD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCodiceProdottoORD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDenominazioneORD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuantitaBloccoOrdineORD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNumeroOrdiniORD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNuovoFornitore = new System.Windows.Forms.Button();
            this.btnNuovoProdotto = new System.Windows.Forms.Button();
            this.gobVendita = new System.Windows.Forms.GroupBox();
            this.btnVendiProdotti = new System.Windows.Forms.Button();
            this.lblVenditaNumeroProdotti = new System.Windows.Forms.Label();
            this.lblVenditaProdotti = new System.Windows.Forms.Label();
            this.cmbVenditaProdotti = new System.Windows.Forms.ComboBox();
            this.txbVenditaNumeroProdotti = new System.Windows.Forms.TextBox();
            this.lblNumeroFornitori = new System.Windows.Forms.Label();
            this.lblNumeroProdotti = new System.Windows.Forms.Label();
            this.lblNumeroOrdiniTotali = new System.Windows.Forms.Label();
            this.gobVendita.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvFornitori
            // 
            this.lsvFornitori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCodice,
            this.chRagioneSociale,
            this.chCognome,
            this.chNome,
            this.chRuolo});
            this.lsvFornitori.FullRowSelect = true;
            this.lsvFornitori.Location = new System.Drawing.Point(12, 36);
            this.lsvFornitori.MultiSelect = false;
            this.lsvFornitori.Name = "lsvFornitori";
            this.lsvFornitori.ShowItemToolTips = true;
            this.lsvFornitori.Size = new System.Drawing.Size(701, 200);
            this.lsvFornitori.TabIndex = 1;
            this.lsvFornitori.UseCompatibleStateImageBehavior = false;
            this.lsvFornitori.View = System.Windows.Forms.View.Details;
            // 
            // chCodice
            // 
            this.chCodice.Text = "Codice";
            this.chCodice.Width = 80;
            // 
            // chRagioneSociale
            // 
            this.chRagioneSociale.Text = "Ragione Sociale";
            this.chRagioneSociale.Width = 160;
            // 
            // chCognome
            // 
            this.chCognome.Text = "Cognome";
            this.chCognome.Width = 140;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.Width = 140;
            // 
            // chRuolo
            // 
            this.chRuolo.Text = "Ruolo";
            this.chRuolo.Width = 160;
            // 
            // lblFornitori
            // 
            this.lblFornitori.AutoSize = true;
            this.lblFornitori.Location = new System.Drawing.Point(12, 9);
            this.lblFornitori.Name = "lblFornitori";
            this.lblFornitori.Size = new System.Drawing.Size(83, 24);
            this.lblFornitori.TabIndex = 0;
            this.lblFornitori.Text = "Fornitori";
            // 
            // lblProdotti
            // 
            this.lblProdotti.AutoSize = true;
            this.lblProdotti.Location = new System.Drawing.Point(12, 259);
            this.lblProdotti.Name = "lblProdotti";
            this.lblProdotti.Size = new System.Drawing.Size(77, 24);
            this.lblProdotti.TabIndex = 2;
            this.lblProdotti.Text = "Prodotti";
            // 
            // lsvProdotti
            // 
            this.lsvProdotti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCodiceFornitore,
            this.chCodiceProdotto,
            this.chDenominazione,
            this.chPrezzoUnitario,
            this.chQuantitaInMagazzino,
            this.chScortaMinima,
            this.chQuantitaBloccoOrdine});
            this.lsvProdotti.FullRowSelect = true;
            this.lsvProdotti.Location = new System.Drawing.Point(12, 286);
            this.lsvProdotti.MultiSelect = false;
            this.lsvProdotti.Name = "lsvProdotti";
            this.lsvProdotti.ShowItemToolTips = true;
            this.lsvProdotti.Size = new System.Drawing.Size(1421, 200);
            this.lsvProdotti.TabIndex = 3;
            this.lsvProdotti.UseCompatibleStateImageBehavior = false;
            this.lsvProdotti.View = System.Windows.Forms.View.Details;
            // 
            // chCodiceFornitore
            // 
            this.chCodiceFornitore.Text = "Codice Fornitore";
            this.chCodiceFornitore.Width = 160;
            // 
            // chCodiceProdotto
            // 
            this.chCodiceProdotto.Text = "Codice Prodotto";
            this.chCodiceProdotto.Width = 160;
            // 
            // chDenominazione
            // 
            this.chDenominazione.Text = "Nome";
            this.chDenominazione.Width = 320;
            // 
            // chPrezzoUnitario
            // 
            this.chPrezzoUnitario.Text = "Prezzo Unitario";
            this.chPrezzoUnitario.Width = 160;
            // 
            // chQuantitaInMagazzino
            // 
            this.chQuantitaInMagazzino.Text = "Quantità In Magazzino";
            this.chQuantitaInMagazzino.Width = 220;
            // 
            // chScortaMinima
            // 
            this.chScortaMinima.Text = "Scorta Minima";
            this.chScortaMinima.Width = 160;
            // 
            // chQuantitaBloccoOrdine
            // 
            this.chQuantitaBloccoOrdine.Text = "Quantità Blocco Ordine";
            this.chQuantitaBloccoOrdine.Width = 220;
            // 
            // lblOrdiniTotali
            // 
            this.lblOrdiniTotali.AutoSize = true;
            this.lblOrdiniTotali.Location = new System.Drawing.Point(12, 509);
            this.lblOrdiniTotali.Name = "lblOrdiniTotali";
            this.lblOrdiniTotali.Size = new System.Drawing.Size(62, 24);
            this.lblOrdiniTotali.TabIndex = 4;
            this.lblOrdiniTotali.Text = "Ordini";
            // 
            // lsvOrdiniTotali
            // 
            this.lsvOrdiniTotali.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCodiceFornitoreORD,
            this.chCodiceProdottoORD,
            this.chDenominazioneORD,
            this.chQuantitaBloccoOrdineORD,
            this.chNumeroOrdiniORD});
            this.lsvOrdiniTotali.FullRowSelect = true;
            this.lsvOrdiniTotali.Location = new System.Drawing.Point(12, 536);
            this.lsvOrdiniTotali.MultiSelect = false;
            this.lsvOrdiniTotali.Name = "lsvOrdiniTotali";
            this.lsvOrdiniTotali.ShowItemToolTips = true;
            this.lsvOrdiniTotali.Size = new System.Drawing.Size(1041, 200);
            this.lsvOrdiniTotali.TabIndex = 5;
            this.lsvOrdiniTotali.UseCompatibleStateImageBehavior = false;
            this.lsvOrdiniTotali.View = System.Windows.Forms.View.Details;
            // 
            // chCodiceFornitoreORD
            // 
            this.chCodiceFornitoreORD.Text = "Codice Fornitore";
            this.chCodiceFornitoreORD.Width = 160;
            // 
            // chCodiceProdottoORD
            // 
            this.chCodiceProdottoORD.Text = "Codice Prodotto";
            this.chCodiceProdottoORD.Width = 160;
            // 
            // chDenominazioneORD
            // 
            this.chDenominazioneORD.Text = "Nome";
            this.chDenominazioneORD.Width = 320;
            // 
            // chQuantitaBloccoOrdineORD
            // 
            this.chQuantitaBloccoOrdineORD.Text = "Quantità Blocco Ordine";
            this.chQuantitaBloccoOrdineORD.Width = 220;
            // 
            // chNumeroOrdiniORD
            // 
            this.chNumeroOrdiniORD.Text = "Numero Ordini";
            this.chNumeroOrdiniORD.Width = 160;
            // 
            // btnNuovoFornitore
            // 
            this.btnNuovoFornitore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuovoFornitore.Location = new System.Drawing.Point(1217, 47);
            this.btnNuovoFornitore.Name = "btnNuovoFornitore";
            this.btnNuovoFornitore.Size = new System.Drawing.Size(158, 34);
            this.btnNuovoFornitore.TabIndex = 7;
            this.btnNuovoFornitore.Text = "Nuovo Fornitore";
            this.btnNuovoFornitore.UseVisualStyleBackColor = true;
            this.btnNuovoFornitore.Click += new System.EventHandler(this.btnNuovoFornitore_Click);
            // 
            // btnNuovoProdotto
            // 
            this.btnNuovoProdotto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuovoProdotto.Location = new System.Drawing.Point(1217, 87);
            this.btnNuovoProdotto.Name = "btnNuovoProdotto";
            this.btnNuovoProdotto.Size = new System.Drawing.Size(158, 34);
            this.btnNuovoProdotto.TabIndex = 8;
            this.btnNuovoProdotto.Text = "Nuovo Prodotto";
            this.btnNuovoProdotto.UseVisualStyleBackColor = true;
            this.btnNuovoProdotto.Click += new System.EventHandler(this.btnNuovoProdotto_Click);
            // 
            // gobVendita
            // 
            this.gobVendita.Controls.Add(this.btnVendiProdotti);
            this.gobVendita.Controls.Add(this.lblVenditaNumeroProdotti);
            this.gobVendita.Controls.Add(this.lblVenditaProdotti);
            this.gobVendita.Controls.Add(this.cmbVenditaProdotti);
            this.gobVendita.Controls.Add(this.txbVenditaNumeroProdotti);
            this.gobVendita.Location = new System.Drawing.Point(799, 36);
            this.gobVendita.Name = "gobVendita";
            this.gobVendita.Size = new System.Drawing.Size(332, 200);
            this.gobVendita.TabIndex = 6;
            this.gobVendita.TabStop = false;
            this.gobVendita.Text = "Vendita";
            // 
            // btnVendiProdotti
            // 
            this.btnVendiProdotti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVendiProdotti.Location = new System.Drawing.Point(166, 139);
            this.btnVendiProdotti.Name = "btnVendiProdotti";
            this.btnVendiProdotti.Size = new System.Drawing.Size(160, 34);
            this.btnVendiProdotti.TabIndex = 4;
            this.btnVendiProdotti.Text = "Vendi Prodotti";
            this.btnVendiProdotti.UseVisualStyleBackColor = true;
            this.btnVendiProdotti.Click += new System.EventHandler(this.btnVendiProdotti_Click);
            // 
            // lblVenditaNumeroProdotti
            // 
            this.lblVenditaNumeroProdotti.AutoSize = true;
            this.lblVenditaNumeroProdotti.Location = new System.Drawing.Point(6, 114);
            this.lblVenditaNumeroProdotti.Name = "lblVenditaNumeroProdotti";
            this.lblVenditaNumeroProdotti.Size = new System.Drawing.Size(78, 24);
            this.lblVenditaNumeroProdotti.TabIndex = 2;
            this.lblVenditaNumeroProdotti.Text = "Numero";
            // 
            // lblVenditaProdotti
            // 
            this.lblVenditaProdotti.AutoSize = true;
            this.lblVenditaProdotti.Location = new System.Drawing.Point(6, 40);
            this.lblVenditaProdotti.Name = "lblVenditaProdotti";
            this.lblVenditaProdotti.Size = new System.Drawing.Size(171, 24);
            this.lblVenditaProdotti.TabIndex = 0;
            this.lblVenditaProdotti.Text = "Prodotti Disponibili";
            // 
            // cmbVenditaProdotti
            // 
            this.cmbVenditaProdotti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVenditaProdotti.FormattingEnabled = true;
            this.cmbVenditaProdotti.Location = new System.Drawing.Point(6, 67);
            this.cmbVenditaProdotti.Name = "cmbVenditaProdotti";
            this.cmbVenditaProdotti.Size = new System.Drawing.Size(320, 32);
            this.cmbVenditaProdotti.TabIndex = 1;
            // 
            // txbVenditaNumeroProdotti
            // 
            this.txbVenditaNumeroProdotti.Location = new System.Drawing.Point(6, 141);
            this.txbVenditaNumeroProdotti.Name = "txbVenditaNumeroProdotti";
            this.txbVenditaNumeroProdotti.Size = new System.Drawing.Size(80, 32);
            this.txbVenditaNumeroProdotti.TabIndex = 3;
            // 
            // lblNumeroFornitori
            // 
            this.lblNumeroFornitori.AutoSize = true;
            this.lblNumeroFornitori.Location = new System.Drawing.Point(121, 9);
            this.lblNumeroFornitori.Name = "lblNumeroFornitori";
            this.lblNumeroFornitori.Size = new System.Drawing.Size(20, 24);
            this.lblNumeroFornitori.TabIndex = 9;
            this.lblNumeroFornitori.Text = "0";
            // 
            // lblNumeroProdotti
            // 
            this.lblNumeroProdotti.AutoSize = true;
            this.lblNumeroProdotti.Location = new System.Drawing.Point(115, 259);
            this.lblNumeroProdotti.Name = "lblNumeroProdotti";
            this.lblNumeroProdotti.Size = new System.Drawing.Size(20, 24);
            this.lblNumeroProdotti.TabIndex = 10;
            this.lblNumeroProdotti.Text = "0";
            // 
            // lblNumeroOrdiniTotali
            // 
            this.lblNumeroOrdiniTotali.AutoSize = true;
            this.lblNumeroOrdiniTotali.Location = new System.Drawing.Point(100, 509);
            this.lblNumeroOrdiniTotali.Name = "lblNumeroOrdiniTotali";
            this.lblNumeroOrdiniTotali.Size = new System.Drawing.Size(20, 24);
            this.lblNumeroOrdiniTotali.TabIndex = 11;
            this.lblNumeroOrdiniTotali.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1445, 748);
            this.Controls.Add(this.lblNumeroOrdiniTotali);
            this.Controls.Add(this.lblNumeroProdotti);
            this.Controls.Add(this.lblNumeroFornitori);
            this.Controls.Add(this.gobVendita);
            this.Controls.Add(this.btnNuovoProdotto);
            this.Controls.Add(this.btnNuovoFornitore);
            this.Controls.Add(this.lsvOrdiniTotali);
            this.Controls.Add(this.lblOrdiniTotali);
            this.Controls.Add(this.lblProdotti);
            this.Controls.Add(this.lsvProdotti);
            this.Controls.Add(this.lblFornitori);
            this.Controls.Add(this.lsvFornitori);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Gestione Magazzino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.gobVendita.ResumeLayout(false);
            this.gobVendita.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvFornitori;
        private System.Windows.Forms.Label lblFornitori;
        private System.Windows.Forms.ColumnHeader chCodice;
        private System.Windows.Forms.ColumnHeader chRagioneSociale;
        private System.Windows.Forms.ColumnHeader chCognome;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chRuolo;
        private System.Windows.Forms.Label lblProdotti;
        private System.Windows.Forms.ListView lsvProdotti;
        private System.Windows.Forms.ColumnHeader chCodiceFornitore;
        private System.Windows.Forms.ColumnHeader chCodiceProdotto;
        private System.Windows.Forms.ColumnHeader chDenominazione;
        private System.Windows.Forms.ColumnHeader chPrezzoUnitario;
        private System.Windows.Forms.ColumnHeader chQuantitaInMagazzino;
        private System.Windows.Forms.ColumnHeader chScortaMinima;
        private System.Windows.Forms.ColumnHeader chQuantitaBloccoOrdine;
        private System.Windows.Forms.Label lblOrdiniTotali;
        private System.Windows.Forms.ListView lsvOrdiniTotali;
        private System.Windows.Forms.ColumnHeader chCodiceFornitoreORD;
        private System.Windows.Forms.ColumnHeader chCodiceProdottoORD;
        private System.Windows.Forms.ColumnHeader chDenominazioneORD;
        private System.Windows.Forms.ColumnHeader chQuantitaBloccoOrdineORD;
        private System.Windows.Forms.ColumnHeader chNumeroOrdiniORD;
        private System.Windows.Forms.Button btnNuovoFornitore;
        private System.Windows.Forms.Button btnNuovoProdotto;
        private System.Windows.Forms.GroupBox gobVendita;
        private System.Windows.Forms.TextBox txbVenditaNumeroProdotti;
        private System.Windows.Forms.ComboBox cmbVenditaProdotti;
        private System.Windows.Forms.Label lblVenditaProdotti;
        private System.Windows.Forms.Label lblVenditaNumeroProdotti;
        private System.Windows.Forms.Button btnVendiProdotti;
        private System.Windows.Forms.Label lblNumeroFornitori;
        private System.Windows.Forms.Label lblNumeroProdotti;
        private System.Windows.Forms.Label lblNumeroOrdiniTotali;
    }
}

