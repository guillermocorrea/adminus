using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Credentials.DataAccess.Interfaces;
using Credentials.Entities;

namespace Credentials.DataAccess.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// The context
        /// </summary>
        private AdminusContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="connectionName">Name of the connection.</param>
        public UserRepository(string connectionName)
        {
            this.context = new AdminusContext(connectionName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        public UserRepository()
        {
            this.context = new AdminusContext();
        }

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Entities.User GetUser(string username)
        {
            return this.context.Users.FirstOrDefault(u => u.Username == username);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IQueryable<Entities.User> GetAll()
        {
            return this.context.Users.AsQueryable<User>();
        }

        /// <summary>
        /// Finds the by.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IQueryable<Entities.User> FindBy(System.Linq.Expressions.Expression<Func<Entities.User, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Add(Entities.User entity)
        {
            this.context.Users.Add(entity);
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Delete(Entities.User entity)
        {
            context.Users.Find(entity.Username);
            context.Users.Remove(entity);
        }

        /// <summary>
        /// Edits the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Edit(Entities.User entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Save()
        {
            this.context.SaveChanges();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }

            GC.SuppressFinalize(this);
        }
    }
}
