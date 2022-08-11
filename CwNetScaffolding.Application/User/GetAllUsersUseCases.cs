using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetScaffolding.Application.User
{
    using CwNetScaffolding.Domain.User.Interfaces;
    using CwNetScaffolding.Domain.User.Model;

    public  class GetAllUsersUseCases: IGetAllUsersUseCases
    {
        private readonly IUserRepository _userRepository;

        public GetAllUsersUseCases(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public async Task<List<User>> Execute()
        {
            return this._userRepository.GetAllUsers();
        }
    }
}
