namespace El_Merendero_Massimo_Pavoni
{
    partial class ClassRepresentativeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassRepresentativeForm));
            this.lblClasse = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lsvOrdiniClasseToday = new System.Windows.Forms.ListView();
            this.cmhUtente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhMerenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhQuantita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhCosto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbOrdiniClasse = new System.Windows.Forms.GroupBox();
            this.lblCostoTotaleClasseValue = new System.Windows.Forms.Label();
            this.lblCostoTotaleClasse = new System.Windows.Forms.Label();
            this.btnConfermaOrdini = new System.Windows.Forms.Button();
            this.tmrDataRefresh = new System.Windows.Forms.Timer(this.components);
            this.gpbOrdiniClasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasse.Location = new System.Drawing.Point(105, 17);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(74, 29);
            this.lblClasse.TabIndex = 8;
            this.lblClasse.Text = "Classe";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 39);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Chiudi";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lsvOrdiniClasseToday
            // 
            this.lsvOrdiniClasseToday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cmhUtente,
            this.cmhMerenda,
            this.cmhQuantita,
            this.cmhCosto});
            this.lsvOrdiniClasseToday.FullRowSelect = true;
            this.lsvOrdiniClasseToday.GridLines = true;
            this.lsvOrdiniClasseToday.Location = new System.Drawing.Point(6, 26);
            this.lsvOrdiniClasseToday.MultiSelect = false;
            this.lsvOrdiniClasseToday.Name = "lsvOrdiniClasseToday";
            this.lsvOrdiniClasseToday.Size = new System.Drawing.Size(582, 240);
            this.lsvOrdiniClasseToday.TabIndex = 9;
            this.lsvOrdiniClasseToday.UseCompatibleStateImageBehavior = false;
            this.lsvOrdiniClasseToday.View = System.Windows.Forms.View.Details;
            this.lsvOrdiniClasseToday.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsv_ColumnWidthChanging);
            // 
            // cmhUtente
            // 
            this.cmhUtente.Text = "Utente";
            this.cmhUtente.Width = 200;
            // 
            // cmhMerenda
            // 
            this.cmhMerenda.Text = "Merenda";
            this.cmhMerenda.Width = 200;
            // 
            // cmhQuantita
            // 
            this.cmhQuantita.Text = "Quantità";
            this.cmhQuantita.Width = 80;
            // 
            // cmhCosto
            // 
            this.cmhCosto.Text = "Costo (€)";
            this.cmhCosto.Width = 80;
            // 
            // gpbOrdiniClasse
            // 
            this.gpbOrdiniClasse.Controls.Add(this.lblCostoTotaleClasseValue);
            this.gpbOrdiniClasse.Controls.Add(this.lblCostoTotaleClasse);
            this.gpbOrdiniClasse.Controls.Add(this.btnConfermaOrdini);
            this.gpbOrdiniClasse.Controls.Add(this.lsvOrdiniClasseToday);
            this.gpbOrdiniClasse.Location = new System.Drawing.Point(12, 57);
            this.gpbOrdiniClasse.Name = "gpbOrdiniClasse";
            this.gpbOrdiniClasse.Size = new System.Drawing.Size(594, 317);
            this.gpbOrdiniClasse.TabIndex = 10;
            this.gpbOrdiniClasse.TabStop = false;
            this.gpbOrdiniClasse.Text = "Ordini della classe di oggi";
            // 
            // lblCostoTotaleClasseValue
            // 
            this.lblCostoTotaleClasseValue.AutoSize = true;
            this.lblCostoTotaleClasseValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCostoTotaleClasseValue.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotaleClasseValue.Location = new System.Drawing.Point(442, 277);
            this.lblCostoTotaleClasseValue.Name = "lblCostoTotaleClasseValue";
            this.lblCostoTotaleClasseValue.Size = new System.Drawing.Size(2, 31);
            this.lblCostoTotaleClasseValue.TabIndex = 12;
            // 
            // lblCostoTotaleClasse
            // 
            this.lblCostoTotaleClasse.AutoSize = true;
            this.lblCostoTotaleClasse.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotaleClasse.Location = new System.Drawing.Point(297, 277);
            this.lblCostoTotaleClasse.Name = "lblCostoTotaleClasse";
            this.lblCostoTotaleClasse.Size = new System.Drawing.Size(139, 29);
            this.lblCostoTotaleClasse.TabIndex = 11;
            this.lblCostoTotaleClasse.Text = "Costo totale:";
            // 
            // btnConfermaOrdini
            // 
            this.btnConfermaOrdini.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfermaOrdini.Enabled = false;
            this.btnConfermaOrdini.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfermaOrdini.Location = new System.Drawing.Point(6, 272);
            this.btnConfermaOrdini.Name = "btnConfermaOrdini";
            this.btnConfermaOrdini.Size = new System.Drawing.Size(180, 39);
            this.btnConfermaOrdini.TabIndex = 10;
            this.btnConfermaOrdini.Text = "Conferma";
            this.btnConfermaOrdini.UseVisualStyleBackColor = true;
            this.btnConfermaOrdini.Click += new System.EventHandler(this.btnConfermaOrdini_Click);
            // 
            // tmrDataRefresh
            // 
            this.tmrDataRefresh.Enabled = true;
            this.tmrDataRefresh.Interval = 16000;
            this.tmrDataRefresh.Tick += new System.EventHandler(this.tmrDataRefresh_Tick);
            // 
            // ClassRepresentativeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(618, 386);
            this.Controls.Add(this.gpbOrdiniClasse);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClassRepresentativeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClassRepresentativeForm_FormClosing);
            this.Load += new System.EventHandler(this.ClassRepresentativeForm_Load);
            this.gpbOrdiniClasse.ResumeLayout(false);
            this.gpbOrdiniClasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lsvOrdiniClasseToday;
        private System.Windows.Forms.GroupBox gpbOrdiniClasse;
        private System.Windows.Forms.ColumnHeader cmhUtente;
        private System.Windows.Forms.ColumnHeader cmhMerenda;
        private System.Windows.Forms.ColumnHeader cmhQuantita;
        private System.Windows.Forms.Button btnConfermaOrdini;
        private System.Windows.Forms.Label lblCostoTotaleClasse;
        private System.Windows.Forms.ColumnHeader cmhCosto;
        private System.Windows.Forms.Timer tmrDataRefresh;
        private System.Windows.Forms.Label lblCostoTotaleClasseValue;
    }
}