using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetScaffolding.Application.User
{
    using CwNetScaffolding.Domain.User.Model;
    public interface IGetAllUsersUseCases
    {
        Task<List<User>> Execute();
    }
}
