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
	public class CustomerManager : ICustomerService
	{
		private readonly ICustomerDal _customerDal;

		public CustomerManager(ICustomerDal customerDal)
		{
			_customerDal = customerDal;
		}

		public void TDelete(Customer entity)
		{
			_customerDal.Delete(entity);
		}

		public Customer TGetById(int id)
		{
			return _customerDal.GetById(id);
		}

		public List<Customer> TGetListAll()
		{
			return _customerDal.GetListAll();
		}

		public void TInsert(Customer entity)
		{
			_customerDal.Insert(entity);
		}

		public void TUpdate(Customer entity)
		{
			_customerDal.Update(entity);
		}
	}
}
