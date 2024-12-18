using CSharpEgitimKampi301.BusinessLayer.Abstract;
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
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

		public FrmCategory()
		{
			_categoryService = new CategoryManager(new EfCategoryDal());

			InitializeComponent();
		}

		

		private void btnListele_Click(object sender, EventArgs e)
		{
			var categoryList = _categoryService.TGetListAll();

			dataGridView1.DataSource = categoryList;
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			Category category = new Category();

			category.CategoryName = txtCategoryName.Text;

			category.CategoryStatus = true;

			_categoryService.TInsert(category);

			MessageBox.Show("EKLEME BAŞARILI");
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);

			var deletedValue = _categoryService.TGetById(id);

			_categoryService.TDelete(deletedValue);

			MessageBox.Show("SİLME BAŞARILI");
		}

		private void btnIdyeGoreGetir_Click(object sender, EventArgs e)
		{
			var id = Convert.ToInt32(txtCategoryId.Text);

			var value = _categoryService.TGetById(id);

			dataGridView1.DataSource = new List<Category> {value};
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			int updatedID = int.Parse(txtCategoryId.Text);

			var updatedValue = _categoryService.TGetById(updatedID);

			updatedValue.CategoryName = txtCategoryName.Text;

			updatedValue.CategoryStatus = true;

			_categoryService.TUpdate(updatedValue);

			MessageBox.Show("GÜNCELLEME BAŞARILI");
		}

		private void FrmCategory_Load(object sender, EventArgs e)
		{

		}
	}
}
