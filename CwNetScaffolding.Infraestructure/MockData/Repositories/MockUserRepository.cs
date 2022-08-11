using CwNetScaffolding.Domain.User.Interfaces;
using CwNetScaffolding.Domain.User.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetScaffolding.Infraestructure.MockData.Repositories
{
    public class MockUserRepository : IUserRepository
    {
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
  
            users.Add(new User { name = "Alexander", username = "alex", password = "1234567" });
            users.Add(new User { name = "Camila", username = "cami", password = "1234567" });
            users.Add(new User { name = "Sofia ", username = "sofi", password = "1234567" });

            return users;
        }
    }
}
