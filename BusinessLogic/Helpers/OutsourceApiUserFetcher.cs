using Models;
using Models.Interfaces;
using Models.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Helpers
{
    public class OutsourceApiUserFetcher : IUserFetcher
    {
        private const string jsonUsersApiUrl = "https://jsonplaceholder.typicode.com/users";

        public async Task<IUser> FetchUser(int id)
        {
            var response = "";
            User user = null;
            try
            {
                using (var client = new HttpClient())
                {
                    response = await client.GetStringAsync($"{jsonUsersApiUrl}/{id}");
                }

                if (response != null)
                {
                    user = JsonConvert.DeserializeObject<User>(response);
                }
            }
            catch (Exception ex)
            {
                
            }

            return user;
        }
    }
}
