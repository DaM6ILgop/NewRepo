
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(83, 44);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(151, 27);
            this.BookName.TabIndex = 0;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(486, 44);
            this.Author.Multiline = true;
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(151, 27);
            this.Author.TabIndex = 2;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(274, 149);
            this.Price.Multiline = true;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(151, 27);
            this.Price.TabIndex = 4;
            // 
            // AdminRefrestList
            // 
            this.AdminRefrestList.Location = new System.Drawing.Point(83, 227);
            this.AdminRefrestList.Name = "AdminRefrestList";
            this.AdminRefrestList.Size = new System.Drawing.Size(151, 53);
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
            this.comboBox1.Location = new System.Drawing.Point(486, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(274, 43);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(151, 28);
            this.Genre.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Жанр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Автор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дата релиза ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Наличие";
            // 
            // ReturnBttn
            // 
            this.ReturnBttn.Location = new System.Drawing.Point(486, 227);
            this.ReturnBttn.Name = "ReturnBttn";
            this.ReturnBttn.Size = new System.Drawing.Size(151, 52);
            this.ReturnBttn.TabIndex = 15;
            this.ReturnBttn.Text = "Назад";
            this.ReturnBttn.UseVisualStyleBackColor = true;
            this.ReturnBttn.Click += new System.EventHandler(this.ReturnBttn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 27);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 312);
            this.Controls.Add(this.dateTimePicker1);
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
            this.Controls.Add(this.Author);
            this.Controls.Add(this.BookName);
            this.MaximumSize = new System.Drawing.Size(735, 359);
            this.MinimumSize = new System.Drawing.Size(735, 359);
            this.Name = "AddBook";
            this.Text = "Добавить книгу";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox Author;
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
        internal System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}