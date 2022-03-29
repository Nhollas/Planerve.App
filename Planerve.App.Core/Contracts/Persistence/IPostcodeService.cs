using System.Threading.Tasks;

namespace Planerve.App.Core.Contracts.Persistence
{
    public interface IPostcodeService
    {
        Task<string> ValidatePostcode(string postcode);
    }
}
