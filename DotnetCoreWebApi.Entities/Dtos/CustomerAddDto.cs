using DotnetCoreWebApi.Entities.ComplexTypes;

namespace DotnetCoreWebApi.Entities.Dtos
{
    public class CustomerAddDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public int? Age { get; set; }
    }
    
}