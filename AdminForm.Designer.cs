
namespace Kyrsovaya_Ivan
{
    partial class AdminForm
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
            this.BookName = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.YearOfPublish = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Presence = new System.Windows.Forms.TextBox();
            this.AddBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(12, 33);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(125, 27);
            this.BookName.TabIndex = 0;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(12, 97);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(125, 27);
            this.Author.TabIndex = 1;
            // 
            // YearOfPublish
            // 
            this.YearOfPublish.Location = new System.Drawing.Point(188, 97);
            this.YearOfPublish.Name = "YearOfPublish";
            this.YearOfPublish.Size = new System.Drawing.Size(125, 27);
            this.YearOfPublish.TabIndex = 2;
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(188, 33);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(125, 27);
            this.Genre.TabIndex = 3;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(12, 152);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(125, 27);
            this.Price.TabIndex = 4;
            // 
            // Presence
            // 
            this.Presence.Location = new System.Drawing.Point(188, 152);
            this.Presence.Name = "Presence";
            this.Presence.Size = new System.Drawing.Size(125, 27);
            this.Presence.TabIndex = 5;
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(73, 203);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(167, 78);
            this.AddBook.TabIndex = 6;
            this.AddBook.Text = "Добавить книгу";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.Presence);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.YearOfPublish);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.BookName);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox YearOfPublish;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Presence;
        private System.Windows.Forms.Button AddBook;
    }
}