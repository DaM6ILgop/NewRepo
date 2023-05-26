
namespace Kyrsovaya_Ivan
{
    partial class AddBook
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
            this.Price = new System.Windows.Forms.TextBox();
            this.AdminRefrestList = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(83, 48);
            this.BookName.Multiline = true;
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(151, 27);
            this.BookName.TabIndex = 0;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(83, 143);
            this.Author.Multiline = true;
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(151, 27);
            this.Author.TabIndex = 2;
            // 
            // YearOfPublish
            // 
            this.YearOfPublish.Location = new System.Drawing.Point(83, 192);
            this.YearOfPublish.Multiline = true;
            this.YearOfPublish.Name = "YearOfPublish";
            this.YearOfPublish.Size = new System.Drawing.Size(151, 27);
            this.YearOfPublish.TabIndex = 3;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(83, 239);
            this.Price.Multiline = true;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(151, 27);
            this.Price.TabIndex = 4;
            // 
            // AdminRefrestList
            // 
            this.AdminRefrestList.Location = new System.Drawing.Point(83, 336);
            this.AdminRefrestList.Name = "AdminRefrestList";
            this.AdminRefrestList.Size = new System.Drawing.Size(151, 54);
            this.AdminRefrestList.TabIndex = 6;
            this.AdminRefrestList.Text = "Обновить список";
            this.AdminRefrestList.UseVisualStyleBackColor = true;
            this.AdminRefrestList.Click += new System.EventHandler(this.AdminRefrestList_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBox1.Location = new System.Drawing.Point(83, 290);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(83, 92);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(151, 28);
            this.Genre.TabIndex = 8;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AdminRefrestList);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.YearOfPublish);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.BookName);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox YearOfPublish;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button AdminRefrestList;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox Genre;
    }
}