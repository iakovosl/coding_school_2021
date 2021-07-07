using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coding.Model;
using CustomersApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomersApp.Pages
{
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public ListCustomer SelectedListCustomer { get; set; }

        private ICustomerStorage _storage { get; set; }

        public DetailsModel(ICustomerStorage storage) {
            _storage = storage;
        }
        public void OnGet(int id)
        {

            if (id == 0) {
                SelectedListCustomer = new ListCustomer();
                return;
            }

            SelectedListCustomer = _storage.GetById(id);
        }
        public IActionResult OnPost() {
            _storage.AddCustomer(SelectedListCustomer);

            return RedirectToPage("List");
        }

        public IActionResult OnPostCancel() {
            return RedirectToPage("List");
        }

        public IActionResult OnPostDelete() {
            _storage.RemoveCustomer(SelectedListCustomer.Id);
            return RedirectToPage("List");
        }
    }
}
