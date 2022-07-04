using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Core.DataAccess;
using RentACar.Entities.Concrete;

namespace RentACar.DataAcces.Absract
{
    public interface IColorDal : IEntityRepository<Color>
    {
    }
}
