namespace Bookstore
{
    partial class AdminPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usertable = new System.Windows.Forms.DataGridView();
            this.bookstable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usertable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(13, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Books data";
            // 
            // usertable
            // 
            this.usertable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usertable.Location = new System.Drawing.Point(20, 56);
            this.usertable.Name = "usertable";
            this.usertable.RowHeadersWidth = 51;
            this.usertable.RowTemplate.Height = 24;
            this.usertable.Size = new System.Drawing.Size(1044, 236);
            this.usertable.TabIndex = 2;
            // 
            // bookstable
            // 
            this.bookstable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookstable.Location = new System.Drawing.Point(20, 361);
            this.bookstable.Name = "bookstable";
            this.bookstable.RowHeadersWidth = 51;
            this.bookstable.RowTemplate.Height = 24;
            this.bookstable.Size = new System.Drawing.Size(1044, 238);
            this.bookstable.TabIndex = 3;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.bookstable);
            this.Controls.Add(this.usertable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usertable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView usertable;
        private System.Windows.Forms.DataGridView bookstable;
    }
}