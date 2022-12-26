using Models.Interfaces;
using System.Threading.Tasks;

namespace Models
{
    public interface IUserService
    {
        Task<IUser> Get(int id); 
    }
}
