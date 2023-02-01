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
    public class IntroductionManager : IIntroductionService
    {
        private readonly IIntroductionDal _introductionDal;

        public IntroductionManager(IIntroductionDal introductionDal)
        {
            _introductionDal = introductionDal;
        }

        public void TAdd(Introduction t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Introduction t)
        {
            throw new NotImplementedException();
        }

        public Introduction TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Introduction> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Introduction t)
        {
            throw new NotImplementedException();
        }
    }
}
