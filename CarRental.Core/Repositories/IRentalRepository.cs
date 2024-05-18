﻿using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Repositories
{
    public interface IRentalRepository : IGenericRepository<Rental>
    {
        int GetTotalDays(DateTime startDate, DateTime endDate);
        Task<IList<Rental>> GetAllPendingRentals();
        Task<IList<Rental>> GetAllWaitingRentals();
        Task<IList<Rental>> GetAllConfirmedRentals();
        Task<IList<Rental>> GetAllRejectedRentals();

        Task<IList<Rental>> GetAllRentalsForClient(string clientId);

        Task<IList<Rental>> GetAllReqForCarById(int carId);

        Task<IList<Rental>> GetAllReqPendAndRejForCarById(int carId);

    }
}
