using DotnetCoreWebApi.Entities.ComplexTypes;

namespace DotnetCoreWebApi.Entities.Dtos
{
    public class CustomerUpdateDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
    }
}