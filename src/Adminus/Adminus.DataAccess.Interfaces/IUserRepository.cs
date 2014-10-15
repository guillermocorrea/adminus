using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adminus.DataAccess.Interfaces.Base;
using Adminus.Entities;

namespace Adminus.DataAccess.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        User GetUser(string username);
    }
}
