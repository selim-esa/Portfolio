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
    public class HomeManager : IHomeService
    {
        readonly IHomeDal _homeDal;
        public HomeManager(IHomeDal homeDal)
        {
            _homeDal = homeDal;
        }

        public List<Home> GetAll()
        {
            return _homeDal.GetAll();
        }

        public Home GetById(int id)
        {
            return _homeDal.GetById(id);
        }

        public void TAdd(Home t)
        {
            _homeDal.Insert(t);
        }

        public void TRemove(Home t)
        {
            _homeDal.Delete(t);
        }

        public void TUpdate(Home t)
        {
          _homeDal.Update(t);
        }
    }
}
