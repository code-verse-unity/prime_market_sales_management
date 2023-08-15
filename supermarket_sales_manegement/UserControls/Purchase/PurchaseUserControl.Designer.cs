namespace supermarket_sales_manegement.UserControls.Purchase
{
    partial class PurchaseUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PurchaseCreatedAtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.PurchaseProductCountLabel = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.RevenueLabel = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.AddPurchaseButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductPurchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.ProductsCountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PurchaseTotalLabel = new System.Windows.Forms.Label();
            this.PurchaseDateLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PurchaseIdLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PurchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPurchaseDataGridView)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 157);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(985, 75);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(328, 75);
            this.panel6.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestion des achats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ajouter, Modifier, Supprimer et Chercher des achats";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.PurchaseCreatedAtDateTimePicker);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.panel14);
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(985, 82);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // PurchaseCreatedAtDateTimePicker
            // 
            this.PurchaseCreatedAtDateTimePicker.Location = new System.Drawing.Point(19, 47);
            this.PurchaseCreatedAtDateTimePicker.Name = "PurchaseCreatedAtDateTimePicker";
            this.PurchaseCreatedAtDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.PurchaseCreatedAtDateTimePicker.TabIndex = 16;
            this.PurchaseCreatedAtDateTimePicker.ValueChanged += new System.EventHandler(this.PurchaseCreatedAtDateTimePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Selectionner la date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel14.Controls.Add(this.label14);
            this.panel14.Controls.Add(this.PurchaseProductCountLabel);
            this.panel14.Location = new System.Drawing.Point(470, 10);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(183, 63);
            this.panel14.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Produits vendus :";
            // 
            // PurchaseProductCountLabel
            // 
            this.PurchaseProductCountLabel.AutoSize = true;
            this.PurchaseProductCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseProductCountLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PurchaseProductCountLabel.Location = new System.Drawing.Point(13, 34);
            this.PurchaseProductCountLabel.Name = "PurchaseProductCountLabel";
            this.PurchaseProductCountLabel.Size = new System.Drawing.Size(17, 18);
            this.PurchaseProductCountLabel.TabIndex = 9;
            this.PurchaseProductCountLabel.Text = "0";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel13.Controls.Add(this.label11);
            this.panel13.Controls.Add(this.RevenueLabel);
            this.panel13.Location = new System.Drawing.Point(269, 10);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(183, 63);
            this.panel13.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Chiffre d\'affaires :";
            // 
            // RevenueLabel
            // 
            this.RevenueLabel.AutoSize = true;
            this.RevenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevenueLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.RevenueLabel.Location = new System.Drawing.Point(13, 34);
            this.RevenueLabel.Name = "RevenueLabel";
            this.RevenueLabel.Size = new System.Drawing.Size(61, 18);
            this.RevenueLabel.TabIndex = 9;
            this.RevenueLabel.Text = "0,00 Ar";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.AddPurchaseButton);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(785, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 80);
            this.panel9.TabIndex = 5;
            // 
            // AddPurchaseButton
            // 
            this.AddPurchaseButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.AddPurchaseButton.FlatAppearance.BorderSize = 0;
            this.AddPurchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPurchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPurchaseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddPurchaseButton.Location = new System.Drawing.Point(16, 26);
            this.AddPurchaseButton.Name = "AddPurchaseButton";
            this.AddPurchaseButton.Size = new System.Drawing.Size(167, 32);
            this.AddPurchaseButton.TabIndex = 4;
            this.AddPurchaseButton.Text = "Enregistrer un achat";
            this.AddPurchaseButton.UseVisualStyleBackColor = false;
            this.AddPurchaseButton.Click += new System.EventHandler(this.AddPurchaseButton_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(985, 2);
            this.panel8.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProductPurchaseDataGridView);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(420, 157);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(565, 447);
            this.panel2.TabIndex = 1;
            // 
            // ProductPurchaseDataGridView
            // 
            this.ProductPurchaseDataGridView.AllowUserToAddRows = false;
            this.ProductPurchaseDataGridView.AllowUserToDeleteRows = false;
            this.ProductPurchaseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductPurchaseDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ProductPurchaseDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductPurchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductPurchaseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductPurchaseDataGridView.Location = new System.Drawing.Point(8, 168);
            this.ProductPurchaseDataGridView.MultiSelect = false;
            this.ProductPurchaseDataGridView.Name = "ProductPurchaseDataGridView";
            this.ProductPurchaseDataGridView.ReadOnly = true;
            this.ProductPurchaseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductPurchaseDataGridView.Size = new System.Drawing.Size(549, 271);
            this.ProductPurchaseDataGridView.TabIndex = 1;
            this.ProductPurchaseDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProductPurchaseDataGridView_CellFormatting);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Controls.Add(this.ProductsCountLabel);
            this.panel12.Controls.Add(this.label3);
            this.panel12.Controls.Add(this.PurchaseTotalLabel);
            this.panel12.Controls.Add(this.PurchaseDateLabel);
            this.panel12.Controls.Add(this.label12);
            this.panel12.Controls.Add(this.PurchaseIdLabel);
            this.panel12.Controls.Add(this.label10);
            this.panel12.Controls.Add(this.label9);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(8, 8);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(549, 160);
            this.panel12.TabIndex = 0;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // ProductsCountLabel
            // 
            this.ProductsCountLabel.AutoSize = true;
            this.ProductsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsCountLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ProductsCountLabel.Location = new System.Drawing.Point(137, 125);
            this.ProductsCountLabel.Name = "ProductsCountLabel";
            this.ProductsCountLabel.Size = new System.Drawing.Size(17, 18);
            this.ProductsCountLabel.TabIndex = 15;
            this.ProductsCountLabel.Text = "0";
            this.ProductsCountLabel.Click += new System.EventHandler(this.ProductsCountLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Produits vendus :";
            // 
            // PurchaseTotalLabel
            // 
            this.PurchaseTotalLabel.AutoSize = true;
            this.PurchaseTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseTotalLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PurchaseTotalLabel.Location = new System.Drawing.Point(89, 99);
            this.PurchaseTotalLabel.Name = "PurchaseTotalLabel";
            this.PurchaseTotalLabel.Size = new System.Drawing.Size(61, 18);
            this.PurchaseTotalLabel.TabIndex = 13;
            this.PurchaseTotalLabel.Text = "0,00 Ar";
            this.PurchaseTotalLabel.Click += new System.EventHandler(this.PurchaseTotalLabel_Click);
            // 
            // PurchaseDateLabel
            // 
            this.PurchaseDateLabel.AutoSize = true;
            this.PurchaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseDateLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PurchaseDateLabel.Location = new System.Drawing.Point(89, 72);
            this.PurchaseDateLabel.Name = "PurchaseDateLabel";
            this.PurchaseDateLabel.Size = new System.Drawing.Size(0, 18);
            this.PurchaseDateLabel.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Total :";
            // 
            // PurchaseIdLabel
            // 
            this.PurchaseIdLabel.AutoSize = true;
            this.PurchaseIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseIdLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PurchaseIdLabel.Location = new System.Drawing.Point(89, 43);
            this.PurchaseIdLabel.Name = "PurchaseIdLabel";
            this.PurchaseIdLabel.Size = new System.Drawing.Size(0, 18);
            this.PurchaseIdLabel.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Id :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(27, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Détails de l\'achat";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PurchaseDataGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 157);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(420, 447);
            this.panel3.TabIndex = 2;
            // 
            // PurchaseDataGridView
            // 
            this.PurchaseDataGridView.AllowUserToAddRows = false;
            this.PurchaseDataGridView.AllowUserToDeleteRows = false;
            this.PurchaseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PurchaseDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PurchaseDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PurchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PurchaseDataGridView.Location = new System.Drawing.Point(3, 3);
            this.PurchaseDataGridView.MultiSelect = false;
            this.PurchaseDataGridView.Name = "PurchaseDataGridView";
            this.PurchaseDataGridView.ReadOnly = true;
            this.PurchaseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PurchaseDataGridView.Size = new System.Drawing.Size(414, 441);
            this.PurchaseDataGridView.TabIndex = 0;
            this.PurchaseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PurchaseDataGridView_CellContentClick);
            this.PurchaseDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.PurchaseDataGridView_CellFormatting);
            this.PurchaseDataGridView.SelectionChanged += new System.EventHandler(this.PurchaseDataGridView_SelectionChanged);
            // 
            // PurchaseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PurchaseUserControl";
            this.Size = new System.Drawing.Size(985, 604);
            this.Load += new System.EventHandler(this.SaleUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPurchaseDataGridView)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker PurchaseCreatedAtDateTimePicker;
        private System.Windows.Forms.Button AddPurchaseButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView PurchaseDataGridView;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView ProductPurchaseDataGridView;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label PurchaseTotalLabel;
        private System.Windows.Forms.Label PurchaseDateLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label PurchaseIdLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label PurchaseProductCountLabel;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label RevenueLabel;
        private System.Windows.Forms.Label ProductsCountLabel;
        private System.Windows.Forms.Label label3;
    }
}
