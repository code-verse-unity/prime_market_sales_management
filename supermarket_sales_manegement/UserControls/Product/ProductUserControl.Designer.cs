namespace supermarket_sales_manegement.UserControls
{
    partial class ProductUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductPerishableCount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ProductNameToSearch = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.Modification = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Suppression = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.in_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ray_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_perishable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 137);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(578, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(419, 80);
            this.panel7.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.ProductPerishableCount);
            this.panel6.Location = new System.Drawing.Point(210, 7);
            this.panel6.Margin = new System.Windows.Forms.Padding(10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(199, 63);
            this.panel6.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Produits perissable :";
            // 
            // ProductPerishableCount
            // 
            this.ProductPerishableCount.AutoSize = true;
            this.ProductPerishableCount.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPerishableCount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ProductPerishableCount.Location = new System.Drawing.Point(13, 34);
            this.ProductPerishableCount.Name = "ProductPerishableCount";
            this.ProductPerishableCount.Size = new System.Drawing.Size(38, 17);
            this.ProductPerishableCount.TabIndex = 9;
            this.ProductPerishableCount.Text = "100";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.ProductCount);
            this.panel5.Location = new System.Drawing.Point(21, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(183, 63);
            this.panel5.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total de produits :";
            // 
            // ProductCount
            // 
            this.ProductCount.AutoSize = true;
            this.ProductCount.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ProductCount.Location = new System.Drawing.Point(13, 34);
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.Size = new System.Drawing.Size(38, 17);
            this.ProductCount.TabIndex = 9;
            this.ProductCount.Text = "150";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 80);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion des produits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ajouter, Modifier et supprimer des produits";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(997, 57);
            this.panel4.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.SearchButton);
            this.panel10.Controls.Add(this.ProductNameToSearch);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(405, 54);
            this.panel10.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SearchButton.Location = new System.Drawing.Point(271, 11);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(112, 34);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Rechercher";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ProductNameToSearch
            // 
            this.ProductNameToSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductNameToSearch.Location = new System.Drawing.Point(9, 17);
            this.ProductNameToSearch.Name = "ProductNameToSearch";
            this.ProductNameToSearch.Size = new System.Drawing.Size(259, 20);
            this.ProductNameToSearch.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightGray;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(648, 3);
            this.panel9.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button3);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(648, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(349, 57);
            this.panel8.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(22, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Nouveau produit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightGray;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(349, 3);
            this.panel11.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(193, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nouveau stock";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProductsDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 137);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.panel2.Size = new System.Drawing.Size(997, 482);
            this.panel2.TabIndex = 1;
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modification,
            this.Suppression,
            this.id,
            this.name,
            this.in_stock,
            this.ray_name,
            this.is_perishable,
            this.unit_price,
            this.unit});
            this.ProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsDataGridView.Location = new System.Drawing.Point(8, 0);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsDataGridView.Size = new System.Drawing.Size(981, 474);
            this.ProductsDataGridView.TabIndex = 0;
            this.ProductsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellContentClick);
            // 
            // Modification
            // 
            this.Modification.HeaderText = "Modifier";
            this.Modification.Name = "Modification";
            this.Modification.ReadOnly = true;
            // 
            // Suppression
            // 
            this.Suppression.HeaderText = "Supprimer";
            this.Suppression.Name = "Suppression";
            this.Suppression.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Designation";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // in_stock
            // 
            this.in_stock.HeaderText = "Nombre en stock";
            this.in_stock.Name = "in_stock";
            this.in_stock.ReadOnly = true;
            // 
            // ray_name
            // 
            this.ray_name.HeaderText = "Rayon";
            this.ray_name.Name = "ray_name";
            this.ray_name.ReadOnly = true;
            // 
            // is_perishable
            // 
            this.is_perishable.HeaderText = "Perissable";
            this.is_perishable.Name = "is_perishable";
            this.is_perishable.ReadOnly = true;
            // 
            // unit_price
            // 
            this.unit_price.HeaderText = "Prix d\'unite";
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.HeaderText = "Unite";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(997, 619);
            this.Load += new System.EventHandler(this.ProductUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn Modification;
        private System.Windows.Forms.DataGridViewButtonColumn Suppression;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn in_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ray_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_perishable;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ProductPerishableCount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProductCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox ProductNameToSearch;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button3;
    }
}
