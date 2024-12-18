using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concreate
{
	public class ProductManager : IProductService
	{
		private readonly IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public void TDelete(Product entity)
		{
			_productDal.Delete(entity);
		}

		public Product TGetById(int id)
		{
			return _productDal.GetById(id);
		}

		public List<Product> TGetListAll()
		{
			return _productDal.GetListAll();
		}

		public List<Object> TGetProductsWithCategory()
		{
			return _productDal.GetProductsWithCategory();
		}

		public void TInsert(Product entity)
		{
			_productDal.Insert(entity);
		}

		public void TUpdate(Product entity)
		{
			_productDal.Update(entity);
		}
	}
}
