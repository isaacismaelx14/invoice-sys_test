namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvInvoiceData = new System.Windows.Forms.DataGridView();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbClientID = new System.Windows.Forms.TextBox();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.lbClientId = new System.Windows.Forms.Label();
            this.lbInvoiceId = new System.Windows.Forms.Label();
            this.tbInvoiceId = new System.Windows.Forms.TextBox();
            this.lbClientName = new System.Windows.Forms.Label();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.lbProductId = new System.Windows.Forms.Label();
            this.tbProductId = new System.Windows.Forms.TextBox();
            this.lbProductCount = new System.Windows.Forms.Label();
            this.tbProductCount = new System.Windows.Forms.NumericUpDown();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTotalTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoiceData
            // 
            this.dgvInvoiceData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoiceData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInvoiceData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.count,
            this.product,
            this.price,
            this.total});
            this.dgvInvoiceData.Location = new System.Drawing.Point(261, 104);
            this.dgvInvoiceData.Name = "dgvInvoiceData";
            this.dgvInvoiceData.Size = new System.Drawing.Size(883, 398);
            this.dgvInvoiceData.TabIndex = 0;
            // 
            // count
            // 
            this.count.HeaderText = "Cantidad";
            this.count.Name = "count";
            // 
            // product
            // 
            this.product.HeaderText = "Producto";
            this.product.Name = "product";
            // 
            // price
            // 
            this.price.HeaderText = "Precio";
            this.price.Name = "price";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // tbClientID
            // 
            this.tbClientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbClientID.Location = new System.Drawing.Point(261, 47);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.Size = new System.Drawing.Size(139, 28);
            this.tbClientID.TabIndex = 1;
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClient.Location = new System.Drawing.Point(406, 49);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(86, 28);
            this.btnSearchClient.TabIndex = 2;
            this.btnSearchClient.Text = "Buscar";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // lbClientId
            // 
            this.lbClientId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClientId.AutoSize = true;
            this.lbClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbClientId.Location = new System.Drawing.Point(258, 26);
            this.lbClientId.Name = "lbClientId";
            this.lbClientId.Size = new System.Drawing.Size(122, 18);
            this.lbClientId.TabIndex = 3;
            this.lbClientId.Text = "Codigo de cliente";
            // 
            // lbInvoiceId
            // 
            this.lbInvoiceId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInvoiceId.AutoSize = true;
            this.lbInvoiceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbInvoiceId.Location = new System.Drawing.Point(522, 26);
            this.lbInvoiceId.Name = "lbInvoiceId";
            this.lbInvoiceId.Size = new System.Drawing.Size(86, 18);
            this.lbInvoiceId.TabIndex = 5;
            this.lbInvoiceId.Text = "No. Factura";
            // 
            // tbInvoiceId
            // 
            this.tbInvoiceId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInvoiceId.Enabled = false;
            this.tbInvoiceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbInvoiceId.Location = new System.Drawing.Point(525, 49);
            this.tbInvoiceId.Name = "tbInvoiceId";
            this.tbInvoiceId.Size = new System.Drawing.Size(125, 28);
            this.tbInvoiceId.TabIndex = 4;
            // 
            // lbClientName
            // 
            this.lbClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClientName.AutoSize = true;
            this.lbClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbClientName.Location = new System.Drawing.Point(659, 26);
            this.lbClientName.Name = "lbClientName";
            this.lbClientName.Size = new System.Drawing.Size(45, 18);
            this.lbClientName.TabIndex = 7;
            this.lbClientName.Text = "Client";
            // 
            // tbClientName
            // 
            this.tbClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClientName.Enabled = false;
            this.tbClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbClientName.Location = new System.Drawing.Point(662, 51);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(479, 28);
            this.tbClientName.TabIndex = 6;
            // 
            // lbProductId
            // 
            this.lbProductId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProductId.AutoSize = true;
            this.lbProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbProductId.Location = new System.Drawing.Point(258, 515);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(142, 18);
            this.lbProductId.TabIndex = 9;
            this.lbProductId.Text = "Codigo del producto";
            // 
            // tbProductId
            // 
            this.tbProductId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbProductId.Location = new System.Drawing.Point(260, 536);
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.Size = new System.Drawing.Size(140, 28);
            this.tbProductId.TabIndex = 8;
            // 
            // lbProductCount
            // 
            this.lbProductCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProductCount.AutoSize = true;
            this.lbProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbProductCount.Location = new System.Drawing.Point(406, 515);
            this.lbProductCount.Name = "lbProductCount";
            this.lbProductCount.Size = new System.Drawing.Size(66, 18);
            this.lbProductCount.TabIndex = 11;
            this.lbProductCount.Text = "Cantidad";
            // 
            // tbProductCount
            // 
            this.tbProductCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tbProductCount.Location = new System.Drawing.Point(409, 536);
            this.tbProductCount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.tbProductCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbProductCount.Name = "tbProductCount";
            this.tbProductCount.Size = new System.Drawing.Size(120, 28);
            this.tbProductCount.TabIndex = 12;
            this.tbProductCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbProductCount.ValueChanged += new System.EventHandler(this.tbProductCount_ValueChanged);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbTotal.Location = new System.Drawing.Point(1012, 536);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(110, 25);
            this.lbTotal.TabIndex = 16;
            this.lbTotal.Text = "000,000.00";
            // 
            // lbTotalTitle
            // 
            this.lbTotalTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalTitle.AutoSize = true;
            this.lbTotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbTotalTitle.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbTotalTitle.Location = new System.Drawing.Point(957, 536);
            this.lbTotalTitle.Name = "lbTotalTitle";
            this.lbTotalTitle.Size = new System.Drawing.Size(62, 25);
            this.lbTotalTitle.TabIndex = 15;
            this.lbTotalTitle.Text = "Total:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(543, 536);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 28);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Añadir producto";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(962, 565);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(173, 43);
            this.btnComplete.TabIndex = 18;
            this.btnComplete.Text = "Facturar";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 619);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbTotalTitle);
            this.Controls.Add(this.tbProductCount);
            this.Controls.Add(this.lbProductCount);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.tbProductId);
            this.Controls.Add(this.lbClientName);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.lbInvoiceId);
            this.Controls.Add(this.tbInvoiceId);
            this.Controls.Add(this.lbClientId);
            this.Controls.Add(this.btnSearchClient);
            this.Controls.Add(this.tbClientID);
            this.Controls.Add(this.dgvInvoiceData);
            this.Name = "Form1";
            this.Text = "Punto de venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoiceData;
        private System.Windows.Forms.TextBox tbClientID;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.Label lbClientId;
        private System.Windows.Forms.Label lbInvoiceId;
        private System.Windows.Forms.TextBox tbInvoiceId;
        private System.Windows.Forms.Label lbClientName;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Label lbProductId;
        private System.Windows.Forms.TextBox tbProductId;
        private System.Windows.Forms.Label lbProductCount;
        private System.Windows.Forms.NumericUpDown tbProductCount;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTotalTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}

