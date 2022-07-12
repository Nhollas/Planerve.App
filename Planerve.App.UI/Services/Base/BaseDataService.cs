namespace Planerve.App.UI.Services.Base
{
    public class BaseDataService
    {
        protected IClient _client;
        protected IApplicationClient _applicationClient;
        protected IFormClient _formClient;
        protected IAuthenticationClient _authenticationClient;

        public BaseDataService(IClient client)
        {
            _client = client;
        }

        public BaseDataService(IApplicationClient client)
        {
            _applicationClient = client;
        }

        public BaseDataService(IFormClient client)
        {
            _formClient = client;
        }

        public BaseDataService(IAuthenticationClient client)
        {
            _authenticationClient = client;
        }

        protected ApiResponse<Guid> ConvertApiExceptions<Guid>(ApiException ex)
        {
            if (ex.StatusCode == 400)
            {
                return new ApiResponse<Guid>() { Message = "Validation errors have occured.", ValidationErrors = ex.Response, Success = false };
            }
            else if (ex.StatusCode == 404)
            {
                return new ApiResponse<Guid>() { Message = "The requested item could not be found.", Success = false };
            }
            else
            {
                return new ApiResponse<Guid>() { Message = "Something went wrong, please try again.", Success = false };
            }
        }
    }
}
