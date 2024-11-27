namespace CSharpEgitimKampi301.EFProject
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxGuideId = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBoxGuideSurname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxGuideName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnList = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnGetId = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.RosyBrown;
			this.btnAdd.Location = new System.Drawing.Point(164, 197);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(264, 40);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "EKLE";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(21, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Rehber ID:";
			// 
			// textBoxGuideId
			// 
			this.textBoxGuideId.Location = new System.Drawing.Point(164, 51);
			this.textBoxGuideId.Name = "textBoxGuideId";
			this.textBoxGuideId.Size = new System.Drawing.Size(264, 22);
			this.textBoxGuideId.TabIndex = 2;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(457, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(685, 393);
			this.dataGridView1.TabIndex = 3;
			// 
			// textBoxGuideSurname
			// 
			this.textBoxGuideSurname.Location = new System.Drawing.Point(164, 145);
			this.textBoxGuideSurname.Name = "textBoxGuideSurname";
			this.textBoxGuideSurname.Size = new System.Drawing.Size(264, 22);
			this.textBoxGuideSurname.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(21, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Rehber Soyadı:";
			// 
			// textBoxGuideName
			// 
			this.textBoxGuideName.Location = new System.Drawing.Point(164, 96);
			this.textBoxGuideName.Name = "textBoxGuideName";
			this.textBoxGuideName.Size = new System.Drawing.Size(264, 22);
			this.textBoxGuideName.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(21, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Rehber Adı:";
			// 
			// btnList
			// 
			this.btnList.BackColor = System.Drawing.Color.RosyBrown;
			this.btnList.Location = new System.Drawing.Point(164, 243);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(264, 43);
			this.btnList.TabIndex = 8;
			this.btnList.Text = "LİSTELE";
			this.btnList.UseVisualStyleBackColor = false;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.RosyBrown;
			this.btnUpdate.Location = new System.Drawing.Point(164, 292);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(264, 39);
			this.btnUpdate.TabIndex = 9;
			this.btnUpdate.Text = "GÜNCELLE";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.RosyBrown;
			this.btnDelete.Location = new System.Drawing.Point(164, 337);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(264, 39);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "SİL";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnGetId
			// 
			this.btnGetId.BackColor = System.Drawing.Color.RosyBrown;
			this.btnGetId.Location = new System.Drawing.Point(164, 382);
			this.btnGetId.Name = "btnGetId";
			this.btnGetId.Size = new System.Drawing.Size(264, 37);
			this.btnGetId.TabIndex = 11;
			this.btnGetId.Text = "ID\'YE GÖRE GETİR";
			this.btnGetId.UseVisualStyleBackColor = false;
			this.btnGetId.Click += new System.EventHandler(this.btnGetId_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1154, 450);
			this.Controls.Add(this.btnGetId);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.textBoxGuideName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxGuideSurname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBoxGuideId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAdd);
			this.Name = "Form1";
			this.Text = "Form İşlemleri";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxGuideId;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBoxGuideSurname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxGuideName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnGetId;
	}
}

