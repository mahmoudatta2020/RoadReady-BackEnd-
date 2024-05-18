﻿using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Repositories
{
    public interface ICarRepository : IGenericRepository<Car>
    {
        Task<IList<Car>> GetAllCarsForOwner(string ownerId);
        Task<IList<Car>> GetAllCarsExceptOnwerCar(string ownerId);
        Task<Car> GetCarById(int carId);

    }
}
