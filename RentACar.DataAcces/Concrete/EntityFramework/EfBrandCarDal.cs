using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RentACar.Core.DataAccess.EntityFramework;
using RentACar.DataAcces.Absract;
using RentACar.Entities.Concrete;

namespace RentACar.DataAcces.Concrete.EntityFramework
{
    public class EfBrandCarDal : EfEntityRepositoryBase<Brand, RentACarContext>, IBrandDal
    {

    }
}
