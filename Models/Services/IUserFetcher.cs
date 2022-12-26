using Models.Interfaces;
using System.Threading.Tasks;

namespace Models.Services
{
    public interface IUserFetcher
    {
        Task<IUser> FetchUser(int id);
    }
}
