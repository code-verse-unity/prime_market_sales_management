namespace supermarket_sales_manegement.UserControls
{
    partial class NewStockForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductPrice = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductQuatity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.ProductList = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddInStockButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuatity)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "en stock pour un produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ajouter une nouvelle entrée";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom du produit *";
            // 
            // ProductPrice
            // 
            this.ProductPrice.Location = new System.Drawing.Point(26, 197);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(145, 20);
            this.ProductPrice.TabIndex = 21;
            this.ProductPrice.Maximum = decimal.MaxValue;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Prix unitaire *";
            // 
            // ProductQuatity
            // 
            this.ProductQuatity.Location = new System.Drawing.Point(233, 197);
            this.ProductQuatity.Name = "ProductQuatity";
            this.ProductQuatity.Size = new System.Drawing.Size(136, 20);
            this.ProductQuatity.TabIndex = 19;
            this.ProductQuatity.Maximum = decimal.MaxValue;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quantité *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Date d\'expiration *";
            // 
            // ProductExpirationDate
            // 
            this.ProductExpirationDate.Location = new System.Drawing.Point(27, 270);
            this.ProductExpirationDate.Name = "ProductExpirationDate";
            this.ProductExpirationDate.Size = new System.Drawing.Size(200, 20);
            this.ProductExpirationDate.TabIndex = 23;
            // 
            // ProductList
            // 
            this.ProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(27, 130);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(342, 21);
            this.ProductList.TabIndex = 24;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton.Location = new System.Drawing.Point(201, 324);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(168, 32);
            this.CancelButton.TabIndex = 26;
            this.CancelButton.Text = "Annuler";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddInStockButton
            // 
            this.AddInStockButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AddInStockButton.FlatAppearance.BorderSize = 0;
            this.AddInStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddInStockButton.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInStockButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddInStockButton.Location = new System.Drawing.Point(26, 324);
            this.AddInStockButton.Name = "AddInStockButton";
            this.AddInStockButton.Size = new System.Drawing.Size(169, 32);
            this.AddInStockButton.TabIndex = 25;
            this.AddInStockButton.Text = "Enregistrer le stock";
            this.AddInStockButton.UseVisualStyleBackColor = false;
            this.AddInStockButton.Click += new System.EventHandler(this.AddInStockButton_Click);
            // 
            // NewStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 408);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddInStockButton);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.ProductExpirationDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProductQuatity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "NewStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewStockForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuatity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ProductPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ProductQuatity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ProductExpirationDate;
        private System.Windows.Forms.ComboBox ProductList;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddInStockButton;
    }
}