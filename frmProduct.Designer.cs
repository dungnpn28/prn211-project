namespace ShopManagementSystem
{
    partial class frmProduct
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboMaterialName = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.lbImage = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtImportPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbImportPrice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbMaterialId = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbProductId = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lbProduct = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDisplay);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSkip);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 68);
            this.panel1.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(659, 23);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 25;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(558, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(760, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(457, 23);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 23);
            this.btnSkip.TabIndex = 22;
            this.btnSkip.Text = "&Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(356, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(255, 23);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 20;
            this.btnModify.Text = "&Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(154, 23);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "&Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboMaterialName);
            this.panel2.Controls.Add(this.btnOpen);
            this.panel2.Controls.Add(this.txtNote);
            this.panel2.Controls.Add(this.txtImage);
            this.panel2.Controls.Add(this.lbNote);
            this.panel2.Controls.Add(this.lbImage);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtImportPrice);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.txtProductId);
            this.panel2.Controls.Add(this.lbPrice);
            this.panel2.Controls.Add(this.lbImportPrice);
            this.panel2.Controls.Add(this.lbQuantity);
            this.panel2.Controls.Add(this.lbMaterialId);
            this.panel2.Controls.Add(this.lbProductName);
            this.panel2.Controls.Add(this.lbProductId);
            this.panel2.Controls.Add(this.picImage);
            this.panel2.Controls.Add(this.lbProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 199);
            this.panel2.TabIndex = 1;
            // 
            // cboMaterialName
            // 
            this.cboMaterialName.FormattingEnabled = true;
            this.cboMaterialName.Location = new System.Drawing.Point(118, 85);
            this.cboMaterialName.Name = "cboMaterialName";
            this.cboMaterialName.Size = new System.Drawing.Size(212, 24);
            this.cboMaterialName.TabIndex = 19;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(639, 37);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(55, 42);
            this.btnOpen.TabIndex = 18;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(411, 88);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(222, 89);
            this.txtNote.TabIndex = 17;
            this.txtNote.Text = "";
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(411, 43);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(222, 22);
            this.txtImage.TabIndex = 16;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(357, 85);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(39, 16);
            this.lbNote.TabIndex = 15;
            this.lbNote.Text = "Note:";
            // 
            // lbImage
            // 
            this.lbImage.AutoSize = true;
            this.lbImage.Location = new System.Drawing.Point(357, 43);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(48, 16);
            this.lbImage.TabIndex = 14;
            this.lbImage.Text = "Image:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(118, 157);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(212, 22);
            this.txtPrice.TabIndex = 13;
            // 
            // txtImportPrice
            // 
            this.txtImportPrice.Location = new System.Drawing.Point(118, 133);
            this.txtImportPrice.Name = "txtImportPrice";
            this.txtImportPrice.Size = new System.Drawing.Size(212, 22);
            this.txtImportPrice.TabIndex = 12;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(118, 109);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(212, 22);
            this.txtQuantity.TabIndex = 11;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(118, 61);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(212, 22);
            this.txtProductName.TabIndex = 9;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(118, 37);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(212, 22);
            this.txtProductId.TabIndex = 8;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(13, 160);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(41, 16);
            this.lbPrice.TabIndex = 7;
            this.lbPrice.Text = "Price:";
            // 
            // lbImportPrice
            // 
            this.lbImportPrice.AutoSize = true;
            this.lbImportPrice.Location = new System.Drawing.Point(12, 136);
            this.lbImportPrice.Name = "lbImportPrice";
            this.lbImportPrice.Size = new System.Drawing.Size(78, 16);
            this.lbImportPrice.TabIndex = 6;
            this.lbImportPrice.Text = "ImportPrice:";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(12, 112);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(58, 16);
            this.lbQuantity.TabIndex = 5;
            this.lbQuantity.Text = "Quantity:";
            // 
            // lbMaterialId
            // 
            this.lbMaterialId.AutoSize = true;
            this.lbMaterialId.Location = new System.Drawing.Point(12, 88);
            this.lbMaterialId.Name = "lbMaterialId";
            this.lbMaterialId.Size = new System.Drawing.Size(98, 16);
            this.lbMaterialId.TabIndex = 4;
            this.lbMaterialId.Text = "Material Name:";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(12, 64);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(96, 16);
            this.lbProductName.TabIndex = 3;
            this.lbProductName.Text = "Product Name:";
            // 
            // lbProductId
            // 
            this.lbProductId.AutoSize = true;
            this.lbProductId.Location = new System.Drawing.Point(12, 40);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(72, 16);
            this.lbProductId.TabIndex = 2;
            this.lbProductId.Text = "Product ID:";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(701, 40);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(176, 137);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduct.Location = new System.Drawing.Point(386, 9);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(116, 29);
            this.lbProduct.TabIndex = 0;
            this.lbProduct.Text = "Products";
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(0, 199);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(889, 264);
            this.dgvProduct.TabIndex = 2;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 531);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label lbImage;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtImportPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbImportPrice;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbMaterialId;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbProductId;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.ComboBox cboMaterialName;
    }
}