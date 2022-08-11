using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetScaffolding.Domain.User.Interfaces
{
    using CwNetScaffolding.Domain.User.Model;
    public interface IUserRepository
    {
        List<User> GetAllUsers(); 
    }
}
