namespace CSharpEgitimKampi301.PresentationLayer
{
    partial class FrmCategory
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
			this.lblCategoryID = new System.Windows.Forms.Label();
			this.btnEkle = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.lblCategoryName = new System.Windows.Forms.Label();
			this.lblCategoryStatus = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnIdyeGoreGetir = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnListele = new System.Windows.Forms.Button();
			this.rbPasive = new System.Windows.Forms.RadioButton();
			this.rbActive = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblCategoryID
			// 
			this.lblCategoryID.AutoSize = true;
			this.lblCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCategoryID.Location = new System.Drawing.Point(42, 62);
			this.lblCategoryID.Name = "lblCategoryID";
			this.lblCategoryID.Size = new System.Drawing.Size(110, 22);
			this.lblCategoryID.TabIndex = 1;
			this.lblCategoryID.Text = "CategoryID";
			// 
			// btnEkle
			// 
			this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnEkle.Location = new System.Drawing.Point(185, 278);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(161, 35);
			this.btnEkle.TabIndex = 0;
			this.btnEkle.Text = "EKLE";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(663, 26);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(709, 675);
			this.dataGridView1.TabIndex = 2;
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Location = new System.Drawing.Point(260, 62);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(326, 22);
			this.txtCategoryId.TabIndex = 2;
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(260, 120);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(326, 22);
			this.txtCategoryName.TabIndex = 4;
			// 
			// lblCategoryName
			// 
			this.lblCategoryName.AutoSize = true;
			this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCategoryName.Location = new System.Drawing.Point(42, 118);
			this.lblCategoryName.Name = "lblCategoryName";
			this.lblCategoryName.Size = new System.Drawing.Size(120, 22);
			this.lblCategoryName.TabIndex = 3;
			this.lblCategoryName.Text = "Kategori Adı";
			// 
			// lblCategoryStatus
			// 
			this.lblCategoryStatus.AutoSize = true;
			this.lblCategoryStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCategoryStatus.Location = new System.Drawing.Point(42, 195);
			this.lblCategoryStatus.Name = "lblCategoryStatus";
			this.lblCategoryStatus.Size = new System.Drawing.Size(160, 22);
			this.lblCategoryStatus.TabIndex = 5;
			this.lblCategoryStatus.Text = "Kategori Durumu";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MistyRose;
			this.panel1.Controls.Add(this.btnIdyeGoreGetir);
			this.panel1.Controls.Add(this.btnSil);
			this.panel1.Controls.Add(this.btnGuncelle);
			this.panel1.Controls.Add(this.btnListele);
			this.panel1.Controls.Add(this.rbPasive);
			this.panel1.Controls.Add(this.rbActive);
			this.panel1.Controls.Add(this.btnEkle);
			this.panel1.Controls.Add(this.lblCategoryID);
			this.panel1.Controls.Add(this.lblCategoryStatus);
			this.panel1.Controls.Add(this.txtCategoryId);
			this.panel1.Controls.Add(this.txtCategoryName);
			this.panel1.Controls.Add(this.lblCategoryName);
			this.panel1.Location = new System.Drawing.Point(12, 26);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(607, 649);
			this.panel1.TabIndex = 0;
			// 
			// btnIdyeGoreGetir
			// 
			this.btnIdyeGoreGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnIdyeGoreGetir.Location = new System.Drawing.Point(185, 536);
			this.btnIdyeGoreGetir.Name = "btnIdyeGoreGetir";
			this.btnIdyeGoreGetir.Size = new System.Drawing.Size(161, 35);
			this.btnIdyeGoreGetir.TabIndex = 11;
			this.btnIdyeGoreGetir.Text = "ID\'YE GÖRE GETİR";
			this.btnIdyeGoreGetir.UseVisualStyleBackColor = true;
			this.btnIdyeGoreGetir.Click += new System.EventHandler(this.btnIdyeGoreGetir_Click);
			// 
			// btnSil
			// 
			this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSil.Location = new System.Drawing.Point(185, 471);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(161, 35);
			this.btnSil.TabIndex = 10;
			this.btnSil.Text = "SİL";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.Location = new System.Drawing.Point(185, 402);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(161, 35);
			this.btnGuncelle.TabIndex = 9;
			this.btnGuncelle.Text = "GÜNCELLE";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnListele
			// 
			this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnListele.Location = new System.Drawing.Point(185, 336);
			this.btnListele.Name = "btnListele";
			this.btnListele.Size = new System.Drawing.Size(161, 35);
			this.btnListele.TabIndex = 8;
			this.btnListele.Text = "LİSTELE";
			this.btnListele.UseVisualStyleBackColor = true;
			this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
			// 
			// rbPasive
			// 
			this.rbPasive.AutoSize = true;
			this.rbPasive.Location = new System.Drawing.Point(433, 198);
			this.rbPasive.Name = "rbPasive";
			this.rbPasive.Size = new System.Drawing.Size(111, 20);
			this.rbPasive.TabIndex = 7;
			this.rbPasive.TabStop = true;
			this.rbPasive.Text = "Pasif Kategori";
			this.rbPasive.UseVisualStyleBackColor = true;
			// 
			// rbActive
			// 
			this.rbActive.AutoSize = true;
			this.rbActive.Location = new System.Drawing.Point(260, 198);
			this.rbActive.Name = "rbActive";
			this.rbActive.Size = new System.Drawing.Size(106, 20);
			this.rbActive.TabIndex = 6;
			this.rbActive.TabStop = true;
			this.rbActive.Text = "Aktif Kategori";
			this.rbActive.UseVisualStyleBackColor = true;
			// 
			// FrmCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1440, 713);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FrmCategory";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.FrmCategory_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Label lblCategoryID;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.Label lblCategoryName;
		private System.Windows.Forms.Label lblCategoryStatus;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbPasive;
		private System.Windows.Forms.RadioButton rbActive;
		private System.Windows.Forms.Button btnIdyeGoreGetir;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnListele;
	}
}

