using Business.Abstract;
using Data.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SideBarManager : ISideBarService
    {
        ISideBarDal _sideBarDal;

        public SideBarManager(ISideBarDal sideBarDal)
        {
            _sideBarDal = sideBarDal;
        }

        public List<SideBar> GetAll()
        {
            return _sideBarDal.GetAll();
        }

        public SideBar GetById(int id)
        {
            return _sideBarDal.GetById(id);
        }

        public void TAdd(SideBar t)
        {
            _sideBarDal.Insert(t);
        }

        public void TRemove(SideBar t)
        {
          _sideBarDal.Delete(t);
        }

        public void TUpdate(SideBar t)
        {
            _sideBarDal.Update(t);
        }
    }
}
