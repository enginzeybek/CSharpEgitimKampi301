using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EfTravelDbEntities Db = new EfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            #region Toplam lokasyon sayısı

            var locationCount = Db.Location.Count();

            lblCount.Text = locationCount.ToString();

            #endregion

            #region Toplam kapasite sayısı

            lblCapasity.Text = Db.Location.Sum(x => x.Capacity).ToString();

            #endregion

            #region Rehber sayısı

            lblGuide.Text = Db.Guide.Count().ToString();

            #endregion

            #region Ortalama Kapasite

            lblAvgCapacity.Text = Db.Location.Average(x =>(double?)x.Capacity).GetValueOrDefault().ToString("F2");

            #endregion

            #region Ortalama tur fiyatı

            lblAvgPrice.Text = Db.Location.Average(x => (double?)x.Price).GetValueOrDefault().ToString("F2") + " ₺";


            #endregion

            #region Eklenen son ülke

            lblAddLastCountry.Text = Db.Location.OrderByDescending(x => x.LocationId).Select
                (y => y.Country).First();

            #endregion

            #region Türkiye tur kapasitesi

            lblTurkiyeCapacity.Text = Db.Location.Where(x => x.Country == "Türkiye").
                Sum(y => y.Capacity).ToString();

            #endregion

            #region En yüksek fiyatlı tur

            lblMaxPriceCountry.Text = Db.Location.Where(x => x.Price == (Db.Location.Max(z => z.Price)))
                .Select(y => y.Country).FirstOrDefault();

            #endregion

            #region Edinburg gezisinin rehberinin ismi

            var EdinburghGuideId = Db.Location.Where(x => x.City == "Edinburgh").Select(y => y.GuideId).FirstOrDefault();

            lblEdinburghGuideName.Text = Db.Guide.Where(z => z.GuideId == EdinburghGuideId).Select
                (w => w.GuideName + " " + w.GuideSurname).FirstOrDefault().ToString();


            #endregion

            #region En yüksek kapasiteli tur

            lblMaxCapacityTour.Text = Db.Location.OrderByDescending(x => x.Capacity).Select(y => y.City).FirstOrDefault().ToString();

            #endregion

            #region En düşük fiyatlı tur

            var minPriceTour = Db.Location.Min(x => x.Price);

            lblMinPriceTour.Text = Db.Location.Where(x => x.Price == minPriceTour).Select(y => y.City).FirstOrDefault().ToString();

            #endregion

            #region 1 numaralı ID sahip rehberin tur sayısı

            lblSerelYereliLocationCount.Text = Db.Guide.Where(g => g.GuideName == "Serel" && g.GuideSurname == "Yereli").
                Join(
                Db.Location,
                Guide => Guide.GuideId,
                Location => Location.GuideId,
                (Location,Guide) => Location
                ).Count().ToString();

            #endregion
        }


    }
}
