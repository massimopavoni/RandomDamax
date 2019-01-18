namespace Gestione_Magazzino_Massimo_Pavoni
{
    partial class NuovoFornitore
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
            this.txbCognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblRagioneSociale = new System.Windows.Forms.Label();
            this.txbRagioneSociale = new System.Windows.Forms.TextBox();
            this.lblRuolo = new System.Windows.Forms.Label();
            this.txbRuolo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbCognome
            // 
            this.txbCognome.Location = new System.Drawing.Point(12, 36);
            this.txbCognome.Name = "txbCognome";
            this.txbCognome.Size = new System.Drawing.Size(160, 32);
            this.txbCognome.TabIndex = 1;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(12, 9);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(89, 24);
            this.lblCognome.TabIndex = 0;
            this.lblCognome.Text = "Cognome";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.AutoSize = true;
            this.btnAggiungi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAggiungi.Location = new System.Drawing.Point(12, 176);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(91, 34);
            this.btnAggiungi.TabIndex = 8;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(178, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 24);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(178, 36);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(160, 32);
            this.txbNome.TabIndex = 3;
            // 
            // lblRagioneSociale
            // 
            this.lblRagioneSociale.AutoSize = true;
            this.lblRagioneSociale.Location = new System.Drawing.Point(12, 91);
            this.lblRagioneSociale.Name = "lblRagioneSociale";
            this.lblRagioneSociale.Size = new System.Drawing.Size(140, 24);
            this.lblRagioneSociale.TabIndex = 4;
            this.lblRagioneSociale.Text = "Ragione Sociale";
            // 
            // txbRagioneSociale
            // 
            this.txbRagioneSociale.Location = new System.Drawing.Point(12, 118);
            this.txbRagioneSociale.Name = "txbRagioneSociale";
            this.txbRagioneSociale.Size = new System.Drawing.Size(160, 32);
            this.txbRagioneSociale.TabIndex = 5;
            // 
            // lblRuolo
            // 
            this.lblRuolo.AutoSize = true;
            this.lblRuolo.Location = new System.Drawing.Point(178, 91);
            this.lblRuolo.Name = "lblRuolo";
            this.lblRuolo.Size = new System.Drawing.Size(59, 24);
            this.lblRuolo.TabIndex = 6;
            this.lblRuolo.Text = "Ruolo";
            // 
            // txbRuolo
            // 
            this.txbRuolo.Location = new System.Drawing.Point(178, 118);
            this.txbRuolo.Name = "txbRuolo";
            this.txbRuolo.Size = new System.Drawing.Size(160, 32);
            this.txbRuolo.TabIndex = 7;
            // 
            // NuovoFornitore
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(350, 222);
            this.Controls.Add(this.lblRuolo);
            this.Controls.Add(this.txbRuolo);
            this.Controls.Add(this.lblRagioneSociale);
            this.Controls.Add(this.txbRagioneSociale);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txbCognome);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuovoFornitore";
            this.ShowIcon = false;
            this.Text = "Nuovo Fornitore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCognome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblRagioneSociale;
        private System.Windows.Forms.TextBox txbRagioneSociale;
        private System.Windows.Forms.Label lblRuolo;
        private System.Windows.Forms.TextBox txbRuolo;
    }
}