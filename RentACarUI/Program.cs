using RentACar.Business.Concrete;
using RentACar.DataAcces.Concrete.EntityFramework;
using RentACar.DataAcces.Concrete.InMemory;
using RentACar.Entities.Concrete;

var carManager = new CarManager(new EfCarDal());
carManager.GetAllDetails();



