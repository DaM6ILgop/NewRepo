namespace Kyrsovaya_Ivan
{
    partial class BasketForm
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
            this.listViewBasket = new System.Windows.Forms.ListView();
            this.columnNameBook = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelet = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.Назад = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewBasket
            // 
            this.listViewBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewBasket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameBook,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewBasket.FullRowSelect = true;
            this.listViewBasket.GridLines = true;
            this.listViewBasket.HideSelection = false;
            this.listViewBasket.Location = new System.Drawing.Point(10, 9);
            this.listViewBasket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewBasket.Name = "listViewBasket";
            this.listViewBasket.Size = new System.Drawing.Size(680, 267);
            this.listViewBasket.TabIndex = 0;
            this.listViewBasket.UseCompatibleStateImageBehavior = false;
            this.listViewBasket.View = System.Windows.Forms.View.Details;
            // 
            // columnNameBook
            // 
            this.columnNameBook.Text = "Название книги";
            this.columnNameBook.Width = 250;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Жанр";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Автор";
            this.columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата выпуска";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Цена";
            this.columnHeader4.Width = 100;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Назад);
            this.panel1.Controls.Add(this.buttonDelet);
            this.panel1.Controls.Add(this.buttonBuy);
            this.panel1.Controls.Add(this.listViewBasket);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 338);
            this.panel1.TabIndex = 1;
            // 
            // buttonDelet
            // 
            this.buttonDelet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelet.Location = new System.Drawing.Point(504, 280);
            this.buttonDelet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelet.Name = "buttonDelet";
            this.buttonDelet.Size = new System.Drawing.Size(186, 49);
            this.buttonDelet.TabIndex = 2;
            this.buttonDelet.Text = "Удалить";
            this.buttonDelet.UseVisualStyleBackColor = true;
            this.buttonDelet.Click += new System.EventHandler(this.buttonDelet_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBuy.Location = new System.Drawing.Point(10, 280);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(186, 49);
            this.buttonBuy.TabIndex = 1;
            this.buttonBuy.Text = "Купить";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BasketForm";
            this.Text = "BasketForm";
            this.Load += new System.EventHandler(this.BasketForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewBasket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnNameBook;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonDelet;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}