using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerTypeRepository
    {
        public List<CustomerType> Retrieve()
        {
            List<CustomerType> customerTypeList = new List<CustomerType>
            {
                new CustomerType() {CustomerTypeId = 1, TypeName = "Corporate", DisplayOrder = 2},
                new CustomerType() {CustomerTypeId = 2, TypeName = "Individual", DisplayOrder = 1},
                new CustomerType() {CustomerTypeId = 3, TypeName = "Educator", DisplayOrder = 4},
                new CustomerType() {CustomerTypeId = 1, TypeName = "Government", DisplayOrder = 3},
            };
            return customerTypeList;
        }
    }

}
