namespace CSharpEgitimKampi301.PresentationLayer
{
	partial class FrmProduct
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
			this.btnListele2 = new System.Windows.Forms.Button();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.lblCategory = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.lblProductPrice = new System.Windows.Forms.Label();
			this.txtProductDescription = new System.Windows.Forms.TextBox();
			this.lblProductDescription = new System.Windows.Forms.Label();
			this.txtProductStock = new System.Windows.Forms.TextBox();
			this.lblProductStock = new System.Windows.Forms.Label();
			this.btnIdyeGoreGetir = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnListele = new System.Windows.Forms.Button();
			this.btnEkle = new System.Windows.Forms.Button();
			this.lblProductID = new System.Windows.Forms.Label();
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.lblProductName = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MistyRose;
			this.panel1.Controls.Add(this.btnListele2);
			this.panel1.Controls.Add(this.cmbCategory);
			this.panel1.Controls.Add(this.lblCategory);
			this.panel1.Controls.Add(this.txtProductPrice);
			this.panel1.Controls.Add(this.lblProductPrice);
			this.panel1.Controls.Add(this.txtProductDescription);
			this.panel1.Controls.Add(this.lblProductDescription);
			this.panel1.Controls.Add(this.txtProductStock);
			this.panel1.Controls.Add(this.lblProductStock);
			this.panel1.Controls.Add(this.btnIdyeGoreGetir);
			this.panel1.Controls.Add(this.btnSil);
			this.panel1.Controls.Add(this.btnGuncelle);
			this.panel1.Controls.Add(this.btnListele);
			this.panel1.Controls.Add(this.btnEkle);
			this.panel1.Controls.Add(this.lblProductID);
			this.panel1.Controls.Add(this.txtProductId);
			this.panel1.Controls.Add(this.txtProductName);
			this.panel1.Controls.Add(this.lblProductName);
			this.panel1.Location = new System.Drawing.Point(17, 29);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(546, 692);
			this.panel1.TabIndex = 0;
			// 
			// btnListele2
			// 
			this.btnListele2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnListele2.Location = new System.Drawing.Point(290, 472);
			this.btnListele2.Name = "btnListele2";
			this.btnListele2.Size = new System.Drawing.Size(145, 35);
			this.btnListele2.TabIndex = 17;
			this.btnListele2.Text = "LİSTELE2";
			this.btnListele2.UseVisualStyleBackColor = true;
			this.btnListele2.Click += new System.EventHandler(this.btnListele2_Click);
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(199, 208);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(326, 24);
			this.cmbCategory.TabIndex = 10;
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCategory.Location = new System.Drawing.Point(18, 208);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(85, 22);
			this.lblCategory.TabIndex = 9;
			this.lblCategory.Text = "Kategori";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Location = new System.Drawing.Point(199, 170);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.Size = new System.Drawing.Size(326, 22);
			this.txtProductPrice.TabIndex = 8;
			// 
			// lblProductPrice
			// 
			this.lblProductPrice.AutoSize = true;
			this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductPrice.Location = new System.Drawing.Point(18, 170);
			this.lblProductPrice.Name = "lblProductPrice";
			this.lblProductPrice.Size = new System.Drawing.Size(108, 22);
			this.lblProductPrice.TabIndex = 7;
			this.lblProductPrice.Text = "Ürün Fiyatı";
			// 
			// txtProductDescription
			// 
			this.txtProductDescription.Location = new System.Drawing.Point(199, 245);
			this.txtProductDescription.Multiline = true;
			this.txtProductDescription.Name = "txtProductDescription";
			this.txtProductDescription.Size = new System.Drawing.Size(326, 162);
			this.txtProductDescription.TabIndex = 12;
			// 
			// lblProductDescription
			// 
			this.lblProductDescription.AutoSize = true;
			this.lblProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductDescription.Location = new System.Drawing.Point(18, 245);
			this.lblProductDescription.Name = "lblProductDescription";
			this.lblProductDescription.Size = new System.Drawing.Size(154, 22);
			this.lblProductDescription.TabIndex = 11;
			this.lblProductDescription.Text = "Ürün Açıklaması";
			// 
			// txtProductStock
			// 
			this.txtProductStock.Location = new System.Drawing.Point(199, 119);
			this.txtProductStock.Name = "txtProductStock";
			this.txtProductStock.Size = new System.Drawing.Size(326, 22);
			this.txtProductStock.TabIndex = 6;
			// 
			// lblProductStock
			// 
			this.lblProductStock.AutoSize = true;
			this.lblProductStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductStock.Location = new System.Drawing.Point(18, 119);
			this.lblProductStock.Name = "lblProductStock";
			this.lblProductStock.Size = new System.Drawing.Size(110, 22);
			this.lblProductStock.TabIndex = 5;
			this.lblProductStock.Text = "Ürün Adedi";
			// 
			// btnIdyeGoreGetir
			// 
			this.btnIdyeGoreGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnIdyeGoreGetir.Location = new System.Drawing.Point(175, 595);
			this.btnIdyeGoreGetir.Name = "btnIdyeGoreGetir";
			this.btnIdyeGoreGetir.Size = new System.Drawing.Size(260, 35);
			this.btnIdyeGoreGetir.TabIndex = 0;
			this.btnIdyeGoreGetir.Text = "ID\'YE GÖRE GETİR";
			this.btnIdyeGoreGetir.UseVisualStyleBackColor = true;
			this.btnIdyeGoreGetir.Click += new System.EventHandler(this.btnIdyeGoreGetir_Click);
			// 
			// btnSil
			// 
			this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSil.Location = new System.Drawing.Point(175, 554);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(260, 35);
			this.btnSil.TabIndex = 16;
			this.btnSil.Text = "SİL";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.Location = new System.Drawing.Point(175, 513);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(260, 35);
			this.btnGuncelle.TabIndex = 15;
			this.btnGuncelle.Text = "GÜNCELLE";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnListele
			// 
			this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnListele.Location = new System.Drawing.Point(175, 472);
			this.btnListele.Name = "btnListele";
			this.btnListele.Size = new System.Drawing.Size(109, 35);
			this.btnListele.TabIndex = 14;
			this.btnListele.Text = "LİSTELE";
			this.btnListele.UseVisualStyleBackColor = true;
			this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
			// 
			// btnEkle
			// 
			this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnEkle.Location = new System.Drawing.Point(175, 431);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(260, 35);
			this.btnEkle.TabIndex = 13;
			this.btnEkle.Text = "EKLE";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// lblProductID
			// 
			this.lblProductID.AutoSize = true;
			this.lblProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductID.Location = new System.Drawing.Point(18, 12);
			this.lblProductID.Name = "lblProductID";
			this.lblProductID.Size = new System.Drawing.Size(72, 22);
			this.lblProductID.TabIndex = 1;
			this.lblProductID.Text = "ÜrünID";
			// 
			// txtProductId
			// 
			this.txtProductId.Location = new System.Drawing.Point(199, 14);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(326, 22);
			this.txtProductId.TabIndex = 2;
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(199, 66);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(326, 22);
			this.txtProductName.TabIndex = 4;
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductName.Location = new System.Drawing.Point(18, 66);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(88, 22);
			this.lblProductName.TabIndex = 3;
			this.lblProductName.Text = "Ürün Adı";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(569, 29);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1189, 692);
			this.dataGridView1.TabIndex = 4;
			// 
			// FrmProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.ClientSize = new System.Drawing.Size(1770, 733);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FrmProduct";
			this.Text = "FrmProduct";
			this.Load += new System.EventHandler(this.FrmProduct_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnIdyeGoreGetir;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnListele;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Label lblProductID;
		private System.Windows.Forms.TextBox txtProductId;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtProductStock;
		private System.Windows.Forms.Label lblProductStock;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.Label lblProductPrice;
		private System.Windows.Forms.TextBox txtProductDescription;
		private System.Windows.Forms.Label lblProductDescription;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.Button btnListele2;
	}
}