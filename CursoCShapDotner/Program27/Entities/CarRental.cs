﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_Dotner.Program27.Entities
{
    class CarRental
    {

        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; private set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
