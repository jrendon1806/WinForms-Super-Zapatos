namespace WinShoeStore.Views
{
    partial class frmArticles
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
            btnLoadStock = new Button();
            dgvArticles = new DataGridView();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            StockTienda = new DataGridViewTextBoxColumn();
            StockAlmacen = new DataGridViewTextBoxColumn();
            StoreID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvArticles).BeginInit();
            SuspendLayout();
            // 
            // btnLoadStock
            // 
            btnLoadStock.Location = new Point(676, 12);
            btnLoadStock.Name = "btnLoadStock";
            btnLoadStock.Size = new Size(94, 66);
            btnLoadStock.TabIndex = 0;
            btnLoadStock.Text = "Cargar Inventario";
            btnLoadStock.UseVisualStyleBackColor = true;
            btnLoadStock.Click += btnLoadStock_Click;
            // 
            // dgvArticles
            // 
            dgvArticles.AllowUserToAddRows = false;
            dgvArticles.AllowUserToDeleteRows = false;
            dgvArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticles.Columns.AddRange(new DataGridViewColumn[] { Descripcion, Precio, StockTienda, StockAlmacen, StoreID });
            dgvArticles.Location = new Point(12, 12);
            dgvArticles.Name = "dgvArticles";
            dgvArticles.ReadOnly = true;
            dgvArticles.RowHeadersWidth = 51;
            dgvArticles.Size = new Size(645, 349);
            dgvArticles.TabIndex = 1;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 125;
            // 
            // StockTienda
            // 
            StockTienda.HeaderText = "StockTienda";
            StockTienda.MinimumWidth = 6;
            StockTienda.Name = "StockTienda";
            StockTienda.ReadOnly = true;
            StockTienda.Width = 125;
            // 
            // StockAlmacen
            // 
            StockAlmacen.HeaderText = "StockAlmacen";
            StockAlmacen.MinimumWidth = 6;
            StockAlmacen.Name = "StockAlmacen";
            StockAlmacen.ReadOnly = true;
            StockAlmacen.Width = 125;
            // 
            // StoreID
            // 
            StoreID.HeaderText = "StoreID";
            StoreID.MinimumWidth = 6;
            StoreID.Name = "StoreID";
            StoreID.ReadOnly = true;
            StoreID.Width = 125;
            // 
            // frmArticles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvArticles);
            Controls.Add(btnLoadStock);
            Name = "frmArticles";
            Text = "Super Zapatos";
            ((System.ComponentModel.ISupportInitialize)dgvArticles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadStock;
        private DataGridView dgvArticles;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn StockTienda;
        private DataGridViewTextBoxColumn StockAlmacen;
        private DataGridViewTextBoxColumn StoreID;
    }
}