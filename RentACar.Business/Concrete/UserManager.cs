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

        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserListed);
        }
    }
}
