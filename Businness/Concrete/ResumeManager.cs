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
    public class ResumeManager : IResumeService
    {
        IResumeDal _resumeDal;

        public ResumeManager(IResumeDal resumeDal)
        {
            _resumeDal = resumeDal;
        }

        public List<Resume> GetAll()
        {
            return _resumeDal.GetAll();
        }

        public Resume GetById(int id)
        {
            return _resumeDal.GetById(id);
        }

        public void TAdd(Resume t)
        {
            _resumeDal.Insert(t);
        }

        public void TRemove(Resume t)
        {
            _resumeDal.Delete(t);
        }

        public void TUpdate(Resume t)
        {
            _resumeDal.Update(t);
        }
    }
}
