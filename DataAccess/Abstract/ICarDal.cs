using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
  public  interface ICarDal
    {
        List<Car> GetAll();

        List<Car> GetById(int ID);
        
        void UpDate(Car car);

        void Add(Car car);

        void Delete(Car car);
    }
}
