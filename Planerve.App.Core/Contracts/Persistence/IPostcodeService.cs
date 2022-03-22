using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Threading.Tasks;

namespace Planerve.App.Core.Contracts.Persistence
{
    public interface IPostcodeService
    {
        Task<AddressDto> ValidatePostcode (string postcode);
    }
}
