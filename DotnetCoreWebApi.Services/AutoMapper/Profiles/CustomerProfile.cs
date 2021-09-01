using AutoMapper;
using DotnetCoreWebApi.Entities.Concrete;
using DotnetCoreWebApi.Entities.Dtos;

namespace DotnetCoreWebApi.Services.AutoMapper.Profiles
{
    public class CustomerProfile:Profile
    {
        public CustomerProfile()
        {
            
            CreateMap<CustomerAddDto, Customer>();
            
            CreateMap<CustomerUpdateDto, Customer>();
            CreateMap<Customer, CustomerDto>();
        }
    }
}