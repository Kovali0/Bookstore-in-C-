namespace Bookstore
{
    partial class BestBooks
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
            this.mainBooksTable = new System.Windows.Forms.DataGridView();
            this.btnProfile = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnBestBooks = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainBooksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // mainBooksTable
            // 
            this.mainBooksTable.AllowUserToAddRows = false;
            this.mainBooksTable.AllowUserToDeleteRows = false;
            this.mainBooksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainBooksTable.Location = new System.Drawing.Point(244, 14);
            this.mainBooksTable.Name = "mainBooksTable";
            this.mainBooksTable.ReadOnly = true;
            this.mainBooksTable.RowHeadersWidth = 51;
            this.mainBooksTable.RowTemplate.Height = 24;
            this.mainBooksTable.Size = new System.Drawing.Size(805, 431);
            this.mainBooksTable.TabIndex = 12;
            this.mainBooksTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainBooksTable_CellContentClick);
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProfile.Location = new System.Drawing.Point(13, 364);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(220, 82);
            this.btnProfile.TabIndex = 11;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitBtn.Location = new System.Drawing.Point(13, 276);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(220, 82);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddNewBook.Location = new System.Drawing.Point(13, 188);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(220, 82);
            this.btnAddNewBook.TabIndex = 9;
            this.btnAddNewBook.Text = "ADD NEW BOOK";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.BtnAddNewBook_Click);
            // 
            // btnBestBooks
            // 
            this.btnBestBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBestBooks.Location = new System.Drawing.Point(13, 100);
            this.btnBestBooks.Name = "btnBestBooks";
            this.btnBestBooks.Size = new System.Drawing.Size(220, 82);
            this.btnBestBooks.TabIndex = 8;
            this.btnBestBooks.Text = "MY BOOKS";
            this.btnBestBooks.UseVisualStyleBackColor = true;
            this.btnBestBooks.Click += new System.EventHandler(this.BtnBestBooks_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHome.Location = new System.Drawing.Point(13, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 82);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BestBooks
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
            this.Name = "BestBooks";
            this.Text = "BestBooks";
            this.Load += new System.EventHandler(this.BestBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainBooksTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mainBooksTable;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnBestBooks;
        private System.Windows.Forms.Button btnHome;
    }
}