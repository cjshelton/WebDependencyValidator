using System;

namespace WebDependencyValidator.Exceptions
{
    /// <summary>
    /// Exception to be thrown when there exists one or more dependencies of the application which haven't been registered in IoC.
    /// </summary>
    public class AppDependenciesNotMetException : Exception
    {
        /// <summary>
        /// Constructs the exception.
        /// </summary>
        public AppDependenciesNotMetException()
        {
            // Nothing to do here.
        }

        /// <summary>
        /// Constructs the exception with a message.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public AppDependenciesNotMetException(string message)
        : base(message)
        {
            // Nothing to do here. The message is passed down to the base exception.
        }

        /// <summary>
        /// Constructs the exception with a message and an inner exception.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">The inner exception.</param>
        public AppDependenciesNotMetException(string message, Exception innerException)
        : base(message, innerException)
        {
            // Nothing to do here. The message and inner exception are passed down to the base exception.
        }
    }
}
