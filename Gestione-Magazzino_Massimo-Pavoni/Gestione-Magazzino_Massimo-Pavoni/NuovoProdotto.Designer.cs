namespace Gestione_Magazzino_Massimo_Pavoni
{
    partial class NuovoProdotto
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
            this.lblFornitore = new System.Windows.Forms.Label();
            this.txbNomeProdotto = new System.Windows.Forms.TextBox();
            this.cmbFornitore = new System.Windows.Forms.ComboBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.lblNomeProdotto = new System.Windows.Forms.Label();
            this.lblPrezzoUnitario = new System.Windows.Forms.Label();
            this.txbPrezzoUnitario = new System.Windows.Forms.TextBox();
            this.lblQuantitaInMagazzino = new System.Windows.Forms.Label();
            this.txbQuantitaInMagazzino = new System.Windows.Forms.TextBox();
            this.lblScortaMinima = new System.Windows.Forms.Label();
            this.txbScortaMinima = new System.Windows.Forms.TextBox();
            this.lblQuantitaBloccoOrdine = new System.Windows.Forms.Label();
            this.txbQuantitaBloccoOrdine = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFornitore
            // 
            this.lblFornitore.AutoSize = true;
            this.lblFornitore.Location = new System.Drawing.Point(12, 9);
            this.lblFornitore.Name = "lblFornitore";
            this.lblFornitore.Size = new System.Drawing.Size(88, 24);
            this.lblFornitore.TabIndex = 0;
            this.lblFornitore.Text = "Fornitore";
            // 
            // txbNomeProdotto
            // 
            this.txbNomeProdotto.Location = new System.Drawing.Point(258, 36);
            this.txbNomeProdotto.Name = "txbNomeProdotto";
            this.txbNomeProdotto.Size = new System.Drawing.Size(240, 32);
            this.txbNomeProdotto.TabIndex = 3;
            // 
            // cmbFornitore
            // 
            this.cmbFornitore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFornitore.Location = new System.Drawing.Point(12, 36);
            this.cmbFornitore.Name = "cmbFornitore";
            this.cmbFornitore.Size = new System.Drawing.Size(240, 32);
            this.cmbFornitore.TabIndex = 1;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.AutoSize = true;
            this.btnAggiungi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAggiungi.Location = new System.Drawing.Point(12, 176);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(91, 34);
            this.btnAggiungi.TabIndex = 12;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // lblNomeProdotto
            // 
            this.lblNomeProdotto.AutoSize = true;
            this.lblNomeProdotto.Location = new System.Drawing.Point(258, 9);
            this.lblNomeProdotto.Name = "lblNomeProdotto";
            this.lblNomeProdotto.Size = new System.Drawing.Size(139, 24);
            this.lblNomeProdotto.TabIndex = 2;
            this.lblNomeProdotto.Text = "Nome Prodotto";
            // 
            // lblPrezzoUnitario
            // 
            this.lblPrezzoUnitario.AutoSize = true;
            this.lblPrezzoUnitario.Location = new System.Drawing.Point(504, 9);
            this.lblPrezzoUnitario.Name = "lblPrezzoUnitario";
            this.lblPrezzoUnitario.Size = new System.Drawing.Size(138, 24);
            this.lblPrezzoUnitario.TabIndex = 4;
            this.lblPrezzoUnitario.Text = "Prezzo Unitario";
            // 
            // txbPrezzoUnitario
            // 
            this.txbPrezzoUnitario.Location = new System.Drawing.Point(504, 36);
            this.txbPrezzoUnitario.Name = "txbPrezzoUnitario";
            this.txbPrezzoUnitario.Size = new System.Drawing.Size(240, 32);
            this.txbPrezzoUnitario.TabIndex = 5;
            // 
            // lblQuantitaInMagazzino
            // 
            this.lblQuantitaInMagazzino.AutoSize = true;
            this.lblQuantitaInMagazzino.Location = new System.Drawing.Point(12, 91);
            this.lblQuantitaInMagazzino.Name = "lblQuantitaInMagazzino";
            this.lblQuantitaInMagazzino.Size = new System.Drawing.Size(198, 24);
            this.lblQuantitaInMagazzino.TabIndex = 6;
            this.lblQuantitaInMagazzino.Text = "Quantità In Magazzino";
            // 
            // txbQuantitaInMagazzino
            // 
            this.txbQuantitaInMagazzino.Location = new System.Drawing.Point(12, 118);
            this.txbQuantitaInMagazzino.Name = "txbQuantitaInMagazzino";
            this.txbQuantitaInMagazzino.Size = new System.Drawing.Size(240, 32);
            this.txbQuantitaInMagazzino.TabIndex = 7;
            // 
            // lblScortaMinima
            // 
            this.lblScortaMinima.AutoSize = true;
            this.lblScortaMinima.Location = new System.Drawing.Point(258, 91);
            this.lblScortaMinima.Name = "lblScortaMinima";
            this.lblScortaMinima.Size = new System.Drawing.Size(131, 24);
            this.lblScortaMinima.TabIndex = 8;
            this.lblScortaMinima.Text = "Scorta Minima";
            // 
            // txbScortaMinima
            // 
            this.txbScortaMinima.Location = new System.Drawing.Point(258, 118);
            this.txbScortaMinima.Name = "txbScortaMinima";
            this.txbScortaMinima.Size = new System.Drawing.Size(240, 32);
            this.txbScortaMinima.TabIndex = 9;
            // 
            // lblQuantitaBloccoOrdine
            // 
            this.lblQuantitaBloccoOrdine.AutoSize = true;
            this.lblQuantitaBloccoOrdine.Location = new System.Drawing.Point(504, 91);
            this.lblQuantitaBloccoOrdine.Name = "lblQuantitaBloccoOrdine";
            this.lblQuantitaBloccoOrdine.Size = new System.Drawing.Size(204, 24);
            this.lblQuantitaBloccoOrdine.TabIndex = 10;
            this.lblQuantitaBloccoOrdine.Text = "Quantità Blocco Ordine";
            // 
            // txbQuantitaBloccoOrdine
            // 
            this.txbQuantitaBloccoOrdine.Location = new System.Drawing.Point(504, 118);
            this.txbQuantitaBloccoOrdine.Name = "txbQuantitaBloccoOrdine";
            this.txbQuantitaBloccoOrdine.Size = new System.Drawing.Size(240, 32);
            this.txbQuantitaBloccoOrdine.TabIndex = 11;
            // 
            // NuovoProdotto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(756, 222);
            this.Controls.Add(this.lblQuantitaBloccoOrdine);
            this.Controls.Add(this.txbQuantitaBloccoOrdine);
            this.Controls.Add(this.lblScortaMinima);
            this.Controls.Add(this.txbScortaMinima);
            this.Controls.Add(this.lblQuantitaInMagazzino);
            this.Controls.Add(this.txbQuantitaInMagazzino);
            this.Controls.Add(this.lblPrezzoUnitario);
            this.Controls.Add(this.txbPrezzoUnitario);
            this.Controls.Add(this.lblNomeProdotto);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.cmbFornitore);
            this.Controls.Add(this.txbNomeProdotto);
            this.Controls.Add(this.lblFornitore);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuovoProdotto";
            this.ShowIcon = false;
            this.Text = "Nuovo Prodotto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFornitore;
        private System.Windows.Forms.TextBox txbNomeProdotto;
        private System.Windows.Forms.ComboBox cmbFornitore;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label lblNomeProdotto;
        private System.Windows.Forms.Label lblPrezzoUnitario;
        private System.Windows.Forms.TextBox txbPrezzoUnitario;
        private System.Windows.Forms.Label lblQuantitaInMagazzino;
        private System.Windows.Forms.TextBox txbQuantitaInMagazzino;
        private System.Windows.Forms.Label lblScortaMinima;
        private System.Windows.Forms.TextBox txbScortaMinima;
        private System.Windows.Forms.Label lblQuantitaBloccoOrdine;
        private System.Windows.Forms.TextBox txbQuantitaBloccoOrdine;
    }
}