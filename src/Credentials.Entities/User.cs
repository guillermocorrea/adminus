using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credentials.Entities
{
    /// <summary>
    /// User entity
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        [Required]
        [Key]
        public string Username { get; set; }
        
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Required]
        [DataType(DataType.Password)]
        [MinLength(3)]
        public string Password { get; set; }
    }
}
