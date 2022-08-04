using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Business.Absract;
using RentACar.Business.Constants;
using RentACar.Business.ValidationRules.FluentValidation;
using RentACar.Core.Aspects.Autofac.Validation;
using RentACar.Core.Entities.Concrete;
using RentACar.Core.Utilities.Results;
using RentACar.DataAcces.Absract;
using RentACar.Entities.Concrete;

namespace RentACar.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        
        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        [ValidationAspect(typeof(UserValidator))]
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}
