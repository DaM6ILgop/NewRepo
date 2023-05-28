
namespace Kyrsovaya_Ivan
{
    partial class EditForm
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
            this.ReturnBttn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AdminRefrestList = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ReturnBttn
            // 
            this.ReturnBttn.Location = new System.Drawing.Point(485, 241);
            this.ReturnBttn.Name = "ReturnBttn";
            this.ReturnBttn.Size = new System.Drawing.Size(151, 52);
            this.ReturnBttn.TabIndex = 29;
            this.ReturnBttn.Text = "Назад";
            this.ReturnBttn.UseVisualStyleBackColor = true;
            this.ReturnBttn.Click += new System.EventHandler(this.ReturnBttn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Наличие";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Дата релиза ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Автор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Жанр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Название книги";
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(273, 57);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(151, 28);
            this.Genre.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBox1.Location = new System.Drawing.Point(485, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 21;
            // 
            // AdminRefrestList
            // 
            this.AdminRefrestList.Location = new System.Drawing.Point(82, 241);
            this.AdminRefrestList.Name = "AdminRefrestList";
            this.AdminRefrestList.Size = new System.Drawing.Size(151, 53);
            this.AdminRefrestList.TabIndex = 20;
            this.AdminRefrestList.Text = "Изменить";
            this.AdminRefrestList.UseVisualStyleBackColor = true;
            this.AdminRefrestList.Click += new System.EventHandler(this.AdminRefrestList_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(273, 165);
            this.Price.Multiline = true;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(151, 27);
            this.Price.TabIndex = 19;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(485, 59);
            this.Author.Multiline = true;
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(151, 27);
            this.Author.TabIndex = 17;
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(82, 59);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(151, 27);
            this.BookName.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 27);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // EditForm
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(735, 359);
            this.MinimumSize = new System.Drawing.Size(735, 359);
            this.Name = "EditForm";
            this.Text = "Изменить";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnBttn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AdminRefrestList;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}