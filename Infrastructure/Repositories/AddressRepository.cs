﻿using Core.Identities;
using Core.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class AddressRepository: Repository<Address>, IAddressRepository
    {
        public AddressRepository(EmployeeContext employeeContext) : base(employeeContext)
        {

        }

    }
}