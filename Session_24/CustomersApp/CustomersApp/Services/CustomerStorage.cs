using Coding.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersApp.Services {
    public interface ICustomerStorage {
        public void AddCustomer(ListCustomer customer);
        public void RemoveCustomer(int id);
        public List<ListCustomer> GetAllCustomers();
        public ListCustomer GetById(int id);
    }

    public class CustomerStorage { }
        
        
}
