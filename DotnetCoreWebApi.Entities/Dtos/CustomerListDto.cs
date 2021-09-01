using System.Collections.Generic;
using DotnetCoreWebApi.Entities.Concrete;

namespace DotnetCoreWebApi.Entities.Dtos
{
    public class CustomerListDto
    {
        public IList<Customer> Customers { get; set; }
    }
}