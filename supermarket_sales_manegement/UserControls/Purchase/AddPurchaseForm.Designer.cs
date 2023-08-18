namespace supermarket_sales_manegement.UserControls.Purchase
{
    partial class AddPurchaseForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductQuantityInStockLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.ProductQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ProductPurchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.PerformPurchaseButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantityNumericUpDown)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPurchaseDataGridView)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1519, 818);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1519, 818);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 818);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Bisque;
            this.panel4.Controls.Add(this.ProductDataGridView);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(470, 818);
            this.panel4.TabIndex = 6;
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.AllowUserToDeleteRows = false;
            this.ProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductDataGridView.Location = new System.Drawing.Point(0, 123);
            this.ProductDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ProductDataGridView.MultiSelect = false;
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGridView.Size = new System.Drawing.Size(470, 695);
            this.ProductDataGridView.TabIndex = 1;
            this.ProductDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProductDataGridView_CellFormatting);
            this.ProductDataGridView.SelectionChanged += new System.EventHandler(this.ProductDataGridView_SelectionChanged);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.ProductCategoryComboBox);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(470, 123);
            this.panel8.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(83, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "Selectionner le produit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Catégorie du produit :";
            // 
            // ProductCategoryComboBox
            // 
            this.ProductCategoryComboBox.FormattingEnabled = true;
            this.ProductCategoryComboBox.Location = new System.Drawing.Point(191, 74);
            this.ProductCategoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductCategoryComboBox.Name = "ProductCategoryComboBox";
            this.ProductCategoryComboBox.Size = new System.Drawing.Size(179, 24);
            this.ProductCategoryComboBox.TabIndex = 9;
            this.ProductCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductCategoryComboBox_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.ProductNameLabel);
            this.panel6.Controls.Add(this.ProductQuantityInStockLabel);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.AddToCartButton);
            this.panel6.Controls.Add(this.ProductQuantityNumericUpDown);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(465, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(388, 818);
            this.panel6.TabIndex = 5;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ProductNameLabel.Location = new System.Drawing.Point(187, 73);
            this.ProductNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(0, 24);
            this.ProductNameLabel.TabIndex = 23;
            // 
            // ProductQuantityInStockLabel
            // 
            this.ProductQuantityInStockLabel.AutoSize = true;
            this.ProductQuantityInStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQuantityInStockLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ProductQuantityInStockLabel.Location = new System.Drawing.Point(185, 108);
            this.ProductQuantityInStockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductQuantityInStockLabel.Name = "ProductQuantityInStockLabel";
            this.ProductQuantityInStockLabel.Size = new System.Drawing.Size(0, 24);
            this.ProductQuantityInStockLabel.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Quantité acheté :";
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AddToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCartButton.ForeColor = System.Drawing.Color.White;
            this.AddToCartButton.Location = new System.Drawing.Point(92, 213);
            this.AddToCartButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(223, 46);
            this.AddToCartButton.TabIndex = 20;
            this.AddToCartButton.Text = "Ajouter";
            this.AddToCartButton.UseVisualStyleBackColor = false;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // ProductQuantityNumericUpDown
            // 
            this.ProductQuantityNumericUpDown.Location = new System.Drawing.Point(189, 146);
            this.ProductQuantityNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.ProductQuantityNumericUpDown.Name = "ProductQuantityNumericUpDown";
            this.ProductQuantityNumericUpDown.Size = new System.Drawing.Size(160, 22);
            this.ProductQuantityNumericUpDown.TabIndex = 19;
            this.ProductQuantityNumericUpDown.ValueChanged += new System.EventHandler(this.ProductQuantityNumericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quantité en stock :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Désignation :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(87, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ajouter au panier";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.ProductPurchaseDataGridView);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(853, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(666, 818);
            this.panel5.TabIndex = 2;
            // 
            // ProductPurchaseDataGridView
            // 
            this.ProductPurchaseDataGridView.AllowUserToAddRows = false;
            this.ProductPurchaseDataGridView.AllowUserToDeleteRows = false;
            this.ProductPurchaseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductPurchaseDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ProductPurchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductPurchaseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductPurchaseDataGridView.Location = new System.Drawing.Point(0, 123);
            this.ProductPurchaseDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ProductPurchaseDataGridView.MultiSelect = false;
            this.ProductPurchaseDataGridView.Name = "ProductPurchaseDataGridView";
            this.ProductPurchaseDataGridView.ReadOnly = true;
            this.ProductPurchaseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductPurchaseDataGridView.Size = new System.Drawing.Size(666, 695);
            this.ProductPurchaseDataGridView.TabIndex = 1;
            this.ProductPurchaseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductPurchaseDataGridView_CellContentClick);
            this.ProductPurchaseDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProductPurchaseDataGridView_CellFormatting);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.PerformPurchaseButton);
            this.panel7.Controls.Add(this.TotalLabel);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(666, 123);
            this.panel7.TabIndex = 0;
            // 
            // PerformPurchaseButton
            // 
            this.PerformPurchaseButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.PerformPurchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerformPurchaseButton.ForeColor = System.Drawing.Color.White;
            this.PerformPurchaseButton.Location = new System.Drawing.Point(415, 52);
            this.PerformPurchaseButton.Margin = new System.Windows.Forms.Padding(4);
            this.PerformPurchaseButton.Name = "PerformPurchaseButton";
            this.PerformPurchaseButton.Size = new System.Drawing.Size(223, 46);
            this.PerformPurchaseButton.TabIndex = 7;
            this.PerformPurchaseButton.Text = "Valider la vente";
            this.PerformPurchaseButton.UseVisualStyleBackColor = false;
            this.PerformPurchaseButton.Click += new System.EventHandler(this.PerformPurchaseButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TotalLabel.Location = new System.Drawing.Point(104, 73);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(76, 24);
            this.TotalLabel.TabIndex = 10;
            this.TotalLabel.Text = "0.00 Ar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(265, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Panier";
            // 
            // AddPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 818);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddPurchaseForm";
            this.Text = "AddPurchaseResponsiveForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantityNumericUpDown)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPurchaseDataGridView)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView ProductPurchaseDataGridView;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ProductQuantityInStockLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.NumericUpDown ProductQuantityNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ProductCategoryComboBox;
        private System.Windows.Forms.Button PerformPurchaseButton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}