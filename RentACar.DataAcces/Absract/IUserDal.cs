using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Core.DataAccess;
using RentACar.Core.Entities.Concrete;
using RentACar.Entities.Concrete;

namespace RentACar.DataAcces.Absract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
