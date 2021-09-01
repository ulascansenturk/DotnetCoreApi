using System.Threading.Tasks;
using DotnetCoreWebApi.Entities.Dtos;
using DotnetCoreWebApi.Shared.Utilities.Results.Abstract;

namespace DotnetCoreWebApi.Services.Abstract
{
    public interface ICustomerService
    {
        Task<IDataResult<CustomerDto>> AddAsync(CustomerAddDto customerAddDto);
        
        Task<IDataResult<CustomerListDto>> GetAllAsync();

        Task<IDataResult<CustomerDto>> GetCustomerById(int id);

        Task<IDataResult<CustomerDto>> UpdateAsync(CustomerUpdateDto customerUpdateDto);

        Task<IResult> DeleteAsync(int categoryId);
    }
}