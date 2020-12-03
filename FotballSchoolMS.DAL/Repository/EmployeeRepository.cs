﻿using FootballSchoolMS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Repository
{
   public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
