using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using app5.models;

namespace app5.Pages
{
    public class CustomerModel : PageModel
    {
        DatabaseContext _Context;
        public CustomerModel(DatabaseContext databaseContext)
        {
            _Context = databaseContext;
        }

        [BindProperty]
        public Customer Customer { get; set; }
        public void OnGet()
        {
            //WelcomeMessage = "Welcome to Razor Pages by herrj";
        }

        public ActionResult OnPost()
        {
            var customer = Customer;

            if(!ModelState.IsValid)
            {
                return Page(); // Returns same page
            }

            customer.CustomerID = 0;
            var result = _Context.Add(customer);
            _Context.SaveChanges();

            return RedirectToPage("AllCustomer");
        }
    }
}