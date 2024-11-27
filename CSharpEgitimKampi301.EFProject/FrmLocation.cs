using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
	public partial class FrmLocation : Form
	{
		public FrmLocation()
		{
			InitializeComponent();
		}

		EfTravelDbEntities Db = new EfTravelDbEntities();

		Location location = new Location();
		private void btnList_Click(object sender, EventArgs e)
		{
			var value = Db.Location.ToList();

			dataGridView1.DataSource = value;
		}

		private void FrmLocation_Load(object sender, EventArgs e)
		{
			var value = Db.Guide.Select(x => new
			{
				FullName = x.GuideName + " " + x.GuideSurname,
				x.GuideId
			}).ToList();
			comboBoxGuideId.DisplayMember = "FullName";
			comboBoxGuideId.ValueMember = "GuideId";
			comboBoxGuideId.DataSource = value;

            
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			location.City = textBoxLocationCity.Text;

			location.Country = textBoxLocationCountry.Text;

			location.Capacity = byte.Parse(numericCapacity.Value.ToString());

			location.Price = Convert.ToDecimal(textBoxPrice.Text);

			location.DayNight = textBoxDayNight.Text;

			location.GuideId = Convert.ToInt16(comboBoxGuideId.SelectedValue.ToString());

			Db.Location.Add(location);

			Db.SaveChanges();

			MessageBox.Show("Ekleme Başarılı");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(textBoxLocationId.Text);

			var value = Db.Location.Where(x => x.LocationId == id).FirstOrDefault();

			//var value = Db.Location.Find(id);

			Db.Location.Remove(value);

			Db.SaveChanges();

			MessageBox.Show("Silme Başarılı");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(textBoxLocationId.Text);

			var updatedValue = Db.Location.Find(id);

			updatedValue.City = textBoxLocationCity.Text;

			updatedValue.Country = textBoxLocationCountry.Text;

			updatedValue.Capacity = byte.Parse(numericCapacity.Value.ToString());

			updatedValue.Price = Convert.ToDecimal(textBoxPrice.Text,new CultureInfo("tr-TR"));

			updatedValue.DayNight = textBoxDayNight.Text;

			updatedValue.GuideId = Convert.ToInt16(comboBoxGuideId.SelectedValue.ToString());

			Db.SaveChanges();

			MessageBox.Show("Güncelleme Başarılı");
		}
	}
}
