using Models.Interfaces;
using Models.Services;
using System.Threading.Tasks;

namespace BusinessLogic.Helpers
{
    public class UserFetcher : IUserFetcherContext
    {
        private IUserFetcher _userFetcher;

        public UserFetcher()
        { }
        public UserFetcher(IUserFetcher userFetcher)
        {
            _userFetcher = userFetcher;
        }

        public void SetFetcher(IUserFetcher userFetcher) => _userFetcher = userFetcher;

        public async Task<IUser> FetchUser(int id) => await _userFetcher.FetchUser(id);
    }
}
