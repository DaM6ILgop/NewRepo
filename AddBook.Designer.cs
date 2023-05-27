
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ReturnBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(73, 33);
            this.BookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(133, 23);
            this.BookName.TabIndex = 0;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(425, 33);
            this.Author.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Author.Multiline = true;
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(133, 21);
            this.Author.TabIndex = 2;
            // 
            // YearOfPublish
            // 
            this.YearOfPublish.Location = new System.Drawing.Point(73, 112);
            this.YearOfPublish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YearOfPublish.Multiline = true;
            this.YearOfPublish.Name = "YearOfPublish";
            this.YearOfPublish.Size = new System.Drawing.Size(133, 21);
            this.YearOfPublish.TabIndex = 3;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(240, 112);
            this.Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Price.Multiline = true;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(133, 21);
            this.Price.TabIndex = 4;
            // 
            // AdminRefrestList
            // 
            this.AdminRefrestList.Location = new System.Drawing.Point(73, 170);
            this.AdminRefrestList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminRefrestList.Name = "AdminRefrestList";
            this.AdminRefrestList.Size = new System.Drawing.Size(132, 40);
            this.AdminRefrestList.TabIndex = 6;
            this.AdminRefrestList.Text = "Добавить";
            this.AdminRefrestList.UseVisualStyleBackColor = true;
            this.AdminRefrestList.Click += new System.EventHandler(this.AdminRefrestList_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBox1.Location = new System.Drawing.Point(425, 112);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(240, 32);
            this.Genre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(133, 23);
            this.Genre.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Жанр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Автор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дата релиза ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Наличие";
            // 
            // ReturnBttn
            // 
            this.ReturnBttn.Location = new System.Drawing.Point(425, 170);
            this.ReturnBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReturnBttn.Name = "ReturnBttn";
            this.ReturnBttn.Size = new System.Drawing.Size(132, 39);
            this.ReturnBttn.TabIndex = 15;
            this.ReturnBttn.Text = "Назад";
            this.ReturnBttn.UseVisualStyleBackColor = true;
            this.ReturnBttn.Click += new System.EventHandler(this.ReturnBttn_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 242);
            this.Controls.Add(this.ReturnBttn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AdminRefrestList);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.YearOfPublish);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.BookName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(645, 281);
            this.MinimumSize = new System.Drawing.Size(645, 281);
            this.Name = "AddBook";
            this.Text = "Добавить книгу";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ReturnBttn;
    }
}