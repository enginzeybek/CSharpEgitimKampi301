using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		EfTravelDbEntities db = new EfTravelDbEntities();

		Guide guide = new Guide();
		private void btnList_Click(object sender, EventArgs e)
		{
            //Guide guide = new Guide();

            //guide.GuideName = textBoxGuideName.Text;

            //guide.GuideSurname = textBoxGuideSurname.Text;

            //dataGridView1.Rows.Add(guide.GuideName);
            //dataGridView1.Rows.Add(guide.GuideSurname);

            EfTravelDbEntities db = new EfTravelDbEntities();

            var values = db.Guide.ToList();

            dataGridView1.DataSource = values;

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
            var name = textBoxGuideName.Text;

            var Surname = textBoxGuideSurname.Text;

            guide.GuideName = name;

            guide.GuideSurname = Surname;

            db.Guide.Add(guide);

            db.SaveChanges();

            MessageBox.Show("REHBER EKLENDİ");

            
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
            int id = Convert.ToInt32(textBoxGuideId.Text);

            var value = db.Guide.Find(id);

            db.Guide.Remove(value);

            db.SaveChanges();

            MessageBox.Show("REHBER SİLİNDİ");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
            int id = Convert.ToInt32(textBoxGuideId.Text);

            var value = db.Guide.Find(id);

            value.GuideName = textBoxGuideName.Text;

            value.GuideSurname = textBoxGuideSurname.Text;

            db.SaveChanges();

            MessageBox.Show("REHBER GÜNCELLENDİ");
		}

		private void btnGetId_Click(object sender, EventArgs e)
		{
            int id = Convert.ToInt32(textBoxGuideId.Text);

            var value = db.Guide.Where(x => x.GuideId == id).ToList();

            dataGridView1.DataSource = value;
		}
	}
}
