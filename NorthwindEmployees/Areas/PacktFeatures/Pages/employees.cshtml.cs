﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;
using System.Collections.Generic; 
namespace PacktFeatures.Pages
{
    public class EmployeesPageModel : PageModel
    {  
         private Northwind db;
         public IEnumerable<Employee> Employees { get; set; }
         public EmployeesPageModel(Northwind injectedContext)
        {
            db = injectedContext;
        }
        public void OnGet()
        {
        Employees = db.Employees.ToArray();
        }
    }
}