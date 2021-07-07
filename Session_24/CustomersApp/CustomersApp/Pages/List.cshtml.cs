using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Coding.Model;

namespace CustomersApp.Pages
{
    public class ListModel : PageModel
    {
        public List<ListCustomer> MyList { get; set; }
        public void OnGet()
        {
        }
    }
}
