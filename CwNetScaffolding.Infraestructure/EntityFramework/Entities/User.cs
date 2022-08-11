using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CwNetScaffolding.Infraestructure.EntityFramework.Entities
{
    internal class User
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
