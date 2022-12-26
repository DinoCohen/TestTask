using Models;
using Models.Interfaces;
using Models.Services;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Helpers
{
    public class CsvFileUserFetcher : IUserFetcher
    {
        string csv_file_path = @"C:\Users\DC250456\OneDrive - NCR Corporation\Desktop\tutorial\users.csv";
        public async Task<IUser> FetchUser(int id)
        {
            var user = File.ReadAllLines(csv_file_path, Encoding.Default)
                              .Skip(1)
                              .Select(line => line.Split(';'))
                              .Select(tokens => new User { ID = int.Parse(tokens[0]), Email = tokens[1], Name = tokens[2] })
                              .FirstOrDefault(user => user.ID == id);

            return user;
        }
    }
}
