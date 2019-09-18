namespace Bookstore
{
    partial class NewBook
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnBestBooks = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.authorField = new System.Windows.Forms.TextBox();
            this.titleField = new System.Windows.Forms.TextBox();
            this.descField = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewBook = new System.Windows.Forms.Button();
            this.newBookArt = new System.Windows.Forms.PictureBox();
            this.reviewField = new System.Windows.Forms.RichTextBox();
            this.reviewLabel = new System.Windows.Forms.Label();
            this.rateBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newBookArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProfile.Location = new System.Drawing.Point(12, 364);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(220, 82);
            this.btnProfile.TabIndex = 10;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitBtn.Location = new System.Drawing.Point(12, 276);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(220, 82);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddNewBook.Location = new System.Drawing.Point(12, 188);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(220, 82);
            this.btnAddNewBook.TabIndex = 8;
            this.btnAddNewBook.Text = "ADD NEW BOOK";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.BtnAddNewBook_Click);
            // 
            // btnBestBooks
            // 
            this.btnBestBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBestBooks.Location = new System.Drawing.Point(12, 100);
            this.btnBestBooks.Name = "btnBestBooks";
            this.btnBestBooks.Size = new System.Drawing.Size(220, 82);
            this.btnBestBooks.TabIndex = 7;
            this.btnBestBooks.Text = "MY BOOKS";
            this.btnBestBooks.UseVisualStyleBackColor = true;
            this.btnBestBooks.Click += new System.EventHandler(this.BtnBestBooks_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 82);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click_1);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.titleLabel.Location = new System.Drawing.Point(274, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(95, 36);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Title : ";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.authorLabel.Location = new System.Drawing.Point(274, 103);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(121, 36);
            this.authorLabel.TabIndex = 12;
            this.authorLabel.Text = "Author :";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.descLabel.Location = new System.Drawing.Point(274, 163);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(197, 36);
            this.descLabel.TabIndex = 13;
            this.descLabel.Text = "Descryption : ";
            // 
            // authorField
            // 
            this.authorField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.authorField.Location = new System.Drawing.Point(413, 100);
            this.authorField.Name = "authorField";
            this.authorField.Size = new System.Drawing.Size(405, 41);
            this.authorField.TabIndex = 15;
            // 
            // titleField
            // 
            this.titleField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.titleField.Location = new System.Drawing.Point(413, 29);
            this.titleField.Name = "titleField";
            this.titleField.Size = new System.Drawing.Size(405, 41);
            this.titleField.TabIndex = 16;
            // 
            // descField
            // 
            this.descField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.descField.Location = new System.Drawing.Point(280, 205);
            this.descField.Name = "descField";
            this.descField.Size = new System.Drawing.Size(746, 125);
            this.descField.TabIndex = 18;
            this.descField.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Location = new System.Drawing.Point(12, 562);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(516, 82);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnNewBook
            // 
            this.btnNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNewBook.Location = new System.Drawing.Point(535, 562);
            this.btnNewBook.Name = "btnNewBook";
            this.btnNewBook.Size = new System.Drawing.Size(516, 82);
            this.btnNewBook.TabIndex = 20;
            this.btnNewBook.Text = "Add new book";
            this.btnNewBook.UseVisualStyleBackColor = true;
            this.btnNewBook.Click += new System.EventHandler(this.BtnNewBook_Click);
            // 
            // newBookArt
            // 
            this.newBookArt.Location = new System.Drawing.Point(846, 30);
            this.newBookArt.Name = "newBookArt";
            this.newBookArt.Size = new System.Drawing.Size(179, 151);
            this.newBookArt.TabIndex = 21;
            this.newBookArt.TabStop = false;
            // 
            // reviewField
            // 
            this.reviewField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.reviewField.Location = new System.Drawing.Point(279, 391);
            this.reviewField.Name = "reviewField";
            this.reviewField.Size = new System.Drawing.Size(746, 137);
            this.reviewField.TabIndex = 23;
            this.reviewField.Text = "";
            // 
            // reviewLabel
            // 
            this.reviewLabel.AutoSize = true;
            this.reviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.reviewLabel.Location = new System.Drawing.Point(273, 349);
            this.reviewLabel.Name = "reviewLabel";
            this.reviewLabel.Size = new System.Drawing.Size(121, 36);
            this.reviewLabel.TabIndex = 22;
            this.reviewLabel.Text = "Review:";
            // 
            // rateBox
            // 
            this.rateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.rateBox.Location = new System.Drawing.Point(189, 479);
            this.rateBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(53, 41);
            this.rateBox.TabIndex = 24;
            this.rateBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rateBox.ValueChanged += new System.EventHandler(this.RateBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(12, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "Your rate : ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // NewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 656);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.reviewField);
            this.Controls.Add(this.reviewLabel);
            this.Controls.Add(this.newBookArt);
            this.Controls.Add(this.btnNewBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.descField);
            this.Controls.Add(this.titleField);
            this.Controls.Add(this.authorField);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.btnBestBooks);
            this.Controls.Add(this.btnHome);
            this.Name = "NewBook";
            this.Text = "NewBook";
            ((System.ComponentModel.ISupportInitialize)(this.newBookArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnBestBooks;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox authorField;
        private System.Windows.Forms.TextBox titleField;
        private System.Windows.Forms.RichTextBox descField;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewBook;
        private System.Windows.Forms.PictureBox newBookArt;
        private System.Windows.Forms.RichTextBox reviewField;
        private System.Windows.Forms.Label reviewLabel;
        private System.Windows.Forms.NumericUpDown rateBox;
        private System.Windows.Forms.Label label1;
    }
}