
namespace PresentationLayer
{
    partial class TableOverview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTableNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbReceiptTotal = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.TProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.PId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDrinkType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWaiters = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTableNumber
            // 
            this.lbTableNumber.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableNumber.Location = new System.Drawing.Point(14, 14);
            this.lbTableNumber.Margin = new System.Windows.Forms.Padding(5);
            this.lbTableNumber.Name = "lbTableNumber";
            this.lbTableNumber.Size = new System.Drawing.Size(850, 45);
            this.lbTableNumber.TabIndex = 0;
            this.lbTableNumber.Text = "Broj stola : X";
            this.lbTableNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.panel1.Location = new System.Drawing.Point(59, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 5);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(30, 5, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trenutno za stolom";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(205)))), ((int)(((byte)(99)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(419, 191);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 65);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(419, 338);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 65);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Izbrisi";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbReceiptTotal
            // 
            this.lbReceiptTotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbReceiptTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbReceiptTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbReceiptTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbReceiptTotal.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceiptTotal.Location = new System.Drawing.Point(68, 527);
            this.lbReceiptTotal.Name = "lbReceiptTotal";
            this.lbReceiptTotal.Size = new System.Drawing.Size(261, 31);
            this.lbReceiptTotal.TabIndex = 7;
            this.lbReceiptTotal.Text = "Iznos racuna : X";
            this.lbReceiptTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(255)))), ((int)(((byte)(67)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(419, 459);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(135, 100);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Naplati";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AllowUserToOrderColumns = true;
            this.dgvTable.AllowUserToResizeColumns = false;
            this.dgvTable.AllowUserToResizeRows = false;
            this.dgvTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTable.ColumnHeadersVisible = false;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TProductId,
            this.TName,
            this.TQuantity,
            this.TAmount});
            this.dgvTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.dgvTable.Location = new System.Drawing.Point(20, 122);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dgvTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTable.RowTemplate.Height = 40;
            this.dgvTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(369, 365);
            this.dgvTable.TabIndex = 9;
            this.dgvTable.TabStop = false;
            // 
            // TProductId
            // 
            this.TProductId.HeaderText = "Product Id";
            this.TProductId.Name = "TProductId";
            this.TProductId.Visible = false;
            // 
            // TName
            // 
            this.TName.HeaderText = "Product Name";
            this.TName.Name = "TName";
            this.TName.ReadOnly = true;
            this.TName.Width = 215;
            // 
            // TQuantity
            // 
            this.TQuantity.HeaderText = "Product Quantity";
            this.TQuantity.Name = "TQuantity";
            this.TQuantity.ReadOnly = true;
            this.TQuantity.Width = 50;
            // 
            // TAmount
            // 
            this.TAmount.HeaderText = "Product Amount";
            this.TAmount.Name = "TAmount";
            this.TAmount.ReadOnly = true;
            this.TAmount.Width = 80;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToOrderColumns = true;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.ColumnHeadersVisible = false;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PId,
            this.PName,
            this.PPrice,
            this.PType});
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(147)))), ((int)(((byte)(68)))));
            this.dgvProducts.Location = new System.Drawing.Point(585, 122);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProducts.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProducts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvProducts.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProducts.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducts.RowTemplate.Height = 40;
            this.dgvProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(281, 365);
            this.dgvProducts.TabIndex = 10;
            this.dgvProducts.TabStop = false;
            // 
            // PId
            // 
            this.PId.HeaderText = "Id";
            this.PId.Name = "PId";
            this.PId.ReadOnly = true;
            this.PId.Visible = false;
            // 
            // PName
            // 
            this.PName.HeaderText = "Product Name";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Width = 190;
            // 
            // PPrice
            // 
            this.PPrice.HeaderText = "Product Price";
            this.PPrice.Name = "PPrice";
            this.PPrice.ReadOnly = true;
            this.PPrice.Width = 70;
            // 
            // PType
            // 
            this.PType.HeaderText = "Type";
            this.PType.Name = "PType";
            this.PType.ReadOnly = true;
            this.PType.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(585, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(30, 5, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Artikli";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDrinkType
            // 
            this.cbDrinkType.BackColor = System.Drawing.Color.Gray;
            this.cbDrinkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrinkType.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDrinkType.FormattingEnabled = true;
            this.cbDrinkType.Items.AddRange(new object[] {
            "Sve",
            "Topli napici",
            "Sokovi",
            "Piva",
            "Zestoka pica",
            "Energetska pica",
            "Vode"});
            this.cbDrinkType.Location = new System.Drawing.Point(641, 527);
            this.cbDrinkType.Name = "cbDrinkType";
            this.cbDrinkType.Size = new System.Drawing.Size(178, 31);
            this.cbDrinkType.TabIndex = 4;
            this.cbDrinkType.SelectedIndexChanged += new System.EventHandler(this.cbDrinkType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(638, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tip pica";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbWaiters
            // 
            this.cbWaiters.BackColor = System.Drawing.Color.Gray;
            this.cbWaiters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWaiters.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWaiters.FormattingEnabled = true;
            this.cbWaiters.Location = new System.Drawing.Point(379, 80);
            this.cbWaiters.Name = "cbWaiters";
            this.cbWaiters.Size = new System.Drawing.Size(221, 26);
            this.cbWaiters.TabIndex = 14;
            this.cbWaiters.SelectedIndexChanged += new System.EventHandler(this.cbWaiters_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(30, 2, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Konobar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(878, 579);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbWaiters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDrinkType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lbReceiptTotal);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTableNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TableOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Overview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableOverview_FormClosing);
            this.Load += new System.EventHandler(this.TableOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTableNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lbReceiptTotal;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDrinkType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAmount;
        private System.Windows.Forms.ComboBox cbWaiters;
        private System.Windows.Forms.Label label4;
    }
}