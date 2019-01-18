namespace Libri_Massimo_Pavoni
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
            this.lsvBooks = new System.Windows.Forms.ListView();
            this.cmhISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhFirstAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmhPublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFileType = new System.Windows.Forms.Label();
            this.gpbBook = new System.Windows.Forms.GroupBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.txbAuthorsValue = new System.Windows.Forms.TextBox();
            this.lblAuthorsConstraint = new System.Windows.Forms.Label();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.txbDescriptionValue = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.nudPagesNumberValue = new System.Windows.Forms.NumericUpDown();
            this.lblPagesNumber = new System.Windows.Forms.Label();
            this.txbPublisherValue = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txbTitleValue = new System.Windows.Forms.TextBox();
            this.txbISBNValue = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblFileTypeValue = new System.Windows.Forms.Label();
            this.btnWriteJSON = new System.Windows.Forms.Button();
            this.btnWriteXML = new System.Windows.Forms.Button();
            this.btnReadXML = new System.Windows.Forms.Button();
            this.btnReadJSON = new System.Windows.Forms.Button();
            this.lblBooksCountValue = new System.Windows.Forms.Label();
            this.lblBooksCount = new System.Windows.Forms.Label();
            this.gpbBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPagesNumberValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvBooks
            // 
            this.lsvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cmhISBN,
            this.cmhTitle,
            this.cmhFirstAuthor,
            this.cmhPublisher});
            this.lsvBooks.FullRowSelect = true;
            this.lsvBooks.GridLines = true;
            this.lsvBooks.Location = new System.Drawing.Point(12, 94);
            this.lsvBooks.MultiSelect = false;
            this.lsvBooks.Name = "lsvBooks";
            this.lsvBooks.Size = new System.Drawing.Size(842, 220);
            this.lsvBooks.TabIndex = 0;
            this.lsvBooks.UseCompatibleStateImageBehavior = false;
            this.lsvBooks.View = System.Windows.Forms.View.Details;
            this.lsvBooks.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsv_ColumnWidthChanging);
            this.lsvBooks.SelectedIndexChanged += new System.EventHandler(this.lsvBooks_SelectedIndexChanged);
            // 
            // cmhISBN
            // 
            this.cmhISBN.Text = "ISBN";
            this.cmhISBN.Width = 160;
            // 
            // cmhTitle
            // 
            this.cmhTitle.Text = "Title";
            this.cmhTitle.Width = 260;
            // 
            // cmhFirstAuthor
            // 
            this.cmhFirstAuthor.Text = "First author";
            this.cmhFirstAuthor.Width = 220;
            // 
            // cmhPublisher
            // 
            this.cmhPublisher.Text = "Publisher";
            this.cmhPublisher.Width = 180;
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileType.Location = new System.Drawing.Point(12, 9);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(113, 18);
            this.lblFileType.TabIndex = 1;
            this.lblFileType.Text = "Now editing:";
            // 
            // gpbBook
            // 
            this.gpbBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbBook.Controls.Add(this.btnDeleteBook);
            this.gpbBook.Controls.Add(this.btnUpdateBook);
            this.gpbBook.Controls.Add(this.btnCreateBook);
            this.gpbBook.Controls.Add(this.txbAuthorsValue);
            this.gpbBook.Controls.Add(this.lblAuthorsConstraint);
            this.gpbBook.Controls.Add(this.lblAuthors);
            this.gpbBook.Controls.Add(this.txbDescriptionValue);
            this.gpbBook.Controls.Add(this.lblDescription);
            this.gpbBook.Controls.Add(this.nudPagesNumberValue);
            this.gpbBook.Controls.Add(this.lblPagesNumber);
            this.gpbBook.Controls.Add(this.txbPublisherValue);
            this.gpbBook.Controls.Add(this.lblPublisher);
            this.gpbBook.Controls.Add(this.txbTitleValue);
            this.gpbBook.Controls.Add(this.txbISBNValue);
            this.gpbBook.Controls.Add(this.lblTitle);
            this.gpbBook.Controls.Add(this.lblISBN);
            this.gpbBook.Location = new System.Drawing.Point(12, 320);
            this.gpbBook.Name = "gpbBook";
            this.gpbBook.Size = new System.Drawing.Size(842, 309);
            this.gpbBook.TabIndex = 2;
            this.gpbBook.TabStop = false;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.AutoSize = true;
            this.btnDeleteBook.Location = new System.Drawing.Point(264, 228);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(123, 40);
            this.btnDeleteBook.TabIndex = 18;
            this.btnDeleteBook.Tag = "delete";
            this.btnDeleteBook.Text = "Delete book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.AutoSize = true;
            this.btnUpdateBook.Location = new System.Drawing.Point(135, 228);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(123, 40);
            this.btnUpdateBook.TabIndex = 17;
            this.btnUpdateBook.Tag = "update";
            this.btnUpdateBook.Text = "Update book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnCreateOrUpdateBook_Click);
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.AutoSize = true;
            this.btnCreateBook.Location = new System.Drawing.Point(6, 228);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(123, 40);
            this.btnCreateBook.TabIndex = 16;
            this.btnCreateBook.Tag = "create";
            this.btnCreateBook.Text = "Create book";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateOrUpdateBook_Click);
            // 
            // txbAuthorsValue
            // 
            this.txbAuthorsValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAuthorsValue.Location = new System.Drawing.Point(496, 44);
            this.txbAuthorsValue.Multiline = true;
            this.txbAuthorsValue.Name = "txbAuthorsValue";
            this.txbAuthorsValue.Size = new System.Drawing.Size(340, 90);
            this.txbAuthorsValue.TabIndex = 15;
            // 
            // lblAuthorsConstraint
            // 
            this.lblAuthorsConstraint.AutoSize = true;
            this.lblAuthorsConstraint.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorsConstraint.Location = new System.Drawing.Point(570, 25);
            this.lblAuthorsConstraint.Name = "lblAuthorsConstraint";
            this.lblAuthorsConstraint.Size = new System.Drawing.Size(161, 16);
            this.lblAuthorsConstraint.TabIndex = 14;
            this.lblAuthorsConstraint.Text = "(separated by newline)";
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoSize = true;
            this.lblAuthors.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthors.Location = new System.Drawing.Point(493, 23);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(71, 18);
            this.lblAuthors.TabIndex = 13;
            this.lblAuthors.Text = "Authors";
            // 
            // txbDescriptionValue
            // 
            this.txbDescriptionValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDescriptionValue.Location = new System.Drawing.Point(496, 173);
            this.txbDescriptionValue.Multiline = true;
            this.txbDescriptionValue.Name = "txbDescriptionValue";
            this.txbDescriptionValue.Size = new System.Drawing.Size(340, 130);
            this.txbDescriptionValue.TabIndex = 12;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(493, 152);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 18);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description";
            // 
            // nudPagesNumberValue
            // 
            this.nudPagesNumberValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudPagesNumberValue.Location = new System.Drawing.Point(160, 150);
            this.nudPagesNumberValue.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudPagesNumberValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPagesNumberValue.Name = "nudPagesNumberValue";
            this.nudPagesNumberValue.Size = new System.Drawing.Size(100, 27);
            this.nudPagesNumberValue.TabIndex = 10;
            this.nudPagesNumberValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPagesNumber
            // 
            this.lblPagesNumber.AutoSize = true;
            this.lblPagesNumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagesNumber.Location = new System.Drawing.Point(6, 152);
            this.lblPagesNumber.Name = "lblPagesNumber";
            this.lblPagesNumber.Size = new System.Drawing.Size(148, 18);
            this.lblPagesNumber.TabIndex = 9;
            this.lblPagesNumber.Text = "Number of pages";
            // 
            // txbPublisherValue
            // 
            this.txbPublisherValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPublisherValue.Location = new System.Drawing.Point(95, 107);
            this.txbPublisherValue.Name = "txbPublisherValue";
            this.txbPublisherValue.Size = new System.Drawing.Size(360, 27);
            this.txbPublisherValue.TabIndex = 8;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(6, 109);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(83, 18);
            this.lblPublisher.TabIndex = 7;
            this.lblPublisher.Text = "Publisher";
            // 
            // txbTitleValue
            // 
            this.txbTitleValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTitleValue.Location = new System.Drawing.Point(57, 64);
            this.txbTitleValue.Name = "txbTitleValue";
            this.txbTitleValue.Size = new System.Drawing.Size(398, 27);
            this.txbTitleValue.TabIndex = 6;
            // 
            // txbISBNValue
            // 
            this.txbISBNValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbISBNValue.Location = new System.Drawing.Point(60, 21);
            this.txbISBNValue.Name = "txbISBNValue";
            this.txbISBNValue.Size = new System.Drawing.Size(395, 27);
            this.txbISBNValue.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 66);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 18);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(6, 23);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(48, 18);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "ISBN";
            // 
            // lblFileTypeValue
            // 
            this.lblFileTypeValue.AutoSize = true;
            this.lblFileTypeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileTypeValue.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileTypeValue.Location = new System.Drawing.Point(131, 9);
            this.lblFileTypeValue.Name = "lblFileTypeValue";
            this.lblFileTypeValue.Size = new System.Drawing.Size(2, 20);
            this.lblFileTypeValue.TabIndex = 3;
            // 
            // btnWriteJSON
            // 
            this.btnWriteJSON.AutoSize = true;
            this.btnWriteJSON.Location = new System.Drawing.Point(12, 45);
            this.btnWriteJSON.Name = "btnWriteJSON";
            this.btnWriteJSON.Size = new System.Drawing.Size(160, 28);
            this.btnWriteJSON.TabIndex = 4;
            this.btnWriteJSON.Text = "Save to JSON";
            this.btnWriteJSON.UseVisualStyleBackColor = true;
            this.btnWriteJSON.Click += new System.EventHandler(this.btnWriteJSON_Click);
            // 
            // btnWriteXML
            // 
            this.btnWriteXML.AutoSize = true;
            this.btnWriteXML.Location = new System.Drawing.Point(178, 45);
            this.btnWriteXML.Name = "btnWriteXML";
            this.btnWriteXML.Size = new System.Drawing.Size(160, 28);
            this.btnWriteXML.TabIndex = 5;
            this.btnWriteXML.Text = "Save to XML";
            this.btnWriteXML.UseVisualStyleBackColor = true;
            this.btnWriteXML.Click += new System.EventHandler(this.btnWriteXML_Click);
            // 
            // btnReadXML
            // 
            this.btnReadXML.AutoSize = true;
            this.btnReadXML.Location = new System.Drawing.Point(510, 45);
            this.btnReadXML.Name = "btnReadXML";
            this.btnReadXML.Size = new System.Drawing.Size(160, 28);
            this.btnReadXML.TabIndex = 7;
            this.btnReadXML.Text = "Load from XML";
            this.btnReadXML.UseVisualStyleBackColor = true;
            this.btnReadXML.Click += new System.EventHandler(this.btnReadXML_Click);
            // 
            // btnReadJSON
            // 
            this.btnReadJSON.AutoSize = true;
            this.btnReadJSON.Location = new System.Drawing.Point(344, 45);
            this.btnReadJSON.Name = "btnReadJSON";
            this.btnReadJSON.Size = new System.Drawing.Size(160, 28);
            this.btnReadJSON.TabIndex = 6;
            this.btnReadJSON.Text = "Load from JSON";
            this.btnReadJSON.UseVisualStyleBackColor = true;
            this.btnReadJSON.Click += new System.EventHandler(this.btnReadJSON_Click);
            // 
            // lblBooksCountValue
            // 
            this.lblBooksCountValue.AutoSize = true;
            this.lblBooksCountValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBooksCountValue.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksCountValue.Location = new System.Drawing.Point(813, 50);
            this.lblBooksCountValue.Name = "lblBooksCountValue";
            this.lblBooksCountValue.Size = new System.Drawing.Size(2, 20);
            this.lblBooksCountValue.TabIndex = 9;
            // 
            // lblBooksCount
            // 
            this.lblBooksCount.AutoSize = true;
            this.lblBooksCount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksCount.Location = new System.Drawing.Point(676, 50);
            this.lblBooksCount.Name = "lblBooksCount";
            this.lblBooksCount.Size = new System.Drawing.Size(131, 18);
            this.lblBooksCount.TabIndex = 8;
            this.lblBooksCount.Text = "Books number:";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(866, 641);
            this.Controls.Add(this.lblBooksCountValue);
            this.Controls.Add(this.lblBooksCount);
            this.Controls.Add(this.btnReadXML);
            this.Controls.Add(this.btnReadJSON);
            this.Controls.Add(this.btnWriteXML);
            this.Controls.Add(this.btnWriteJSON);
            this.Controls.Add(this.lblFileTypeValue);
            this.Controls.Add(this.gpbBook);
            this.Controls.Add(this.lblFileType);
            this.Controls.Add(this.lsvBooks);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gpbBook.ResumeLayout(false);
            this.gpbBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPagesNumberValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvBooks;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.ColumnHeader cmhISBN;
        private System.Windows.Forms.ColumnHeader cmhTitle;
        private System.Windows.Forms.ColumnHeader cmhFirstAuthor;
        private System.Windows.Forms.ColumnHeader cmhPublisher;
        private System.Windows.Forms.GroupBox gpbBook;
        private System.Windows.Forms.Label lblFileTypeValue;
        private System.Windows.Forms.Button btnWriteJSON;
        private System.Windows.Forms.Button btnWriteXML;
        private System.Windows.Forms.Button btnReadXML;
        private System.Windows.Forms.Button btnReadJSON;
        private System.Windows.Forms.Label lblBooksCountValue;
        private System.Windows.Forms.Label lblBooksCount;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txbTitleValue;
        private System.Windows.Forms.TextBox txbISBNValue;
        private System.Windows.Forms.TextBox txbPublisherValue;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.NumericUpDown nudPagesNumberValue;
        private System.Windows.Forms.Label lblPagesNumber;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbDescriptionValue;
        private System.Windows.Forms.Label lblAuthorsConstraint;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.TextBox txbAuthorsValue;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
    }
}

