using Restory_Restaurant_DataAccessLayer.Abstract;
using Restory_Restaurant_DataAccessLayer.Concrete;
using Restory_Restaurant_DataAccessLayer.Repositories;
using Restory_Restaurant_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restory_Restaurant_DataAccessLayer.EntityFramework
{
    public class EfPopularFlavorDal : GenericRepository<PopularFlavor>, IPopularFlavorDal
    {
        public EfPopularFlavorDal(Context context) : base(context)
        {

        }

    }
}
