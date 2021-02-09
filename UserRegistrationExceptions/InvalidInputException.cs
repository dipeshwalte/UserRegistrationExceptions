using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationExceptions
{
    /// <summary>
    /// Custom exception class for mood analysis
    /// </summary>
    /// <seealso cref="System.Exception" />
    class InvalidInputException : Exception
    {
        public InvalidInputException()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidInputException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="name">The name.</param>
        public InvalidInputException(string name) : base(name)
        {
            Console.WriteLine($"{name} is invalid input");
        }
    }
}
