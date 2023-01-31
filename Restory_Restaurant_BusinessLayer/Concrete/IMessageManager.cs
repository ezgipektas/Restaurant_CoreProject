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
    public class IMessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;

        public void TAdd(Message t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messageDal.Delete(t);
        }

        public Message TGetByID(int id)
        {
            return _messageDal.GetByID(id);
        }

        public List<Message> TGetList()
        {
            return _messageDal.GetList();
        }

        public void TUpdate(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
