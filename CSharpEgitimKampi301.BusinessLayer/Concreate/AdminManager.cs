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
	public class AdminManager : IAdminService
	{
		private readonly IAdminDal _adminDal;

		public AdminManager(IAdminDal adminDal)
		{
			_adminDal = adminDal;
		}

		public void TDelete(Admin entity)
		{
			_adminDal.Delete(entity);
		}

		public Admin TGetById(int id)
		{
			return _adminDal.GetById(id);
		}

		public List<Admin> TGetListAll()
		{
			return _adminDal.GetListAll();
		}

		public void TInsert(Admin entity)
		{
			_adminDal.Insert(entity);
		}

		public void TUpdate(Admin entity)
		{
			_adminDal.Update(entity);
		}
	}
}
