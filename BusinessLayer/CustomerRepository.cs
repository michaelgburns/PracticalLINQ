using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerRepository
    {
        public Customer Find(List<Customer> customerList, int customerId)
        {
            Customer foundCustomer = null;

            //var customers = from c in customerList
            //                where c.CustomerId == customerId
            //                select c;
            //foundCustomer = customers.First();

            foundCustomer = customerList.FirstOrDefault(c => c.CustomerId == customerId);

            return foundCustomer;
        }
        
        public IEnumerable<Customer> SortByName(List<Customer> customerList)
        {
            return customerList.OrderBy(c => c.FirstName).ThenBy(c => c.LastName);
        }

        public IEnumerable<Customer> SortByNameReverse(List<Customer> customerList)
        {
            //return customerList.OrderByDescending(c => c.LastName).ThenByDescending(c => c.FirstName);
            return SortByName(customerList).Reverse();
        }



        public List<Customer> Retrieve()
        {
            List<Customer> custList = new List<Customer>
            {
                new Customer() {CustomerId = 1, FirstName = "Frodo", LastName = "Baggins", EmailAddress = "fb@hob.me", CustomerTypeId = 1},
                new Customer() {CustomerId = 2, FirstName = "Bilbo", LastName = "Baggins", EmailAddress = "bb@hob.me", CustomerTypeId = null},
                new Customer() {CustomerId = 3, FirstName = "Samewise", LastName = "Gamee", EmailAddress = "sg@hob.me", CustomerTypeId = 1},
                new Customer() {CustomerId = 4, FirstName = "Rosie", LastName = "Cotton", EmailAddress = "rc@hob.me", CustomerTypeId = 2}
            };

            return custList;
        }
    }
}
