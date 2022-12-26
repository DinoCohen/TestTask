using BusinessLogic.Helpers;
using Models;
using Models.Interfaces;
using Models.Services;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class UserService : IUserService
    {
        private readonly ICacheService _cacheService;
        private readonly IUserFetcherContext _userFetcher;

        public UserService(ICacheService cacheService, IUserFetcherContext userFetcher)
        {
            _cacheService = cacheService;
            _userFetcher = userFetcher;
        }

        public async Task<IUser> Get(int id)
        {
            IUser result = _cacheService.GetItem<IUser>(id.ToString());

            if (result == null)
            {
                _userFetcher.SetFetcher(new OutsourceApiUserFetcher());  
                result = await _userFetcher.FetchUser(id);

                if (result == null)
                {
                    _userFetcher.SetFetcher(new CsvFileUserFetcher());
                    result = await _userFetcher.FetchUser(id);
                }
                if (result != null)
                    _cacheService.SetItem<IUser>(id.ToString(), result);
            }
            return result;
        }
    }
}
