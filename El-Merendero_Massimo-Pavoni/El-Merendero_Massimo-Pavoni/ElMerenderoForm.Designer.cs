namespace El_Merendero_Massimo_Pavoni
{
    partial class ElMerenderoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElMerenderoForm));
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tbcOrdini = new System.Windows.Forms.TabControl();
            this.tbpOrdiniByClasse = new System.Windows.Forms.TabPage();
            this.cmbClassi = new System.Windows.Forms.ComboBox();
            this.lsvOrdiniByClasse = new System.Windows.Forms.ListView();
            this.cmhUtente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhMerenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhQuantita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhCosto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpOrdiniByMerenda = new System.Windows.Forms.TabPage();
            this.lsvOrdiniByMerenda = new System.Windows.Forms.ListView();
            this.cmhNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhVariante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhTotalQuantita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhTotalCosto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbOrdini = new System.Windows.Forms.GroupBox();
            this.tmrDataRefresh = new System.Windows.Forms.Timer(this.components);
            this.gpbMerende = new System.Windows.Forms.GroupBox();
            this.gpbMerenda = new System.Windows.Forms.GroupBox();
            this.btnInsertMerenda = new System.Windows.Forms.Button();
            this.btnMerendaAction = new System.Windows.Forms.Button();
            this.nudDisponibilitaMerendaValue = new System.Windows.Forms.NumericUpDown();
            this.nudCostoUnitarioMerendaValue = new System.Windows.Forms.NumericUpDown();
            this.lblCostoUnitarioMerendaSymbol = new System.Windows.Forms.Label();
            this.lblCostoUnitarioMerenda = new System.Windows.Forms.Label();
            this.lblDisponibilitaMerenda = new System.Windows.Forms.Label();
            this.cmbTipoMerendaValue = new System.Windows.Forms.ComboBox();
            this.lblTipoMerenda = new System.Windows.Forms.Label();
            this.txbNomeMerendaValue = new System.Windows.Forms.TextBox();
            this.txbVarianteMerendaValue = new System.Windows.Forms.TextBox();
            this.lblVarianteMerenda = new System.Windows.Forms.Label();
            this.lblNomeMerenda = new System.Windows.Forms.Label();
            this.lsvMerende = new System.Windows.Forms.ListView();
            this.cmhNomeMerenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhVarianteMerenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhTipoMerenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhCostoMerenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhDisponibilitaMerenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpEndInsertOrdine = new System.Windows.Forms.DateTimePicker();
            this.lblEndInsertOrdine = new System.Windows.Forms.Label();
            this.lblEndConfirmOrdini = new System.Windows.Forms.Label();
            this.dtpEndConfirmOrdini = new System.Windows.Forms.DateTimePicker();
            this.lblTotalClasseValue = new System.Windows.Forms.Label();
            this.lblTotalClasse = new System.Windows.Forms.Label();
            this.tbcOrdini.SuspendLayout();
            this.tbpOrdiniByClasse.SuspendLayout();
            this.tbpOrdiniByMerenda.SuspendLayout();
            this.gpbOrdini.SuspendLayout();
            this.gpbMerende.SuspendLayout();
            this.gpbMerenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDisponibilitaMerendaValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoUnitarioMerendaValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(109, 17);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 29);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username";
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 39);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tbcOrdini
            // 
            this.tbcOrdini.Controls.Add(this.tbpOrdiniByClasse);
            this.tbcOrdini.Controls.Add(this.tbpOrdiniByMerenda);
            this.tbcOrdini.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcOrdini.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbcOrdini.Location = new System.Drawing.Point(3, 30);
            this.tbcOrdini.Name = "tbcOrdini";
            this.tbcOrdini.SelectedIndex = 0;
            this.tbcOrdini.Size = new System.Drawing.Size(594, 459);
            this.tbcOrdini.TabIndex = 9;
            // 
            // tbpOrdiniByClasse
            // 
            this.tbpOrdiniByClasse.Controls.Add(this.lblTotalClasseValue);
            this.tbpOrdiniByClasse.Controls.Add(this.lblTotalClasse);
            this.tbpOrdiniByClasse.Controls.Add(this.cmbClassi);
            this.tbpOrdiniByClasse.Controls.Add(this.lsvOrdiniByClasse);
            this.tbpOrdiniByClasse.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbpOrdiniByClasse.Location = new System.Drawing.Point(4, 35);
            this.tbpOrdiniByClasse.Name = "tbpOrdiniByClasse";
            this.tbpOrdiniByClasse.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOrdiniByClasse.Size = new System.Drawing.Size(586, 420);
            this.tbpOrdiniByClasse.TabIndex = 0;
            this.tbpOrdiniByClasse.Text = "Per classe";
            this.tbpOrdiniByClasse.UseVisualStyleBackColor = true;
            // 
            // cmbClassi
            // 
            this.cmbClassi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassi.FormattingEnabled = true;
            this.cmbClassi.Location = new System.Drawing.Point(6, 6);
            this.cmbClassi.Name = "cmbClassi";
            this.cmbClassi.Size = new System.Drawing.Size(200, 27);
            this.cmbClassi.TabIndex = 1;
            this.cmbClassi.SelectedIndexChanged += new System.EventHandler(this.cmbClassi_SelectedIndexChanged);
            // 
            // lsvOrdiniByClasse
            // 
            this.lsvOrdiniByClasse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvOrdiniByClasse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cmhUtente,
            this.cmhMerenda,
            this.cmhQuantita,
            this.cmhCosto});
            this.lsvOrdiniByClasse.FullRowSelect = true;
            this.lsvOrdiniByClasse.GridLines = true;
            this.lsvOrdiniByClasse.Location = new System.Drawing.Point(6, 39);
            this.lsvOrdiniByClasse.MultiSelect = false;
            this.lsvOrdiniByClasse.Name = "lsvOrdiniByClasse";
            this.lsvOrdiniByClasse.Size = new System.Drawing.Size(574, 375);
            this.lsvOrdiniByClasse.TabIndex = 0;
            this.lsvOrdiniByClasse.UseCompatibleStateImageBehavior = false;
            this.lsvOrdiniByClasse.View = System.Windows.Forms.View.Details;
            this.lsvOrdiniByClasse.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsv_ColumnWidthChanging);
            // 
            // cmhUtente
            // 
            this.cmhUtente.Text = "Utente";
            this.cmhUtente.Width = 190;
            // 
            // cmhMerenda
            // 
            this.cmhMerenda.Text = "Merenda";
            this.cmhMerenda.Width = 210;
            // 
            // cmhQuantita
            // 
            this.cmhQuantita.Text = "Quantità";
            this.cmhQuantita.Width = 72;
            // 
            // cmhCosto
            // 
            this.cmhCosto.Text = "Costo (€)";
            this.cmhCosto.Width = 80;
            // 
            // tbpOrdiniByMerenda
            // 
            this.tbpOrdiniByMerenda.Controls.Add(this.lsvOrdiniByMerenda);
            this.tbpOrdiniByMerenda.Font = new System.Drawing.Font("Calibri", 12F);
            this.tbpOrdiniByMerenda.Location = new System.Drawing.Point(4, 35);
            this.tbpOrdiniByMerenda.Name = "tbpOrdiniByMerenda";
            this.tbpOrdiniByMerenda.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOrdiniByMerenda.Size = new System.Drawing.Size(586, 420);
            this.tbpOrdiniByMerenda.TabIndex = 1;
            this.tbpOrdiniByMerenda.Text = "Per merenda";
            this.tbpOrdiniByMerenda.UseVisualStyleBackColor = true;
            // 
            // lsvOrdiniByMerenda
            // 
            this.lsvOrdiniByMerenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cmhNome,
            this.cmhVariante,
            this.cmhTipo,
            this.cmhTotalQuantita,
            this.cmhTotalCosto});
            this.lsvOrdiniByMerenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvOrdiniByMerenda.FullRowSelect = true;
            this.lsvOrdiniByMerenda.GridLines = true;
            this.lsvOrdiniByMerenda.Location = new System.Drawing.Point(3, 3);
            this.lsvOrdiniByMerenda.MultiSelect = false;
            this.lsvOrdiniByMerenda.Name = "lsvOrdiniByMerenda";
            this.lsvOrdiniByMerenda.Size = new System.Drawing.Size(580, 414);
            this.lsvOrdiniByMerenda.TabIndex = 1;
            this.lsvOrdiniByMerenda.UseCompatibleStateImageBehavior = false;
            this.lsvOrdiniByMerenda.View = System.Windows.Forms.View.Details;
            this.lsvOrdiniByMerenda.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsv_ColumnWidthChanging);
            // 
            // cmhNome
            // 
            this.cmhNome.Text = "Nome";
            this.cmhNome.Width = 160;
            // 
            // cmhVariante
            // 
            this.cmhVariante.Text = "Variante";
            this.cmhVariante.Width = 160;
            // 
            // cmhTipo
            // 
            this.cmhTipo.Text = "Tipo";
            this.cmhTipo.Width = 80;
            // 
            // cmhTotalQuantita
            // 
            this.cmhTotalQuantita.Text = "Quantità";
            this.cmhTotalQuantita.Width = 72;
            // 
            // cmhTotalCosto
            // 
            this.cmhTotalCosto.Text = "Costo (€)";
            this.cmhTotalCosto.Width = 80;
            // 
            // gpbOrdini
            // 
            this.gpbOrdini.Controls.Add(this.tbcOrdini);
            this.gpbOrdini.Font = new System.Drawing.Font("Calibri", 16F);
            this.gpbOrdini.Location = new System.Drawing.Point(12, 57);
            this.gpbOrdini.Name = "gpbOrdini";
            this.gpbOrdini.Size = new System.Drawing.Size(600, 492);
            this.gpbOrdini.TabIndex = 10;
            this.gpbOrdini.TabStop = false;
            this.gpbOrdini.Text = "Ordini";
            // 
            // tmrDataRefresh
            // 
            this.tmrDataRefresh.Enabled = true;
            this.tmrDataRefresh.Interval = 16000;
            this.tmrDataRefresh.Tick += new System.EventHandler(this.tmrDataRefresh_Tick);
            // 
            // gpbMerende
            // 
            this.gpbMerende.Controls.Add(this.gpbMerenda);
            this.gpbMerende.Controls.Add(this.lsvMerende);
            this.gpbMerende.Font = new System.Drawing.Font("Calibri", 16F);
            this.gpbMerende.Location = new System.Drawing.Point(618, 57);
            this.gpbMerende.Name = "gpbMerende";
            this.gpbMerende.Size = new System.Drawing.Size(554, 492);
            this.gpbMerende.TabIndex = 12;
            this.gpbMerende.TabStop = false;
            this.gpbMerende.Text = "Merende";
            // 
            // gpbMerenda
            // 
            this.gpbMerenda.Controls.Add(this.btnInsertMerenda);
            this.gpbMerenda.Controls.Add(this.btnMerendaAction);
            this.gpbMerenda.Controls.Add(this.nudDisponibilitaMerendaValue);
            this.gpbMerenda.Controls.Add(this.nudCostoUnitarioMerendaValue);
            this.gpbMerenda.Controls.Add(this.lblCostoUnitarioMerendaSymbol);
            this.gpbMerenda.Controls.Add(this.lblCostoUnitarioMerenda);
            this.gpbMerenda.Controls.Add(this.lblDisponibilitaMerenda);
            this.gpbMerenda.Controls.Add(this.cmbTipoMerendaValue);
            this.gpbMerenda.Controls.Add(this.lblTipoMerenda);
            this.gpbMerenda.Controls.Add(this.txbNomeMerendaValue);
            this.gpbMerenda.Controls.Add(this.txbVarianteMerendaValue);
            this.gpbMerenda.Controls.Add(this.lblVarianteMerenda);
            this.gpbMerenda.Controls.Add(this.lblNomeMerenda);
            this.gpbMerenda.Font = new System.Drawing.Font("Calibri", 14F);
            this.gpbMerenda.Location = new System.Drawing.Point(6, 33);
            this.gpbMerenda.Name = "gpbMerenda";
            this.gpbMerenda.Size = new System.Drawing.Size(542, 207);
            this.gpbMerenda.TabIndex = 7;
            this.gpbMerenda.TabStop = false;
            this.gpbMerenda.Text = "Merenda";
            // 
            // btnInsertMerenda
            // 
            this.btnInsertMerenda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInsertMerenda.AutoSize = true;
            this.btnInsertMerenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertMerenda.Location = new System.Drawing.Point(270, 168);
            this.btnInsertMerenda.Name = "btnInsertMerenda";
            this.btnInsertMerenda.Size = new System.Drawing.Size(86, 33);
            this.btnInsertMerenda.TabIndex = 14;
            this.btnInsertMerenda.Text = "Aggiungi";
            this.btnInsertMerenda.UseVisualStyleBackColor = true;
            this.btnInsertMerenda.Click += new System.EventHandler(this.btnInsertMerenda_Click);
            // 
            // btnMerendaAction
            // 
            this.btnMerendaAction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMerendaAction.AutoSize = true;
            this.btnMerendaAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMerendaAction.Enabled = false;
            this.btnMerendaAction.Location = new System.Drawing.Point(362, 168);
            this.btnMerendaAction.Name = "btnMerendaAction";
            this.btnMerendaAction.Size = new System.Drawing.Size(75, 33);
            this.btnMerendaAction.TabIndex = 13;
            this.btnMerendaAction.Text = "Elimina";
            this.btnMerendaAction.UseVisualStyleBackColor = true;
            this.btnMerendaAction.Click += new System.EventHandler(this.btnMerendaAction_Click);
            // 
            // nudDisponibilitaMerendaValue
            // 
            this.nudDisponibilitaMerendaValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDisponibilitaMerendaValue.Location = new System.Drawing.Point(408, 107);
            this.nudDisponibilitaMerendaValue.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudDisponibilitaMerendaValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDisponibilitaMerendaValue.Name = "nudDisponibilitaMerendaValue";
            this.nudDisponibilitaMerendaValue.Size = new System.Drawing.Size(90, 27);
            this.nudDisponibilitaMerendaValue.TabIndex = 12;
            this.nudDisponibilitaMerendaValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDisponibilitaMerendaValue.ValueChanged += new System.EventHandler(this.merendaView_SomethingChanged);
            // 
            // nudCostoUnitarioMerendaValue
            // 
            this.nudCostoUnitarioMerendaValue.DecimalPlaces = 2;
            this.nudCostoUnitarioMerendaValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCostoUnitarioMerendaValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudCostoUnitarioMerendaValue.Location = new System.Drawing.Point(417, 54);
            this.nudCostoUnitarioMerendaValue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nudCostoUnitarioMerendaValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudCostoUnitarioMerendaValue.Name = "nudCostoUnitarioMerendaValue";
            this.nudCostoUnitarioMerendaValue.Size = new System.Drawing.Size(90, 27);
            this.nudCostoUnitarioMerendaValue.TabIndex = 11;
            this.nudCostoUnitarioMerendaValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudCostoUnitarioMerendaValue.ValueChanged += new System.EventHandler(this.merendaView_SomethingChanged);
            // 
            // lblCostoUnitarioMerendaSymbol
            // 
            this.lblCostoUnitarioMerendaSymbol.AutoSize = true;
            this.lblCostoUnitarioMerendaSymbol.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblCostoUnitarioMerendaSymbol.Location = new System.Drawing.Point(513, 56);
            this.lblCostoUnitarioMerendaSymbol.Name = "lblCostoUnitarioMerendaSymbol";
            this.lblCostoUnitarioMerendaSymbol.Size = new System.Drawing.Size(17, 19);
            this.lblCostoUnitarioMerendaSymbol.TabIndex = 10;
            this.lblCostoUnitarioMerendaSymbol.Text = "€";
            // 
            // lblCostoUnitarioMerenda
            // 
            this.lblCostoUnitarioMerenda.AutoSize = true;
            this.lblCostoUnitarioMerenda.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblCostoUnitarioMerenda.Location = new System.Drawing.Point(311, 56);
            this.lblCostoUnitarioMerenda.Name = "lblCostoUnitarioMerenda";
            this.lblCostoUnitarioMerenda.Size = new System.Drawing.Size(100, 19);
            this.lblCostoUnitarioMerenda.TabIndex = 10;
            this.lblCostoUnitarioMerenda.Text = "Costo unitario";
            // 
            // lblDisponibilitaMerenda
            // 
            this.lblDisponibilitaMerenda.AutoSize = true;
            this.lblDisponibilitaMerenda.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDisponibilitaMerenda.Location = new System.Drawing.Point(311, 109);
            this.lblDisponibilitaMerenda.Name = "lblDisponibilitaMerenda";
            this.lblDisponibilitaMerenda.Size = new System.Drawing.Size(91, 19);
            this.lblDisponibilitaMerenda.TabIndex = 9;
            this.lblDisponibilitaMerenda.Text = "Disponibilità";
            // 
            // cmbTipoMerendaValue
            // 
            this.cmbTipoMerendaValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMerendaValue.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmbTipoMerendaValue.FormattingEnabled = true;
            this.cmbTipoMerendaValue.Location = new System.Drawing.Point(49, 159);
            this.cmbTipoMerendaValue.Name = "cmbTipoMerendaValue";
            this.cmbTipoMerendaValue.Size = new System.Drawing.Size(100, 27);
            this.cmbTipoMerendaValue.TabIndex = 8;
            this.cmbTipoMerendaValue.SelectedIndexChanged += new System.EventHandler(this.merendaView_SomethingChanged);
            // 
            // lblTipoMerenda
            // 
            this.lblTipoMerenda.AutoSize = true;
            this.lblTipoMerenda.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblTipoMerenda.Location = new System.Drawing.Point(6, 162);
            this.lblTipoMerenda.Name = "lblTipoMerenda";
            this.lblTipoMerenda.Size = new System.Drawing.Size(37, 19);
            this.lblTipoMerenda.TabIndex = 7;
            this.lblTipoMerenda.Text = "Tipo";
            // 
            // txbNomeMerendaValue
            // 
            this.txbNomeMerendaValue.Font = new System.Drawing.Font("Calibri", 12F);
            this.txbNomeMerendaValue.Location = new System.Drawing.Point(59, 53);
            this.txbNomeMerendaValue.MaxLength = 20;
            this.txbNomeMerendaValue.Name = "txbNomeMerendaValue";
            this.txbNomeMerendaValue.Size = new System.Drawing.Size(200, 27);
            this.txbNomeMerendaValue.TabIndex = 4;
            this.txbNomeMerendaValue.TextChanged += new System.EventHandler(this.merendaView_SomethingChanged);
            // 
            // txbVarianteMerendaValue
            // 
            this.txbVarianteMerendaValue.Font = new System.Drawing.Font("Calibri", 12F);
            this.txbVarianteMerendaValue.Location = new System.Drawing.Point(75, 106);
            this.txbVarianteMerendaValue.MaxLength = 20;
            this.txbVarianteMerendaValue.Name = "txbVarianteMerendaValue";
            this.txbVarianteMerendaValue.Size = new System.Drawing.Size(200, 27);
            this.txbVarianteMerendaValue.TabIndex = 6;
            this.txbVarianteMerendaValue.TextChanged += new System.EventHandler(this.merendaView_SomethingChanged);
            // 
            // lblVarianteMerenda
            // 
            this.lblVarianteMerenda.AutoSize = true;
            this.lblVarianteMerenda.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblVarianteMerenda.Location = new System.Drawing.Point(6, 109);
            this.lblVarianteMerenda.Name = "lblVarianteMerenda";
            this.lblVarianteMerenda.Size = new System.Drawing.Size(63, 19);
            this.lblVarianteMerenda.TabIndex = 5;
            this.lblVarianteMerenda.Text = "Variante";
            // 
            // lblNomeMerenda
            // 
            this.lblNomeMerenda.AutoSize = true;
            this.lblNomeMerenda.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNomeMerenda.Location = new System.Drawing.Point(6, 56);
            this.lblNomeMerenda.Name = "lblNomeMerenda";
            this.lblNomeMerenda.Size = new System.Drawing.Size(47, 19);
            this.lblNomeMerenda.TabIndex = 3;
            this.lblNomeMerenda.Text = "Nome";
            // 
            // lsvMerende
            // 
            this.lsvMerende.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvMerende.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cmhNomeMerenda,
            this.cmhVarianteMerenda,
            this.cmhTipoMerenda,
            this.cmhCostoMerenda,
            this.cmhDisponibilitaMerenda});
            this.lsvMerende.Font = new System.Drawing.Font("Calibri", 12F);
            this.lsvMerende.FullRowSelect = true;
            this.lsvMerende.GridLines = true;
            this.lsvMerende.Location = new System.Drawing.Point(6, 246);
            this.lsvMerende.MultiSelect = false;
            this.lsvMerende.Name = "lsvMerende";
            this.lsvMerende.Size = new System.Drawing.Size(542, 240);
            this.lsvMerende.TabIndex = 2;
            this.lsvMerende.UseCompatibleStateImageBehavior = false;
            this.lsvMerende.View = System.Windows.Forms.View.Details;
            this.lsvMerende.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsv_ColumnWidthChanging);
            this.lsvMerende.SelectedIndexChanged += new System.EventHandler(this.lsvMerende_SelectedIndexChanged);
            // 
            // cmhNomeMerenda
            // 
            this.cmhNomeMerenda.Text = "Nome";
            this.cmhNomeMerenda.Width = 130;
            // 
            // cmhVarianteMerenda
            // 
            this.cmhVarianteMerenda.Text = "Variante";
            this.cmhVarianteMerenda.Width = 130;
            // 
            // cmhTipoMerenda
            // 
            this.cmhTipoMerenda.Text = "Tipo";
            this.cmhTipoMerenda.Width = 80;
            // 
            // cmhCostoMerenda
            // 
            this.cmhCostoMerenda.Text = "Costo (€)";
            this.cmhCostoMerenda.Width = 72;
            // 
            // cmhDisponibilitaMerenda
            // 
            this.cmhDisponibilitaMerenda.Text = "Disponibilità";
            this.cmhDisponibilitaMerenda.Width = 108;
            // 
            // dtpEndInsertOrdine
            // 
            this.dtpEndInsertOrdine.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndInsertOrdine.Location = new System.Drawing.Point(796, 19);
            this.dtpEndInsertOrdine.Name = "dtpEndInsertOrdine";
            this.dtpEndInsertOrdine.ShowUpDown = true;
            this.dtpEndInsertOrdine.Size = new System.Drawing.Size(100, 27);
            this.dtpEndInsertOrdine.TabIndex = 13;
            this.dtpEndInsertOrdine.ValueChanged += new System.EventHandler(this.dtpEndInsertOrdine_ValueChanged);
            // 
            // lblEndInsertOrdine
            // 
            this.lblEndInsertOrdine.AutoSize = true;
            this.lblEndInsertOrdine.Location = new System.Drawing.Point(616, 25);
            this.lblEndInsertOrdine.Name = "lblEndInsertOrdine";
            this.lblEndInsertOrdine.Size = new System.Drawing.Size(174, 19);
            this.lblEndInsertOrdine.TabIndex = 14;
            this.lblEndInsertOrdine.Text = "Limite orario per ordinare";
            // 
            // lblEndConfirmOrdini
            // 
            this.lblEndConfirmOrdini.AutoSize = true;
            this.lblEndConfirmOrdini.Location = new System.Drawing.Point(902, 25);
            this.lblEndConfirmOrdini.Name = "lblEndConfirmOrdini";
            this.lblEndConfirmOrdini.Size = new System.Drawing.Size(164, 19);
            this.lblEndConfirmOrdini.TabIndex = 16;
            this.lblEndConfirmOrdini.Text = "Limite orario per ritirare";
            // 
            // dtpEndConfirmOrdini
            // 
            this.dtpEndConfirmOrdini.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndConfirmOrdini.Location = new System.Drawing.Point(1072, 19);
            this.dtpEndConfirmOrdini.Name = "dtpEndConfirmOrdini";
            this.dtpEndConfirmOrdini.ShowUpDown = true;
            this.dtpEndConfirmOrdini.Size = new System.Drawing.Size(100, 27);
            this.dtpEndConfirmOrdini.TabIndex = 15;
            this.dtpEndConfirmOrdini.ValueChanged += new System.EventHandler(this.dtpEndConfirmOrdini_ValueChanged);
            // 
            // lblTotalClasseValue
            // 
            this.lblTotalClasseValue.AutoSize = true;
            this.lblTotalClasseValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalClasseValue.Location = new System.Drawing.Point(367, 9);
            this.lblTotalClasseValue.Name = "lblTotalClasseValue";
            this.lblTotalClasseValue.Size = new System.Drawing.Size(31, 21);
            this.lblTotalClasseValue.TabIndex = 5;
            this.lblTotalClasseValue.Text = "0 €";
            // 
            // lblTotalClasse
            // 
            this.lblTotalClasse.AutoSize = true;
            this.lblTotalClasse.Location = new System.Drawing.Point(312, 9);
            this.lblTotalClasse.Name = "lblTotalClasse";
            this.lblTotalClasse.Size = new System.Drawing.Size(49, 19);
            this.lblTotalClasse.TabIndex = 4;
            this.lblTotalClasse.Text = "Totale";
            // 
            // ElMerenderoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lblEndConfirmOrdini);
            this.Controls.Add(this.dtpEndConfirmOrdini);
            this.Controls.Add(this.lblEndInsertOrdine);
            this.Controls.Add(this.dtpEndInsertOrdine);
            this.Controls.Add(this.gpbMerende);
            this.Controls.Add(this.gpbOrdini);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogout);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ElMerenderoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ElMerenderoForm_FormClosing);
            this.Load += new System.EventHandler(this.ElMerenderoForm_Load);
            this.tbcOrdini.ResumeLayout(false);
            this.tbpOrdiniByClasse.ResumeLayout(false);
            this.tbpOrdiniByClasse.PerformLayout();
            this.tbpOrdiniByMerenda.ResumeLayout(false);
            this.gpbOrdini.ResumeLayout(false);
            this.gpbMerende.ResumeLayout(false);
            this.gpbMerenda.ResumeLayout(false);
            this.gpbMerenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDisponibilitaMerendaValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoUnitarioMerendaValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tbcOrdini;
        private System.Windows.Forms.TabPage tbpOrdiniByClasse;
        private System.Windows.Forms.TabPage tbpOrdiniByMerenda;
        private System.Windows.Forms.GroupBox gpbOrdini;
        private System.Windows.Forms.ListView lsvOrdiniByClasse;
        private System.Windows.Forms.ComboBox cmbClassi;
        private System.Windows.Forms.ColumnHeader cmhUtente;
        private System.Windows.Forms.ColumnHeader cmhMerenda;
        private System.Windows.Forms.ColumnHeader cmhQuantita;
        private System.Windows.Forms.ColumnHeader cmhCosto;
        private System.Windows.Forms.ListView lsvOrdiniByMerenda;
        private System.Windows.Forms.ColumnHeader cmhNome;
        private System.Windows.Forms.ColumnHeader cmhTotalQuantita;
        private System.Windows.Forms.ColumnHeader cmhTotalCosto;
        private System.Windows.Forms.ColumnHeader cmhTipo;
        private System.Windows.Forms.ColumnHeader cmhVariante;
        private System.Windows.Forms.Timer tmrDataRefresh;
        private System.Windows.Forms.GroupBox gpbMerende;
        private System.Windows.Forms.ListView lsvMerende;
        private System.Windows.Forms.ColumnHeader cmhNomeMerenda;
        private System.Windows.Forms.ColumnHeader cmhVarianteMerenda;
        private System.Windows.Forms.ColumnHeader cmhTipoMerenda;
        private System.Windows.Forms.ColumnHeader cmhCostoMerenda;
        private System.Windows.Forms.ColumnHeader cmhDisponibilitaMerenda;
        private System.Windows.Forms.Label lblNomeMerenda;
        private System.Windows.Forms.TextBox txbNomeMerendaValue;
        private System.Windows.Forms.TextBox txbVarianteMerendaValue;
        private System.Windows.Forms.Label lblVarianteMerenda;
        private System.Windows.Forms.GroupBox gpbMerenda;
        private System.Windows.Forms.ComboBox cmbTipoMerendaValue;
        private System.Windows.Forms.Label lblTipoMerenda;
        private System.Windows.Forms.Label lblDisponibilitaMerenda;
        private System.Windows.Forms.Label lblCostoUnitarioMerenda;
        private System.Windows.Forms.NumericUpDown nudCostoUnitarioMerendaValue;
        private System.Windows.Forms.NumericUpDown nudDisponibilitaMerendaValue;
        private System.Windows.Forms.Button btnMerendaAction;
        private System.Windows.Forms.Label lblCostoUnitarioMerendaSymbol;
        private System.Windows.Forms.Button btnInsertMerenda;
        private System.Windows.Forms.DateTimePicker dtpEndInsertOrdine;
        private System.Windows.Forms.Label lblEndInsertOrdine;
        private System.Windows.Forms.Label lblEndConfirmOrdini;
        private System.Windows.Forms.DateTimePicker dtpEndConfirmOrdini;
        private System.Windows.Forms.Label lblTotalClasseValue;
        private System.Windows.Forms.Label lblTotalClasse;
    }
}