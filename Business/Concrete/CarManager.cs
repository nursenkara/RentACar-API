﻿using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        public IResult Add(Car car)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> GetByCarId(int carId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
