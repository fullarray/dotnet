using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app5.models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace app5.Pages
{
    public class EditCustomerModel : PageModel
    {
        DatabaseContext _Context;
        public EditCustomerModel(DatabaseContext databaseContext)
        {
            _Context = databaseContext;
        }

        [BindProperty]
        public Customer Customer { get; set; }
        

        public void OnGet(int? id)
        {
            if(id != null)
            {
                var data = ( from customer in _Context.CustomerTB where customer.CustomerID == id select customer).SingleOrDefault();
                Customer = data;
            }
        }

        public ActionResult OnPost()
        {
            var customer = Customer;
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _Context.Entry(customer).Property(x => x.Name).IsModified = true;
            _Context.Entry(customer).Property(x => x.Phoneno).IsModified = true;
            _Context.Entry(customer).Property(x => x.Address).IsModified = true;
            _Context.Entry(customer).Property(x => x.City).IsModified = true;
            _Context.Entry(customer).Property(x => x.Country).IsModified = true;
            _Context.SaveChanges();
            return RedirectToPage("AllCustomer");
        }
    }
}