namespace AdoNetDemo
{
    partial class Form1
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblUnitPrize = new System.Windows.Forms.Label();
            this.TxtUnitPrize = new System.Windows.Forms.TextBox();
            this.LblStockAmount = new System.Windows.Forms.Label();
            this.TxtStockAmount = new System.Windows.Forms.TextBox();
            this.gpbxadaproduct = new System.Windows.Forms.GroupBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.gbxUpdateAProduct = new System.Windows.Forms.GroupBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtUnitPrizeUpdate = new System.Windows.Forms.TextBox();
            this.TxtStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.LblNameUpdate = new System.Windows.Forms.Label();
            this.LblStockAmountUpdate = new System.Windows.Forms.Label();
            this.TxtNameUpdate = new System.Windows.Forms.TextBox();
            this.LblUnitPrizeUpdate = new System.Windows.Forms.Label();
            this.BtnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gpbxadaproduct.SuspendLayout();
            this.gbxUpdateAProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(1, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(787, 175);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblName.Location = new System.Drawing.Point(36, 49);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(47, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name :";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(129, 49);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 2;
            // 
            // LblUnitPrize
            // 
            this.LblUnitPrize.AutoSize = true;
            this.LblUnitPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUnitPrize.Location = new System.Drawing.Point(36, 85);
            this.LblUnitPrize.Name = "LblUnitPrize";
            this.LblUnitPrize.Size = new System.Drawing.Size(70, 13);
            this.LblUnitPrize.TabIndex = 1;
            this.LblUnitPrize.Text = "Unit Prize :";
            // 
            // TxtUnitPrize
            // 
            this.TxtUnitPrize.Location = new System.Drawing.Point(129, 82);
            this.TxtUnitPrize.Name = "TxtUnitPrize";
            this.TxtUnitPrize.Size = new System.Drawing.Size(100, 20);
            this.TxtUnitPrize.TabIndex = 2;
            // 
            // LblStockAmount
            // 
            this.LblStockAmount.AutoSize = true;
            this.LblStockAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStockAmount.Location = new System.Drawing.Point(36, 124);
            this.LblStockAmount.Name = "LblStockAmount";
            this.LblStockAmount.Size = new System.Drawing.Size(94, 13);
            this.LblStockAmount.TabIndex = 1;
            this.LblStockAmount.Text = "Stock Amount :";
            // 
            // TxtStockAmount
            // 
            this.TxtStockAmount.Location = new System.Drawing.Point(129, 124);
            this.TxtStockAmount.Name = "TxtStockAmount";
            this.TxtStockAmount.Size = new System.Drawing.Size(100, 20);
            this.TxtStockAmount.TabIndex = 2;
            // 
            // gpbxadaproduct
            // 
            this.gpbxadaproduct.Controls.Add(this.BtnAdd);
            this.gpbxadaproduct.Controls.Add(this.TxtUnitPrize);
            this.gpbxadaproduct.Controls.Add(this.TxtStockAmount);
            this.gpbxadaproduct.Controls.Add(this.LblName);
            this.gpbxadaproduct.Controls.Add(this.LblStockAmount);
            this.gpbxadaproduct.Controls.Add(this.TxtName);
            this.gpbxadaproduct.Controls.Add(this.LblUnitPrize);
            this.gpbxadaproduct.Location = new System.Drawing.Point(12, 193);
            this.gpbxadaproduct.Name = "gpbxadaproduct";
            this.gpbxadaproduct.Size = new System.Drawing.Size(343, 245);
            this.gpbxadaproduct.TabIndex = 3;
            this.gpbxadaproduct.TabStop = false;
            this.gpbxadaproduct.Text = "Add a product";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(129, 168);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 23);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // gbxUpdateAProduct
            // 
            this.gbxUpdateAProduct.Controls.Add(this.BtnUpdate);
            this.gbxUpdateAProduct.Controls.Add(this.TxtUnitPrizeUpdate);
            this.gbxUpdateAProduct.Controls.Add(this.TxtStockAmountUpdate);
            this.gbxUpdateAProduct.Controls.Add(this.LblNameUpdate);
            this.gbxUpdateAProduct.Controls.Add(this.LblStockAmountUpdate);
            this.gbxUpdateAProduct.Controls.Add(this.TxtNameUpdate);
            this.gbxUpdateAProduct.Controls.Add(this.LblUnitPrizeUpdate);
            this.gbxUpdateAProduct.Location = new System.Drawing.Point(373, 203);
            this.gbxUpdateAProduct.Name = "gbxUpdateAProduct";
            this.gbxUpdateAProduct.Size = new System.Drawing.Size(343, 245);
            this.gbxUpdateAProduct.TabIndex = 3;
            this.gbxUpdateAProduct.TabStop = false;
            this.gbxUpdateAProduct.Text = "Update a product";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(129, 168);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(100, 23);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtUnitPrizeUpdate
            // 
            this.TxtUnitPrizeUpdate.Location = new System.Drawing.Point(129, 82);
            this.TxtUnitPrizeUpdate.Name = "TxtUnitPrizeUpdate";
            this.TxtUnitPrizeUpdate.Size = new System.Drawing.Size(100, 20);
            this.TxtUnitPrizeUpdate.TabIndex = 2;
            // 
            // TxtStockAmountUpdate
            // 
            this.TxtStockAmountUpdate.Location = new System.Drawing.Point(129, 124);
            this.TxtStockAmountUpdate.Name = "TxtStockAmountUpdate";
            this.TxtStockAmountUpdate.Size = new System.Drawing.Size(100, 20);
            this.TxtStockAmountUpdate.TabIndex = 2;
            // 
            // LblNameUpdate
            // 
            this.LblNameUpdate.AutoSize = true;
            this.LblNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNameUpdate.Location = new System.Drawing.Point(36, 49);
            this.LblNameUpdate.Name = "LblNameUpdate";
            this.LblNameUpdate.Size = new System.Drawing.Size(47, 13);
            this.LblNameUpdate.TabIndex = 1;
            this.LblNameUpdate.Text = "Name :";
            // 
            // LblStockAmountUpdate
            // 
            this.LblStockAmountUpdate.AutoSize = true;
            this.LblStockAmountUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStockAmountUpdate.Location = new System.Drawing.Point(36, 124);
            this.LblStockAmountUpdate.Name = "LblStockAmountUpdate";
            this.LblStockAmountUpdate.Size = new System.Drawing.Size(94, 13);
            this.LblStockAmountUpdate.TabIndex = 1;
            this.LblStockAmountUpdate.Text = "Stock Amount :";
            // 
            // TxtNameUpdate
            // 
            this.TxtNameUpdate.Location = new System.Drawing.Point(129, 49);
            this.TxtNameUpdate.Name = "TxtNameUpdate";
            this.TxtNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.TxtNameUpdate.TabIndex = 2;
            // 
            // LblUnitPrizeUpdate
            // 
            this.LblUnitPrizeUpdate.AutoSize = true;
            this.LblUnitPrizeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUnitPrizeUpdate.Location = new System.Drawing.Point(36, 85);
            this.LblUnitPrizeUpdate.Name = "LblUnitPrizeUpdate";
            this.LblUnitPrizeUpdate.Size = new System.Drawing.Size(70, 13);
            this.LblUnitPrizeUpdate.TabIndex = 1;
            this.LblUnitPrizeUpdate.Text = "Unit Prize :";
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(502, 523);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(100, 23);
            this.BtnRemove.TabIndex = 4;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.gbxUpdateAProduct);
            this.Controls.Add(this.gpbxadaproduct);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gpbxadaproduct.ResumeLayout(false);
            this.gpbxadaproduct.PerformLayout();
            this.gbxUpdateAProduct.ResumeLayout(false);
            this.gbxUpdateAProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblUnitPrize;
        private System.Windows.Forms.TextBox TxtUnitPrize;
        private System.Windows.Forms.Label LblStockAmount;
        private System.Windows.Forms.TextBox TxtStockAmount;
        private System.Windows.Forms.GroupBox gpbxadaproduct;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox gbxUpdateAProduct;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtUnitPrizeUpdate;
        private System.Windows.Forms.TextBox TxtStockAmountUpdate;
        private System.Windows.Forms.Label LblNameUpdate;
        private System.Windows.Forms.Label LblStockAmountUpdate;
        private System.Windows.Forms.TextBox TxtNameUpdate;
        private System.Windows.Forms.Label LblUnitPrizeUpdate;
        private System.Windows.Forms.Button BtnRemove;
    }
}

