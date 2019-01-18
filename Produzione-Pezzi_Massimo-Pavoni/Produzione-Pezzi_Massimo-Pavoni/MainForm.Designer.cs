namespace Produzione_Pezzi_Massimo_Pavoni
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
            this.lvPezzi = new System.Windows.Forms.ListView();
            this.chMatricola = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAltezzza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLarghezza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProfondita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPezziTotali = new System.Windows.Forms.Button();
            this.btnPezziALTA_Q = new System.Windows.Forms.Button();
            this.btnPezziBASSA_Q = new System.Windows.Forms.Button();
            this.btnPezziSCARTO = new System.Windows.Forms.Button();
            this.lblNumeroDiPezzi = new System.Windows.Forms.Label();
            this.lblNumeroPezzi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvPezzi
            // 
            this.lvPezzi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvPezzi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMatricola,
            this.chTipo,
            this.chAltezzza,
            this.chLarghezza,
            this.chProfondita});
            this.lvPezzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPezzi.FullRowSelect = true;
            this.lvPezzi.GridLines = true;
            this.lvPezzi.Location = new System.Drawing.Point(12, 12);
            this.lvPezzi.MultiSelect = false;
            this.lvPezzi.Name = "lvPezzi";
            this.lvPezzi.Size = new System.Drawing.Size(582, 529);
            this.lvPezzi.TabIndex = 0;
            this.lvPezzi.UseCompatibleStateImageBehavior = false;
            this.lvPezzi.View = System.Windows.Forms.View.Details;
            // 
            // chMatricola
            // 
            this.chMatricola.Text = "Matricola";
            this.chMatricola.Width = 90;
            // 
            // chTipo
            // 
            this.chTipo.Text = "Tipo";
            this.chTipo.Width = 50;
            // 
            // chAltezzza
            // 
            this.chAltezzza.Text = "Altezza";
            this.chAltezzza.Width = 140;
            // 
            // chLarghezza
            // 
            this.chLarghezza.Text = "Larghezza";
            this.chLarghezza.Width = 140;
            // 
            // chProfondita
            // 
            this.chProfondita.Text = "Profondità";
            this.chProfondita.Width = 140;
            // 
            // btnPezziTotali
            // 
            this.btnPezziTotali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPezziTotali.AutoSize = true;
            this.btnPezziTotali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPezziTotali.Location = new System.Drawing.Point(600, 12);
            this.btnPezziTotali.Name = "btnPezziTotali";
            this.btnPezziTotali.Size = new System.Drawing.Size(130, 30);
            this.btnPezziTotali.TabIndex = 1;
            this.btnPezziTotali.Text = "Pezzi Totali";
            this.btnPezziTotali.UseVisualStyleBackColor = true;
            this.btnPezziTotali.Click += new System.EventHandler(this.btnPezziTotali_Click);
            // 
            // btnPezziALTA_Q
            // 
            this.btnPezziALTA_Q.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPezziALTA_Q.AutoSize = true;
            this.btnPezziALTA_Q.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPezziALTA_Q.Location = new System.Drawing.Point(600, 48);
            this.btnPezziALTA_Q.Name = "btnPezziALTA_Q";
            this.btnPezziALTA_Q.Size = new System.Drawing.Size(130, 30);
            this.btnPezziALTA_Q.TabIndex = 2;
            this.btnPezziALTA_Q.Text = "Alta Qualità";
            this.btnPezziALTA_Q.UseVisualStyleBackColor = true;
            this.btnPezziALTA_Q.Click += new System.EventHandler(this.btnPezziALTA_Q_Click);
            // 
            // btnPezziBASSA_Q
            // 
            this.btnPezziBASSA_Q.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPezziBASSA_Q.AutoSize = true;
            this.btnPezziBASSA_Q.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPezziBASSA_Q.Location = new System.Drawing.Point(600, 84);
            this.btnPezziBASSA_Q.Name = "btnPezziBASSA_Q";
            this.btnPezziBASSA_Q.Size = new System.Drawing.Size(130, 30);
            this.btnPezziBASSA_Q.TabIndex = 3;
            this.btnPezziBASSA_Q.Text = "Bassa Qualità";
            this.btnPezziBASSA_Q.UseVisualStyleBackColor = true;
            this.btnPezziBASSA_Q.Click += new System.EventHandler(this.btnPezziBASSA_Q_Click);
            // 
            // btnPezziSCARTO
            // 
            this.btnPezziSCARTO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPezziSCARTO.AutoSize = true;
            this.btnPezziSCARTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPezziSCARTO.Location = new System.Drawing.Point(600, 120);
            this.btnPezziSCARTO.Name = "btnPezziSCARTO";
            this.btnPezziSCARTO.Size = new System.Drawing.Size(130, 30);
            this.btnPezziSCARTO.TabIndex = 4;
            this.btnPezziSCARTO.Text = "Scarti";
            this.btnPezziSCARTO.UseVisualStyleBackColor = true;
            this.btnPezziSCARTO.Click += new System.EventHandler(this.btnPezziSCARTO_Click);
            // 
            // lblNumeroDiPezzi
            // 
            this.lblNumeroDiPezzi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroDiPezzi.AutoSize = true;
            this.lblNumeroDiPezzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDiPezzi.Location = new System.Drawing.Point(600, 186);
            this.lblNumeroDiPezzi.Name = "lblNumeroDiPezzi";
            this.lblNumeroDiPezzi.Size = new System.Drawing.Size(131, 20);
            this.lblNumeroDiPezzi.TabIndex = 5;
            this.lblNumeroDiPezzi.Text = "Numero di pezzi";
            // 
            // lblNumeroPezzi
            // 
            this.lblNumeroPezzi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroPezzi.AutoSize = true;
            this.lblNumeroPezzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPezzi.Location = new System.Drawing.Point(600, 220);
            this.lblNumeroPezzi.Name = "lblNumeroPezzi";
            this.lblNumeroPezzi.Size = new System.Drawing.Size(18, 20);
            this.lblNumeroPezzi.TabIndex = 6;
            this.lblNumeroPezzi.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(742, 553);
            this.Controls.Add(this.lblNumeroPezzi);
            this.Controls.Add(this.lblNumeroDiPezzi);
            this.Controls.Add(this.btnPezziSCARTO);
            this.Controls.Add(this.btnPezziBASSA_Q);
            this.Controls.Add(this.btnPezziALTA_Q);
            this.Controls.Add(this.btnPezziTotali);
            this.Controls.Add(this.lvPezzi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Produzione Pezzi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPezzi;
        private System.Windows.Forms.ColumnHeader chMatricola;
        private System.Windows.Forms.ColumnHeader chTipo;
        private System.Windows.Forms.ColumnHeader chAltezzza;
        private System.Windows.Forms.ColumnHeader chLarghezza;
        private System.Windows.Forms.ColumnHeader chProfondita;
        private System.Windows.Forms.Button btnPezziTotali;
        private System.Windows.Forms.Button btnPezziALTA_Q;
        private System.Windows.Forms.Button btnPezziBASSA_Q;
        private System.Windows.Forms.Button btnPezziSCARTO;
        private System.Windows.Forms.Label lblNumeroDiPezzi;
        private System.Windows.Forms.Label lblNumeroPezzi;
    }
}

