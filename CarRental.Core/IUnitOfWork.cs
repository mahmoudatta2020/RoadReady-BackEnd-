﻿using CarRental.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core
{
    public interface IUnitOfWork
    {
        public ICarRepository CarRepository { get; set; }
        public IRentalRepository RentalRepository { get; set; }
        public IReviewRepository ReviewRepository { get; set; }
    }
}
