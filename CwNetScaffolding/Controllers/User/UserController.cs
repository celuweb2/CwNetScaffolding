using CwNetScaffolding.Application.User;
using CwNetScaffolding.Domain.User.Interfaces;
using CwNetScaffolding.Infraestructure.MockData.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CwNetScaffolding.WebApi.Controllers.User
{
    using CwNetScaffolding.Domain.User.Model;

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly IGetAllUsersUseCases getAllUsersUseCases;
        private readonly IUserRepository userRepository;

        public UserController()
        {
            userRepository = new MockUserRepository();
            getAllUsersUseCases = new GetAllUsersUseCases(userRepository);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<User> users = await getAllUsersUseCases.Execute();
            return new ObjectResult(users);
        }
    }
}
