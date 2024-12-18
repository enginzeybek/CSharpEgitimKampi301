using CSharpEgitimKampi301.BusinessLayer.Concreate;
using CSharpEgitimKampi301.DataAccessLayer.Entity_Framework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
	public partial class FrmProduct : Form
	{
		public FrmProduct()
		{
			InitializeComponent();
		}

		ProductManager productManager = new ProductManager(new EfProductDal()); // bu başka bir yöntem. CTOR dışında dependency olmuyor ama.

		CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

		Product product = new Product();
		private void btnListele_Click(object sender, EventArgs e)
		{
			var value = productManager.TGetListAll();

			dataGridView1.DataSource = value;
		}

		private void btnListele2_Click(object sender, EventArgs e)
		{
			var value = productManager.TGetProductsWithCategory();

			dataGridView1.DataSource= value;
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			product.ProductName = txtProductName.Text;

			product.ProductStock = int.Parse(txtProductStock.Text);

			product.ProductPrice = Convert.ToDecimal(txtProductPrice.Text);

			product.CategoryId = int.Parse(cmbCategory.SelectedItem.ToString());

			product.ProductDescription = txtProductDescription.Text;

			productManager.TInsert(product);

			MessageBox.Show("ÜRÜN EKLENDİ");
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			int deletedID = Convert.ToInt32(txtProductId.Text);

			var deletedItem = productManager.TGetById(deletedID);
			
			productManager.TDelete(deletedItem);

			MessageBox.Show("ÜRÜN SİLİNMİŞTİR");
		}

		private void btnIdyeGoreGetir_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtProductId.Text);

			var value = productManager.TGetById(id);

			dataGridView1.DataSource= new List<Product> {value};
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			int updatedID = Convert.ToInt32(txtProductId.Text);

			var updatedValue = productManager.TGetById(updatedID);

			updatedValue.ProductName = txtProductName.Text;

			updatedValue.ProductStock = int.Parse(txtProductStock.Text);

			updatedValue.ProductPrice = Convert.ToDecimal(txtProductPrice.Text);

			updatedValue.CategoryId = int.Parse(cmbCategory.SelectedItem.ToString());

			updatedValue.ProductDescription = txtProductDescription.Text;

			productManager.TUpdate(updatedValue);

			MessageBox.Show("ÜRÜN GÜNCELLENDİ");
		}

		private void FrmProduct_Load(object sender, EventArgs e)
		{
			var value = categoryManager.TGetListAll();

			cmbCategory.DataSource= value;

			cmbCategory.DisplayMember = "CategoryName";

			cmbCategory.ValueMember = "CategoryId";
		}
	}
}
