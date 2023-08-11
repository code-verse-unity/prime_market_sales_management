﻿namespace supermarket_sales_manegement.UserControls.Product
{
    partial class UpdateProductForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ProductPrice = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductIsPerishable = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductUnit = new System.Windows.Forms.Label();
            this.ProductUnitName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 373);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Date d\'expiration ( Facultatif )";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton.Location = new System.Drawing.Point(215, 429);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(160, 32);
            this.CancelButton.TabIndex = 41;
            this.CancelButton.Text = "Annuler";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddProductButton.Location = new System.Drawing.Point(32, 429);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(157, 32);
            this.AddProductButton.TabIndex = 40;
            this.AddProductButton.Text = "Sauvegarder";
            this.AddProductButton.UseVisualStyleBackColor = false;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Location = new System.Drawing.Point(32, 183);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(239, 20);
            this.ProductPrice.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Prix unitaire";
            // 
            // ProductIsPerishable
            // 
            this.ProductIsPerishable.AutoSize = true;
            this.ProductIsPerishable.Location = new System.Drawing.Point(29, 314);
            this.ProductIsPerishable.Name = "ProductIsPerishable";
            this.ProductIsPerishable.Size = new System.Drawing.Size(46, 17);
            this.ProductIsPerishable.TabIndex = 35;
            this.ProductIsPerishable.Text = "Non";
            this.ProductIsPerishable.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Le produit est-il perissable ?";
            // 
            // ProductCategory
            // 
            this.ProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductCategory.FormattingEnabled = true;
            this.ProductCategory.Location = new System.Drawing.Point(33, 247);
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.Size = new System.Drawing.Size(344, 21);
            this.ProductCategory.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Rayon";
            // 
            // ProductUnit
            // 
            this.ProductUnit.AutoSize = true;
            this.ProductUnit.Location = new System.Drawing.Point(286, 160);
            this.ProductUnit.Name = "ProductUnit";
            this.ProductUnit.Size = new System.Drawing.Size(32, 13);
            this.ProductUnit.TabIndex = 31;
            this.ProductUnit.Text = "Unité";
            // 
            // ProductUnitName
            // 
            this.ProductUnitName.Location = new System.Drawing.Point(289, 182);
            this.ProductUnitName.Name = "ProductUnitName";
            this.ProductUnitName.Size = new System.Drawing.Size(86, 20);
            this.ProductUnitName.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "dans les rayons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Modifier le produit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nom du produit";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(33, 119);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(343, 20);
            this.ProductName.TabIndex = 26;
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 524);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProductIsPerishable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductUnit);
            this.Controls.Add(this.ProductUnitName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductName);
            this.Name = "UpdateProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.NumericUpDown ProductPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ProductIsPerishable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ProductCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ProductUnit;
        private System.Windows.Forms.TextBox ProductUnitName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductName;
    }
}