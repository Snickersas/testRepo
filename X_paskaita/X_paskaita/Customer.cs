using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace X_paskaita
{
    public class Customer
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }   
        public string LastName { get; set; }   
        public string FullName { get; set; }
        public string EmailAdress { get; set; } 
        public string HomeAdress { get; set; } 
        public string WorkAdress { get; set; }

        public static int Count { get; set; }

        public Customer() {}

        public Customer(string firstname,string lastname)
        {
            FirstName= firstname;
            LastName= lastname;
        }



        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName))
            { 
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(EmailAdress))
                {
                isValid = false;
            }
            return isValid;
        }



        public bool Save()
        {
            //CustomerRepository.Save(Customer customer)  //kita klase su save metodu
            return true;
        }

        public Customer Retrieve(int customerId)
        {
            //CustomerRepository.GetById(customerId)
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            //CustomerRepository.GetAllCustomer()
            return new List<Customer>();
        }


        public string GetFullName ()
        {
              return LastName + "," + FirstName;
            
        }

        public static string GetCountInString()
        {
            return Count.ToString();
        }



    }
}
