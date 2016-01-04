using System.Threading.Tasks;
using OdooRpc.CoreCLR.Client.Models;
using OdooRpc.CoreCLR.Client.Models.Parameters;

namespace OdooRpc.CoreCLR.Client.Interfaces
{
    public interface IOdooRpcClient
    {
        OdooSessionInfo SessionInfo { get; }

        Task<OdooVersionInfo> GetOdooVersion();
        Task Authenticate();
        void SetUserId(long userId);

        Task<T> Get<T>(string model, long id);
        Task<T> Get<T>(OdooGetParameters getParameters);
        Task<T> Get<T>(OdooGetParameters getParameters, OdooFieldParameters fieldParameters);

        Task<T> Get<T>(OdooSearchParameters parameters);
        Task<T> Get<T>(OdooSearchParameters parameters, OdooFieldParameters fieldParameters);
        Task<T> Get<T>(OdooSearchParameters searchParameters, OdooPaginationParameters pagParameters);
        Task<T> Get<T>(OdooSearchParameters searchParameters, OdooFieldParameters fieldParameters, OdooPaginationParameters pagParameters);

        Task<T> Search<T>(OdooSearchParameters parameters);
        Task<T> Search<T>(OdooSearchParameters searchParameters, OdooPaginationParameters pagParameters);
        Task<long> SearchCount(OdooSearchParameters parameters);
    }
}