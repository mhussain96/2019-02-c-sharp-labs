using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace lab_123_new_basic_entity.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
        }


    }

    //public class CustomersModel : PageModel
    //{

    //    public String ShowMe { get; set; }

    //    public IEnumerable<Customer> Customers { get; set; }



    //    public void OnGet()
    //    {
    //        ShowMe = "This is a string";
    //        using (var db = new Northwind())
    //        {
    //            Customers = db.Customers.OrderBy(c => c.CustomerID).ToList<Customer>().ToArray();
    //        }
    //    }
    //}

}
