using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Core.DataAccess;
using RentACar.Entities.Concrete;
using RentACar.Entities.DTOs;

namespace RentACar.DataAcces.Absract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        List<CustomerDetailDto> GetDetailCustomer();
    }
}
