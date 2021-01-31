using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1 , BrandId=1,ColorId=1,ModelYear=2010,DailiyPrice=190,Description="Sports"},
                new Car { CarId=2, BrandId=2,ColorId=5,ModelYear=2012,DailiyPrice =140,Description="Hybrid"},
                new Car{CarId=3 , BrandId=3,ColorId=1,ModelYear=2000,DailiyPrice=100,Description="Sedan"},
                new Car{CarId=10 , BrandId=4,ColorId=1,ModelYear=2019,DailiyPrice=180,Description="Hybrid"},
                new Car{CarId=5, BrandId=2,ColorId=2,ModelYear=2009,DailiyPrice=200,Description="SUV"},
                new Car{CarId=9 , BrandId=1,ColorId=3,ModelYear=2012,DailiyPrice=250,Description="Sports"},
            };
        }







        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.CarId = car.CarId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailiyPrice = car.DailiyPrice;
            CarToUpdate.Description = car.Description;

        }
    }
}
