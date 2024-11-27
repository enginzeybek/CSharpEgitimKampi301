namespace CSharpEgitimKampi301.EFProject
{
	partial class FrmLocation
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
			this.btnGetId = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.textBoxLocationCity = new System.Windows.Forms.TextBox();
			this.lblCity = new System.Windows.Forms.Label();
			this.textBoxLocationCountry = new System.Windows.Forms.TextBox();
			this.lblCountry = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBoxLocationId = new System.Windows.Forms.TextBox();
			this.lblLocation = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblCapacity = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.lblPrice = new System.Windows.Forms.Label();
			this.textBoxDayNight = new System.Windows.Forms.TextBox();
			this.lblDayNight = new System.Windows.Forms.Label();
			this.lblGuideId = new System.Windows.Forms.Label();
			this.numericCapacity = new System.Windows.Forms.NumericUpDown();
			this.comboBoxGuideId = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCapacity)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetId
			// 
			this.btnGetId.BackColor = System.Drawing.Color.Cyan;
			this.btnGetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGetId.Location = new System.Drawing.Point(180, 532);
			this.btnGetId.Name = "btnGetId";
			this.btnGetId.Size = new System.Drawing.Size(264, 37);
			this.btnGetId.TabIndex = 23;
			this.btnGetId.Text = "ID\'YE GÖRE GETİR";
			this.btnGetId.UseVisualStyleBackColor = false;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Cyan;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.Location = new System.Drawing.Point(180, 487);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(264, 39);
			this.btnDelete.TabIndex = 22;
			this.btnDelete.Text = "SİL";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.Cyan;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.Location = new System.Drawing.Point(180, 442);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(264, 39);
			this.btnUpdate.TabIndex = 21;
			this.btnUpdate.Text = "GÜNCELLE";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnList
			// 
			this.btnList.BackColor = System.Drawing.Color.Cyan;
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.Location = new System.Drawing.Point(180, 393);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(264, 43);
			this.btnList.TabIndex = 20;
			this.btnList.Text = "LİSTELE";
			this.btnList.UseVisualStyleBackColor = false;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// textBoxLocationCity
			// 
			this.textBoxLocationCity.Location = new System.Drawing.Point(180, 76);
			this.textBoxLocationCity.Name = "textBoxLocationCity";
			this.textBoxLocationCity.Size = new System.Drawing.Size(264, 22);
			this.textBoxLocationCity.TabIndex = 19;
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCity.Location = new System.Drawing.Point(22, 78);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(144, 20);
			this.lblCity.TabIndex = 18;
			this.lblCity.Text = "Lokasyon Şehri:";
			// 
			// textBoxLocationCountry
			// 
			this.textBoxLocationCountry.Location = new System.Drawing.Point(180, 126);
			this.textBoxLocationCountry.Name = "textBoxLocationCountry";
			this.textBoxLocationCountry.Size = new System.Drawing.Size(264, 22);
			this.textBoxLocationCountry.TabIndex = 17;
			// 
			// lblCountry
			// 
			this.lblCountry.AutoSize = true;
			this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCountry.Location = new System.Drawing.Point(22, 128);
			this.lblCountry.Name = "lblCountry";
			this.lblCountry.Size = new System.Drawing.Size(152, 20);
			this.lblCountry.TabIndex = 16;
			this.lblCountry.Text = "Lokasyon Ülkesi:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(458, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(976, 393);
			this.dataGridView1.TabIndex = 15;
			// 
			// textBoxLocationId
			// 
			this.textBoxLocationId.Location = new System.Drawing.Point(180, 30);
			this.textBoxLocationId.Name = "textBoxLocationId";
			this.textBoxLocationId.Size = new System.Drawing.Size(264, 22);
			this.textBoxLocationId.TabIndex = 14;
			// 
			// lblLocation
			// 
			this.lblLocation.AutoSize = true;
			this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblLocation.Location = new System.Drawing.Point(22, 32);
			this.lblLocation.Name = "lblLocation";
			this.lblLocation.Size = new System.Drawing.Size(119, 20);
			this.lblLocation.TabIndex = 13;
			this.lblLocation.Text = "Lokasyon ID:";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Cyan;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAdd.Location = new System.Drawing.Point(180, 347);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(264, 40);
			this.btnAdd.TabIndex = 12;
			this.btnAdd.Text = "EKLE";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblCapacity
			// 
			this.lblCapacity.AutoSize = true;
			this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCapacity.Location = new System.Drawing.Point(22, 172);
			this.lblCapacity.Name = "lblCapacity";
			this.lblCapacity.Size = new System.Drawing.Size(88, 20);
			this.lblCapacity.TabIndex = 24;
			this.lblCapacity.Text = "Kapasite:";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(180, 215);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(264, 22);
			this.textBoxPrice.TabIndex = 27;
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblPrice.Location = new System.Drawing.Point(22, 217);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(56, 20);
			this.lblPrice.TabIndex = 26;
			this.lblPrice.Text = "Fiyat:";
			// 
			// textBoxDayNight
			// 
			this.textBoxDayNight.Location = new System.Drawing.Point(180, 258);
			this.textBoxDayNight.Name = "textBoxDayNight";
			this.textBoxDayNight.Size = new System.Drawing.Size(264, 22);
			this.textBoxDayNight.TabIndex = 29;
			// 
			// lblDayNight
			// 
			this.lblDayNight.AutoSize = true;
			this.lblDayNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDayNight.Location = new System.Drawing.Point(22, 260);
			this.lblDayNight.Name = "lblDayNight";
			this.lblDayNight.Size = new System.Drawing.Size(99, 20);
			this.lblDayNight.TabIndex = 28;
			this.lblDayNight.Text = "Gün Gece:";
			// 
			// lblGuideId
			// 
			this.lblGuideId.AutoSize = true;
			this.lblGuideId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblGuideId.Location = new System.Drawing.Point(22, 309);
			this.lblGuideId.Name = "lblGuideId";
			this.lblGuideId.Size = new System.Drawing.Size(100, 20);
			this.lblGuideId.TabIndex = 30;
			this.lblGuideId.Text = "Rehber ID:";
			// 
			// numericCapacity
			// 
			this.numericCapacity.Location = new System.Drawing.Point(180, 173);
			this.numericCapacity.Name = "numericCapacity";
			this.numericCapacity.Size = new System.Drawing.Size(264, 22);
			this.numericCapacity.TabIndex = 32;
			// 
			// comboBoxGuideId
			// 
			this.comboBoxGuideId.FormattingEnabled = true;
			this.comboBoxGuideId.Location = new System.Drawing.Point(180, 305);
			this.comboBoxGuideId.Name = "comboBoxGuideId";
			this.comboBoxGuideId.Size = new System.Drawing.Size(264, 24);
			this.comboBoxGuideId.TabIndex = 33;
			// 
			// FrmLocation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1446, 599);
			this.Controls.Add(this.comboBoxGuideId);
			this.Controls.Add(this.numericCapacity);
			this.Controls.Add(this.lblGuideId);
			this.Controls.Add(this.textBoxDayNight);
			this.Controls.Add(this.lblDayNight);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.lblCapacity);
			this.Controls.Add(this.btnGetId);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.textBoxLocationCity);
			this.Controls.Add(this.lblCity);
			this.Controls.Add(this.textBoxLocationCountry);
			this.Controls.Add(this.lblCountry);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBoxLocationId);
			this.Controls.Add(this.lblLocation);
			this.Controls.Add(this.btnAdd);
			this.Name = "FrmLocation";
			this.Text = "FrmLocation";
			this.Load += new System.EventHandler(this.FrmLocation_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericCapacity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetId;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox textBoxLocationCity;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.TextBox textBoxLocationCountry;
		private System.Windows.Forms.Label lblCountry;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBoxLocationId;
		private System.Windows.Forms.Label lblLocation;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lblCapacity;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.TextBox textBoxDayNight;
		private System.Windows.Forms.Label lblDayNight;
		private System.Windows.Forms.Label lblGuideId;
		private System.Windows.Forms.NumericUpDown numericCapacity;
		private System.Windows.Forms.ComboBox comboBoxGuideId;
	}
}