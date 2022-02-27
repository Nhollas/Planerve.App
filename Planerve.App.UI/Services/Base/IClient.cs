using System.Net.Http;

namespace Planerve.App.UI.Services.Base
{
    public partial interface IClient
    {
        public HttpClient HttpClient { get; }
    }
}
