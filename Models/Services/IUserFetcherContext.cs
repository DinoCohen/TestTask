using Models.Interfaces;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface IUserFetcherContext
    {
        void SetFetcher(IUserFetcher userFetcher);
        Task<IUser> FetchUser(int id);
    }
}
