
namespace Kyrsovaya_Ivan
{
    partial class GuestForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.genre = new System.Windows.Forms.Label();
            this.buttonChooseBasket = new System.Windows.Forms.Button();
            this.buttonBasket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(957, 369);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Жанр";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Автор";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Год издания";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Цена";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Наличие";
            this.columnHeader6.Width = 100;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(236, 376);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 27);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "В Наличии";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Фантастика",
            "Драма",
            "Фэнтези",
            "Ужасы",
            "Историческое",
            "Комедия"});
            this.comboBox1.Location = new System.Drawing.Point(62, 375);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(5, 377);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(51, 20);
            this.genre.TabIndex = 3;
            this.genre.Text = "Жанр:";
            // 
            // buttonChooseBasket
            // 
            this.buttonChooseBasket.Location = new System.Drawing.Point(730, 375);
            this.buttonChooseBasket.Name = "buttonChooseBasket";
            this.buttonChooseBasket.Size = new System.Drawing.Size(228, 37);
            this.buttonChooseBasket.TabIndex = 4;
            this.buttonChooseBasket.Text = "Добавить в корзину";
            this.buttonChooseBasket.UseVisualStyleBackColor = true;
            // 
            // buttonBasket
            // 
            this.buttonBasket.Location = new System.Drawing.Point(730, 433);
            this.buttonBasket.Name = "buttonBasket";
            this.buttonBasket.Size = new System.Drawing.Size(228, 35);
            this.buttonBasket.TabIndex = 5;
            this.buttonBasket.Text = "Корзина";
            this.buttonBasket.UseVisualStyleBackColor = true;
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 480);
            this.Controls.Add(this.buttonBasket);
            this.Controls.Add(this.buttonChooseBasket);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listView1);
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            this.Activated += new System.EventHandler(this.GuestForm_Activated);
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Button buttonChooseBasket;
        private System.Windows.Forms.Button buttonBasket;
    }
}