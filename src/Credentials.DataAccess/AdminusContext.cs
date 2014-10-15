using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Credentials.Entities;

namespace Credentials.DataAccess
{
    /// <summary>
    /// 
    /// </summary>
    public class AdminusContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminusContext"/> class.
        /// </summary>
        /// <param name="connectionName">Name of the connection.</param>
        public AdminusContext(string connectionName) : base(connectionName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminusContext"/> class.
        /// </summary>
        public AdminusContext() : this("Adminus") { }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        public DbSet<User> Users { get; set; }
    }
}
