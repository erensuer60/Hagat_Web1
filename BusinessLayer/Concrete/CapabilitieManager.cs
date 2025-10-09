using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CapabilitieManager : ICapabilitieService
	{
		ICapabilitieDal _capabilitieDal;

		public CapabilitieManager(ICapabilitieDal capabilitieDal)
		{
			this._capabilitieDal = capabilitieDal;
		}

		public void TAdd(Capabilitie t)
		{
			_capabilitieDal.Insert(t);
		}

		public void TDelete(Capabilitie t)
		{
			_capabilitieDal.Delete(t);
		}

		public Capabilitie TGetByID(int id)
		{
			return _capabilitieDal.GetByID(id);
		}

		public List<Capabilitie> TGetList()
		{
			return _capabilitieDal.GetList();
		}

		public void TUpdate(Capabilitie t)
		{
			_capabilitieDal.Update(t);
		}
	}
}
