using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_paskaita
{


    public class CustomerRepository
    {
        private List<Customer> Customers { get; set; } = new List<Customer>();
   

        public bool SaveCustomer(Customer customer)
        {
            Customers.Add(customer);
            return true;
        }

        public Customer GetById(int id)
        {
            var customer = Customers.FirstOrDefault(x => x.Id == id); //eina per lista ir islisntaina pirma atitinkati
            return customer;
        }

        public List<Customer> Get()
        {
            return Customers;
        }

        public int GetCount()
        { 
        return Customer.Count;
        }


    }

}
