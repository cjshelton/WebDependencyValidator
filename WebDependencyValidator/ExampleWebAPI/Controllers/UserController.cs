using System.Collections.Generic;
using ExampleWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebAPI.Controllers
{
    /// <summary>
    /// User controller with basic REST functionality.
    /// This is an example controller used to showcase the start of the dependency chain,
    /// and how the application will not start if all dependencies of this controller are not registered in IoC.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Constructs the <see cref="UserController"/>.
        /// </summary>
        public UserController()
        {
        }

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns>All users.</returns>
        /// <example>
        /// GET api/user
        /// </example>
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return new User[]
            { 
                new User
                {
                    Id = 5,
                    Username = "barry_smith",
                    Forename = "Barry",
                    Surname = "Smith"
                },
                new User
                {
                    Id = 10,
                    Username = "tanya_smith",
                    Forename = "Tanya",
                    Surname = "Smith"
                }
            };
        }

        /// <summary>
        /// Gets a single user based on ID.
        /// </summary>
        /// <returns>A user.</returns>
        /// <param name="id">The ID of the user.</param>
        /// <example>
        /// GET api/user/5
        /// </example>
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return new User
            {
                Id = id
            };
        }

        /// <summary>
        /// Creates a new user.
        /// </summary>
        /// <param name="user">The user to be created.</param>
        /// <example>
        /// POST api/user
        /// </example>
        [HttpPost]
        public void Post([FromBody] User user)
        {
        }

        /// <summary>
        /// Updates a user.
        /// </summary>
        /// <param name="id">The ID of the user to be updated.</param>
        /// <param name="user">The new user details.</param>
        /// <example>
        /// PUT api/user/5
        /// </example>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
        }

        // DELETE api/user/5
        /// <summary>
        /// Deletes a user.
        /// </summary>
        /// <param name="id">The ID of the user to delete.</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
