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


        public IEnumerable<string> GetNames(List<Customer> customerList)
        {
            var names = from c in customerList
                        select c.FirstName + c.LastName;

            var names2 = customerList.Select(c => c.FirstName + c.LastName);

            return names2;
        }

        public dynamic GetNamesAndEmail(List<Customer> customerList)
        {
            
            // this is just an example. In production code you would not return a dynamic in a method.
            // you would use the code below in a class where is was needed and bind directly if needed.
            var query = customerList.Select(c => new
            {
                Name = c.LastName +  ", " + c.FirstName,
                c.EmailAddress
            });
            return query;
        }

        public dynamic GetNamesAndType(List<Customer> customer, List<CustomerType> customerTypeList)
        {
            //var query = from c in customer
            //            from t in customerTypeList
            //            where c.CustomerTypeId == t.CustomerTypeId
            //            select new { Name = c.LastName + "," + c.FirstName, CustomerTypeName =  t.TypeName };

            var query = customer.Join(customerTypeList,
                                    c => c.CustomerTypeId,
                                    ct => ct.CustomerTypeId,
                                    (c, ct) => new
                                    {
                                        Name = c.LastName + ", " + c.FirstName,
                                        CustomerTypeName = ct.TypeName
                                    });

            foreach (var item in query)
            {
                Console.WriteLine(item.Name + ": " + item.CustomerTypeName);
            }

            return query;
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
