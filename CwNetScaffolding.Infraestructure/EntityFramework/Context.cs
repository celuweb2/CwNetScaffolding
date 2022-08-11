using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CwNetScaffolding.Infraestructure.EntityFramework
{
    internal class Context: DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }
    }
}
