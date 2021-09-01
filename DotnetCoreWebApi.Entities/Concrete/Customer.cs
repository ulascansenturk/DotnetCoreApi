using System;
using DotnetCoreWebApi.Entities.Abstract;
using DotnetCoreWebApi.Entities.ComplexTypes;

namespace DotnetCoreWebApi.Entities.Concrete
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}