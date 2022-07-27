using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RentACar.DataAcces.Absract;
using RentACar.Entities.Concrete;
using RentACar.Entities.DTOs;

namespace RentACar.DataAcces.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private  List<Car> _cars;

        public InMemoryCarDal()
        {
            Console.WriteLine("Cardal nesnesi oluşturuldu");
            _cars = new List<Car>
            {
                new Car
                {
                    Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2021, DailyPrice = 1500,
                    Description = "5.25d XDrive"
                },
                new Car
                {
                    Id = 2, BrandId = 1, ColorId = 2, ModelYear = 2022, DailyPrice = 1200, Description = "3.20d"
                }, new Car
                {
                    Id = 3 , BrandId = 2 , ColorId = 2, ModelYear = 2022 , DailyPrice = 3000,Description = "S500"
                }, new Car
                {
                    Id = 4, BrandId = 2 , ColorId = 3 , ModelYear = 2019 , DailyPrice = 950 , Description = "E250"
                } , new Car
                {
                    Id = 5 , BrandId = 3 , ColorId = 1 , ModelYear = 2021 , DailyPrice = 2200 , Description = "S90"
                }
            };
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car _UpdatedCar = null;
            _UpdatedCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _UpdatedCar.Id = car.Id;
            _UpdatedCar.BrandId = car.BrandId;
            _UpdatedCar.ColorId = car.ColorId;
            _UpdatedCar.ModelYear = car.ModelYear;
            _UpdatedCar.DailyPrice = car.DailyPrice;
            _UpdatedCar.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car _deletedCar = null;
            _deletedCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(_deletedCar);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetails> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
