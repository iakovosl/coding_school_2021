using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Coding.Model;
using CustomersApp.Services;

namespace CustomersApp.Pages
{
    public class ListModel : PageModel
    {
        public List<ListCustomer> MyList { get; set; }

        private ICustomerStorage _customerStorage { get; set; }

        public ListModel(ICustomerStorage customerStorage) {
            _customerStorage = customerStorage;
        }
        public void OnGet()
        {
            MyList = _customerStorage.GetAllCustomers();
        }
    }
}
