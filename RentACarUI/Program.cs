using RentACar.Business.Concrete;
using RentACar.Core.Utilities.Results;
using RentACar.DataAcces.Concrete.EntityFramework;
using RentACar.Entities.Concrete;

var carManager = new CarManager(new EfCarDal());
var carsResult = carManager.GetAll();
foreach (var s in carsResult.Data)
{
    Console.WriteLine(s.Description);
}

var brandManager = new BrandManager(new EfBrandCarDal());
var brandResult =brandManager.GetAll();
foreach (var brand in brandResult.Data)
{
    Console.WriteLine(brand.BrandName);
}

var colorManager = new ColorManager(new EfColorDal());
var colorResult =colorManager.GetAll();
foreach (var color in colorResult.Data)
{
    Console.WriteLine(color.ColorName);
}

var UserManager = new UserManager(new EfUserDal());
var UserManagerResult = UserManager.GetAll();
foreach (var user in UserManagerResult.Data)
{
    Console.WriteLine(user.FirstName);
}

var rentalManager = new RentalManager(new EfRentalDal());
var rentalManagerResult = rentalManager.GetAll();
foreach (var rental in rentalManagerResult.Data)
{
    Console.WriteLine(rental.RentDate);
}

var customerManager = new CustomerManager(new EfCustomerDal());
var customerManagerResult = customerManager.GetAll();
foreach (var customer in customerManagerResult.Data)
{
    Console.WriteLine(customer.CompanyName);
}





