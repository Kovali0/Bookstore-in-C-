namespace Bookstore
{
    partial class Profile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profileImage = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nickLabel = new System.Windows.Forms.Label();
            this.emailLab = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.NumericUpDown();
            this.adminpbtn = new System.Windows.Forms.Button();
            this.statsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProfile.Location = new System.Drawing.Point(12, 364);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(220, 82);
            this.btnProfile.TabIndex = 15;
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
            this.exitBtn.TabIndex = 14;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddNewBook.Location = new System.Drawing.Point(12, 188);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(220, 82);
            this.btnAddNewBook.TabIndex = 13;
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
            this.btnBestBooks.TabIndex = 12;
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
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.titleLabel.Location = new System.Drawing.Point(260, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(166, 36);
            this.titleLabel.TabIndex = 16;
            this.titleLabel.Text = "Username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(260, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Age :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(260, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "Gender :";
            // 
            // profileImage
            // 
            this.profileImage.Location = new System.Drawing.Point(795, 32);
            this.profileImage.Name = "profileImage";
            this.profileImage.Size = new System.Drawing.Size(238, 212);
            this.profileImage.TabIndex = 22;
            this.profileImage.TabStop = false;
            this.profileImage.Click += new System.EventHandler(this.ProfileImage_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkBox1.Location = new System.Drawing.Point(445, 230);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 35);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Male";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkBox2.Location = new System.Drawing.Point(589, 230);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(126, 35);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "Female";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.emailLabel.Location = new System.Drawing.Point(260, 94);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(104, 36);
            this.emailLabel.TabIndex = 27;
            this.emailLabel.Text = "Email :";
            // 
            // nickLabel
            // 
            this.nickLabel.AutoSize = true;
            this.nickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.nickLabel.Location = new System.Drawing.Point(439, 26);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(69, 36);
            this.nickLabel.TabIndex = 28;
            this.nickLabel.Text = "nick";
            this.nickLabel.Click += new System.EventHandler(this.NickLabel_Click_1);
            // 
            // emailLab
            // 
            this.emailLab.AutoSize = true;
            this.emailLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.emailLab.Location = new System.Drawing.Point(439, 94);
            this.emailLab.Name = "emailLab";
            this.emailLab.Size = new System.Drawing.Size(69, 36);
            this.emailLab.TabIndex = 29;
            this.emailLab.Text = "nick";
            // 
            // ageBox
            // 
            this.ageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ageBox.Location = new System.Drawing.Point(445, 155);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(120, 41);
            this.ageBox.TabIndex = 30;
            this.ageBox.ValueChanged += new System.EventHandler(this.AgeBox_ValueChanged);
            // 
            // adminpbtn
            // 
            this.adminpbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.adminpbtn.Location = new System.Drawing.Point(648, 328);
            this.adminpbtn.Name = "adminpbtn";
            this.adminpbtn.Size = new System.Drawing.Size(385, 93);
            this.adminpbtn.TabIndex = 31;
            this.adminpbtn.Text = "ADMIN PANEL";
            this.adminpbtn.UseVisualStyleBackColor = true;
            this.adminpbtn.Click += new System.EventHandler(this.Adminpbtn_Click);
            // 
            // statsBtn
            // 
            this.statsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statsBtn.Location = new System.Drawing.Point(238, 328);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(376, 93);
            this.statsBtn.TabIndex = 32;
            this.statsBtn.Text = "STATISTICS";
            this.statsBtn.UseVisualStyleBackColor = true;
            this.statsBtn.Click += new System.EventHandler(this.StatsBtn_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 458);
            this.Controls.Add(this.statsBtn);
            this.Controls.Add(this.adminpbtn);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.emailLab);
            this.Controls.Add(this.nickLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.profileImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.btnBestBooks);
            this.Controls.Add(this.btnHome);
            this.Name = "Profile";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox profileImage;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nickLabel;
        private System.Windows.Forms.Label emailLab;
        private System.Windows.Forms.NumericUpDown ageBox;
        private System.Windows.Forms.Button adminpbtn;
        private System.Windows.Forms.Button statsBtn;
    }
}