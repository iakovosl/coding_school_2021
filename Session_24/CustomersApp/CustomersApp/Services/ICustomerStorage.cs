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

    public class MemoryCustomerStorage : ICustomerStorage {
        private List<ListCustomer> innerList { get; set; }

        public MemoryCustomerStorage() {
            innerList = new List<ListCustomer>();
        }

        public void AddCustomer(ListCustomer customer) {
            if (customer.Id == 0) {
                customer.Id = innerList.Count + 1;
                innerList.Add(customer);
                return;
            }

            var selectedCustomer = GetById(customer.Id);
            selectedCustomer.Name = customer.Name;
            selectedCustomer.Surname = customer.Surname;
            selectedCustomer.AFM = customer.AFM;
        }

        public List<ListCustomer> GetAllCustomers() {
            return innerList;
        }

        public ListCustomer GetById(int id) {
            return innerList.FirstOrDefault(customer => customer.Id == id);
        }

        public void RemoveCustomer(int id) {
            var selectedCustomer = GetById(id);
            if (selectedCustomer == null)
                throw new Exception(string.Format("Customer with id '{0}' was not found.", id));

            innerList.Remove(selectedCustomer);
        }


    }


}
