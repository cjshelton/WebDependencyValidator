namespace ExampleWebAPI.Models
{
    /// <summary>
    /// An example model of a user.
    /// </summary>
    public class User
    {
        /// <summary>
        /// The user's ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The user's username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The user's forename.
        /// </summary>
        public string Forename { get; set; }

        /// <summary>
        /// The user's surname.
        /// </summary>
        public string Surname { get; set; }
    }
}
