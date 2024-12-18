using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Entity_Framework
{
	public class EfProductDal : GenericRepository<Product>, IProductDal
	{
		CampContext campContext = new CampContext();
		public List<Object> GetProductsWithCategory()
		{
			var value = campContext.Products.Select(p => new
			{
				CategoryId = p.CategoryId,
				ProductDescription = p.ProductDescription,
				ProductId = p.ProductId,
				ProductName = p.ProductName,
				ProductPrice = p.ProductPrice,
				ProductStock = p.ProductStock,
				CategoryName = p.Category.CategoryName
			}).ToList();

			return value.Cast<Object>().ToList();
		}
	}
}
