using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Core.Entities.Concrete;
using RentACar.Core.Utilities.Results;
using RentACar.Core.Utilities.Security.JWT;
using RentACar.Entities.DTOs;

namespace RentACar.Business.Absract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
