namespace El_Merendero_Massimo_Pavoni
{
    partial class StudentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.lsvMerende = new System.Windows.Forms.ListView();
            this.cmhNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhVariante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhCostoUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhDisponibilita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMerende = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tmrDataRefresh = new System.Windows.Forms.Timer(this.components);
            this.btnOrdiniClasse = new System.Windows.Forms.Button();
            this.gpbOrdineMerenda = new System.Windows.Forms.GroupBox();
            this.btnSendOrdine = new System.Windows.Forms.Button();
            this.nudQuantitaMerendaValue = new System.Windows.Forms.NumericUpDown();
            this.lblQuantitaMerenda = new System.Windows.Forms.Label();
            this.lblCostoTotaleMerendaValue = new System.Windows.Forms.Label();
            this.lblVarianteMerendaValue = new System.Windows.Forms.Label();
            this.lblCostoMerenda = new System.Windows.Forms.Label();
            this.lblNomeMerendaValue = new System.Windows.Forms.Label();
            this.lblVarianteMerenda = new System.Windows.Forms.Label();
            this.lblNomeMerenda = new System.Windows.Forms.Label();
            this.gpbOrdiniUtenteToday = new System.Windows.Forms.GroupBox();
            this.lsvOrdiniUtenteToday = new System.Windows.Forms.ListView();
            this.cmhMerenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhQuantita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhStato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.gpbOrdineMerenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantitaMerendaValue)).BeginInit();
            this.gpbOrdiniUtenteToday.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvMerende
            // 
            this.lsvMerende.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cmhNome,
            this.cmhVariante,
            this.cmhTipo,
            this.cmhCostoUnitario,
            this.cmhDisponibilita});
            this.lsvMerende.FullRowSelect = true;
            this.lsvMerende.GridLines = true;
            this.lsvMerende.Location = new System.Drawing.Point(12, 102);
            this.lsvMerende.MultiSelect = false;
            this.lsvMerende.Name = "lsvMerende";
            this.lsvMerende.Size = new System.Drawing.Size(564, 574);
            this.lsvMerende.TabIndex = 0;
            this.lsvMerende.UseCompatibleStateImageBehavior = false;
            this.lsvMerende.View = System.Windows.Forms.View.Details;
            this.lsvMerende.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsv_ColumnWidthChanging);
            this.lsvMerende.SelectedIndexChanged += new System.EventHandler(this.lsvMerende_SelectedIndexChanged);
            // 
            // cmhNome
            // 
            this.cmhNome.Text = "Nome";
            this.cmhNome.Width = 134;
            // 
            // cmhVariante
            // 
            this.cmhVariante.Text = "Variante";
            this.cmhVariante.Width = 134;
            // 
            // cmhTipo
            // 
            this.cmhTipo.Text = "Tipo";
            this.cmhTipo.Width = 120;
            // 
            // cmhCostoUnitario
            // 
            this.cmhCostoUnitario.Text = "Costo (€)";
            this.cmhCostoUnitario.Width = 77;
            // 
            // cmhDisponibilita
            // 
            this.cmhDisponibilita.Text = "Rimasti";
            this.cmhDisponibilita.Width = 77;
            // 
            // lblMerende
            // 
            this.lblMerende.AutoSize = true;
            this.lblMerende.Font = new System.Drawing.Font("Calibri", 16F);
            this.lblMerende.Location = new System.Drawing.Point(7, 72);
            this.lblMerende.Name = "lblMerende";
            this.lblMerende.Size = new System.Drawing.Size(195, 27);
            this.lblMerende.TabIndex = 1;
            this.lblMerende.Text = "Merende disponibili";
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 39);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tmrDataRefresh
            // 
            this.tmrDataRefresh.Enabled = true;
            this.tmrDataRefresh.Interval = 16000;
            this.tmrDataRefresh.Tick += new System.EventHandler(this.tmrDataRefresh_Tick);
            // 
            // btnOrdiniClasse
            // 
            this.btnOrdiniClasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrdiniClasse.AutoSize = true;
            this.btnOrdiniClasse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOrdiniClasse.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdiniClasse.Location = new System.Drawing.Point(768, 12);
            this.btnOrdiniClasse.Name = "btnOrdiniClasse";
            this.btnOrdiniClasse.Size = new System.Drawing.Size(202, 39);
            this.btnOrdiniClasse.TabIndex = 3;
            this.btnOrdiniClasse.Text = "Ordini della classe";
            this.btnOrdiniClasse.UseVisualStyleBackColor = true;
            this.btnOrdiniClasse.Visible = false;
            this.btnOrdiniClasse.Click += new System.EventHandler(this.btnOrdiniClasse_Click);
            // 
            // gpbOrdineMerenda
            // 
            this.gpbOrdineMerenda.Controls.Add(this.btnSendOrdine);
            this.gpbOrdineMerenda.Controls.Add(this.nudQuantitaMerendaValue);
            this.gpbOrdineMerenda.Controls.Add(this.lblQuantitaMerenda);
            this.gpbOrdineMerenda.Controls.Add(this.lblCostoTotaleMerendaValue);
            this.gpbOrdineMerenda.Controls.Add(this.lblVarianteMerendaValue);
            this.gpbOrdineMerenda.Controls.Add(this.lblCostoMerenda);
            this.gpbOrdineMerenda.Controls.Add(this.lblNomeMerendaValue);
            this.gpbOrdineMerenda.Controls.Add(this.lblVarianteMerenda);
            this.gpbOrdineMerenda.Controls.Add(this.lblNomeMerenda);
            this.gpbOrdineMerenda.Location = new System.Drawing.Point(582, 102);
            this.gpbOrdineMerenda.Name = "gpbOrdineMerenda";
            this.gpbOrdineMerenda.Size = new System.Drawing.Size(388, 284);
            this.gpbOrdineMerenda.TabIndex = 4;
            this.gpbOrdineMerenda.TabStop = false;
            this.gpbOrdineMerenda.Text = "Ordina merenda";
            // 
            // btnSendOrdine
            // 
            this.btnSendOrdine.AutoSize = true;
            this.btnSendOrdine.Enabled = false;
            this.btnSendOrdine.Location = new System.Drawing.Point(6, 223);
            this.btnSendOrdine.Name = "btnSendOrdine";
            this.btnSendOrdine.Size = new System.Drawing.Size(376, 55);
            this.btnSendOrdine.TabIndex = 4;
            this.btnSendOrdine.Text = "Invia ordine";
            this.btnSendOrdine.UseVisualStyleBackColor = true;
            this.btnSendOrdine.Click += new System.EventHandler(this.btnSendOrdine_Click);
            // 
            // nudQuantitaMerendaValue
            // 
            this.nudQuantitaMerendaValue.Enabled = false;
            this.nudQuantitaMerendaValue.Location = new System.Drawing.Point(78, 139);
            this.nudQuantitaMerendaValue.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudQuantitaMerendaValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantitaMerendaValue.Name = "nudQuantitaMerendaValue";
            this.nudQuantitaMerendaValue.Size = new System.Drawing.Size(100, 27);
            this.nudQuantitaMerendaValue.TabIndex = 3;
            this.nudQuantitaMerendaValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantitaMerendaValue.ValueChanged += new System.EventHandler(this.nudQuantitaMerendaValue_ValueChanged);
            // 
            // lblQuantitaMerenda
            // 
            this.lblQuantitaMerenda.AutoSize = true;
            this.lblQuantitaMerenda.Location = new System.Drawing.Point(6, 141);
            this.lblQuantitaMerenda.Name = "lblQuantitaMerenda";
            this.lblQuantitaMerenda.Size = new System.Drawing.Size(66, 19);
            this.lblQuantitaMerenda.TabIndex = 2;
            this.lblQuantitaMerenda.Text = "Quantità";
            // 
            // lblCostoTotaleMerendaValue
            // 
            this.lblCostoTotaleMerendaValue.AutoSize = true;
            this.lblCostoTotaleMerendaValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCostoTotaleMerendaValue.Location = new System.Drawing.Point(298, 141);
            this.lblCostoTotaleMerendaValue.Name = "lblCostoTotaleMerendaValue";
            this.lblCostoTotaleMerendaValue.Size = new System.Drawing.Size(2, 21);
            this.lblCostoTotaleMerendaValue.TabIndex = 1;
            // 
            // lblVarianteMerendaValue
            // 
            this.lblVarianteMerendaValue.AutoSize = true;
            this.lblVarianteMerendaValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVarianteMerendaValue.Location = new System.Drawing.Point(75, 92);
            this.lblVarianteMerendaValue.Name = "lblVarianteMerendaValue";
            this.lblVarianteMerendaValue.Size = new System.Drawing.Size(2, 21);
            this.lblVarianteMerendaValue.TabIndex = 1;
            // 
            // lblCostoMerenda
            // 
            this.lblCostoMerenda.AutoSize = true;
            this.lblCostoMerenda.Location = new System.Drawing.Point(204, 141);
            this.lblCostoMerenda.Name = "lblCostoMerenda";
            this.lblCostoMerenda.Size = new System.Drawing.Size(88, 19);
            this.lblCostoMerenda.TabIndex = 0;
            this.lblCostoMerenda.Text = "Costo totale";
            // 
            // lblNomeMerendaValue
            // 
            this.lblNomeMerendaValue.AutoSize = true;
            this.lblNomeMerendaValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomeMerendaValue.Location = new System.Drawing.Point(59, 53);
            this.lblNomeMerendaValue.Name = "lblNomeMerendaValue";
            this.lblNomeMerendaValue.Size = new System.Drawing.Size(2, 21);
            this.lblNomeMerendaValue.TabIndex = 1;
            // 
            // lblVarianteMerenda
            // 
            this.lblVarianteMerenda.AutoSize = true;
            this.lblVarianteMerenda.Location = new System.Drawing.Point(6, 92);
            this.lblVarianteMerenda.Name = "lblVarianteMerenda";
            this.lblVarianteMerenda.Size = new System.Drawing.Size(63, 19);
            this.lblVarianteMerenda.TabIndex = 0;
            this.lblVarianteMerenda.Text = "Variante";
            // 
            // lblNomeMerenda
            // 
            this.lblNomeMerenda.AutoSize = true;
            this.lblNomeMerenda.Location = new System.Drawing.Point(6, 53);
            this.lblNomeMerenda.Name = "lblNomeMerenda";
            this.lblNomeMerenda.Size = new System.Drawing.Size(47, 19);
            this.lblNomeMerenda.TabIndex = 0;
            this.lblNomeMerenda.Text = "Nome";
            // 
            // gpbOrdiniUtenteToday
            // 
            this.gpbOrdiniUtenteToday.Controls.Add(this.lsvOrdiniUtenteToday);
            this.gpbOrdiniUtenteToday.Location = new System.Drawing.Point(582, 392);
            this.gpbOrdiniUtenteToday.Name = "gpbOrdiniUtenteToday";
            this.gpbOrdiniUtenteToday.Size = new System.Drawing.Size(388, 284);
            this.gpbOrdiniUtenteToday.TabIndex = 5;
            this.gpbOrdiniUtenteToday.TabStop = false;
            this.gpbOrdiniUtenteToday.Text = "I tuoi ordini di oggi";
            // 
            // lsvOrdiniUtenteToday
            // 
            this.lsvOrdiniUtenteToday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cmhMerenda,
            this.cmhQuantita,
            this.cmhStato});
            this.lsvOrdiniUtenteToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvOrdiniUtenteToday.FullRowSelect = true;
            this.lsvOrdiniUtenteToday.GridLines = true;
            this.lsvOrdiniUtenteToday.Location = new System.Drawing.Point(3, 23);
            this.lsvOrdiniUtenteToday.MultiSelect = false;
            this.lsvOrdiniUtenteToday.Name = "lsvOrdiniUtenteToday";
            this.lsvOrdiniUtenteToday.Size = new System.Drawing.Size(382, 258);
            this.lsvOrdiniUtenteToday.TabIndex = 0;
            this.lsvOrdiniUtenteToday.UseCompatibleStateImageBehavior = false;
            this.lsvOrdiniUtenteToday.View = System.Windows.Forms.View.Details;
            this.lsvOrdiniUtenteToday.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsv_ColumnWidthChanging);
            // 
            // cmhMerenda
            // 
            this.cmhMerenda.Text = "Merenda";
            this.cmhMerenda.Width = 190;
            // 
            // cmhQuantita
            // 
            this.cmhQuantita.Text = "Quantità";
            this.cmhQuantita.Width = 80;
            // 
            // cmhStato
            // 
            this.cmhStato.Text = "Stato";
            this.cmhStato.Width = 90;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(109, 17);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 29);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            // 
            // lblClasse
            // 
            this.lblClasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClasse.AutoSize = true;
            this.lblClasse.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasse.Location = new System.Drawing.Point(459, 20);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(64, 26);
            this.lblClasse.TabIndex = 7;
            this.lblClasse.Text = "Classe";
            // 
            // StudentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 688);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.gpbOrdiniUtenteToday);
            this.Controls.Add(this.gpbOrdineMerenda);
            this.Controls.Add(this.btnOrdiniClasse);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblMerende);
            this.Controls.Add(this.lsvMerende);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.gpbOrdineMerenda.ResumeLayout(false);
            this.gpbOrdineMerenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantitaMerendaValue)).EndInit();
            this.gpbOrdiniUtenteToday.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvMerende;
        private System.Windows.Forms.Label lblMerende;
        private System.Windows.Forms.ColumnHeader cmhNome;
        private System.Windows.Forms.ColumnHeader cmhVariante;
        private System.Windows.Forms.ColumnHeader cmhCostoUnitario;
        private System.Windows.Forms.ColumnHeader cmhDisponibilita;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer tmrDataRefresh;
        private System.Windows.Forms.Button btnOrdiniClasse;
        private System.Windows.Forms.GroupBox gpbOrdineMerenda;
        private System.Windows.Forms.Label lblNomeMerenda;
        private System.Windows.Forms.Label lblNomeMerendaValue;
        private System.Windows.Forms.Label lblVarianteMerendaValue;
        private System.Windows.Forms.Label lblVarianteMerenda;
        private System.Windows.Forms.Label lblQuantitaMerenda;
        private System.Windows.Forms.NumericUpDown nudQuantitaMerendaValue;
        private System.Windows.Forms.Label lblCostoTotaleMerendaValue;
        private System.Windows.Forms.Label lblCostoMerenda;
        private System.Windows.Forms.Button btnSendOrdine;
        private System.Windows.Forms.ColumnHeader cmhTipo;
        private System.Windows.Forms.GroupBox gpbOrdiniUtenteToday;
        private System.Windows.Forms.ListView lsvOrdiniUtenteToday;
        private System.Windows.Forms.ColumnHeader cmhMerenda;
        private System.Windows.Forms.ColumnHeader cmhStato;
        private System.Windows.Forms.ColumnHeader cmhQuantita;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblClasse;
    }
}