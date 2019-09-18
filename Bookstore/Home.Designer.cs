namespace Bookstore
{
    partial class Home
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBestBooks = new System.Windows.Forms.Button();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.databaseDataSet = new Bookstore.DatabaseDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Bookstore.DatabaseDataSetTableAdapters.BooksTableAdapter();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.mainBooksTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBooksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 82);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnBestBooks
            // 
            this.btnBestBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBestBooks.Location = new System.Drawing.Point(12, 100);
            this.btnBestBooks.Name = "btnBestBooks";
            this.btnBestBooks.Size = new System.Drawing.Size(220, 82);
            this.btnBestBooks.TabIndex = 2;
            this.btnBestBooks.Text = "MY BOOKS";
            this.btnBestBooks.UseVisualStyleBackColor = true;
            this.btnBestBooks.Click += new System.EventHandler(this.BtnBestBooks_Click);
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddNewBook.Location = new System.Drawing.Point(12, 188);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(220, 82);
            this.btnAddNewBook.TabIndex = 3;
            this.btnAddNewBook.Text = "ADD NEW BOOK";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.BtnAddNewBook_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitBtn.Location = new System.Drawing.Point(12, 276);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(220, 82);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProfile.Location = new System.Drawing.Point(12, 364);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(220, 82);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.databaseDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.databaseDataSet;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // booksBindingSource2
            // 
            this.booksBindingSource2.DataMember = "Books";
            this.booksBindingSource2.DataSource = this.databaseDataSetBindingSource;
            // 
            // databaseDataSetBindingSource1
            // 
            this.databaseDataSetBindingSource1.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource1.Position = 0;
            // 
            // booksBindingSource3
            // 
            this.booksBindingSource3.DataMember = "Books";
            this.booksBindingSource3.DataSource = this.databaseDataSetBindingSource1;
            // 
            // booksBindingSource4
            // 
            this.booksBindingSource4.DataMember = "Books";
            this.booksBindingSource4.DataSource = this.databaseDataSet;
            // 
            // mainBooksTable
            // 
            this.mainBooksTable.AllowUserToAddRows = false;
            this.mainBooksTable.AllowUserToDeleteRows = false;
            this.mainBooksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainBooksTable.Location = new System.Drawing.Point(243, 14);
            this.mainBooksTable.Name = "mainBooksTable";
            this.mainBooksTable.ReadOnly = true;
            this.mainBooksTable.RowHeadersWidth = 51;
            this.mainBooksTable.RowTemplate.Height = 24;
            this.mainBooksTable.Size = new System.Drawing.Size(805, 431);
            this.mainBooksTable.TabIndex = 6;
            this.mainBooksTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainBooksTable_CellContentClick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 458);
            this.Controls.Add(this.mainBooksTable);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.btnBestBooks);
            this.Controls.Add(this.btnHome);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBooksTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBestBooks;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button btnProfile;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private DatabaseDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource booksBindingSource2;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource1;
        private System.Windows.Forms.BindingSource booksBindingSource3;
        private System.Windows.Forms.BindingSource booksBindingSource4;
        private System.Windows.Forms.DataGridView mainBooksTable;
    }
}