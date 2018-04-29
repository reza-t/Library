﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;


namespace Library.Controllers
{
    interface ICustomerController
    {
        bool AddNewCustomer(Customer customer);
        bool RemoveCustomer(int id);
    }
}
