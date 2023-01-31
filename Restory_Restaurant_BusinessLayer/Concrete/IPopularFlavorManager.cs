using Restory_Restaurant_BusinessLayer.Abstract;
using Restory_Restaurant_DataAccessLayer.Abstract;
using Restory_Restaurant_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restory_Restaurant_BusinessLayer.Concrete
{
    public class IPopularFlavorManager : IPopularFlavorService
    {
        private readonly IPopularFlavorDal _popularFlavorDal;

        public IPopularFlavorManager(IPopularFlavorDal popularFlavorDal)
        {
            _popularFlavorDal = popularFlavorDal;
        }

        public void TAdd(PopularFlavor t)
        {
            _popularFlavorDal.Insert(t);
        }

        public void TDelete(PopularFlavor t)
        {
            _popularFlavorDal.Delete(t);
        }

        public PopularFlavor TGetByID(int id)
        {
            return _popularFlavorDal.GetByID(id);
        }

        public List<PopularFlavor> TGetList()
        {
            return _popularFlavorDal.GetList();
        }

        public void TUpdate(PopularFlavor t)
        {
            _popularFlavorDal.Update(t);
        }
    }
}
