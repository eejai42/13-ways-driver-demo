using System.Collections.Generic;
using System.Linq;

namespace TestProject1
{
    /// <summary>
    /// A base command that all commands can descend from.
    /// </summary>
    public class BaseCommand
    {
        /// <summary>
        /// The initial string used to initialize the command
        /// </summary>
        public string InputString { get; set; }

        /// <summary>
        /// A list of errors detected during parsing.
        /// </summary>
        public List<string> Errors = new List<string>();

        /// <summary>
        /// A boolean variable indicating if any errors were detected.
        /// </summary>
        public bool IsValid { get { return !this.Errors.Any(); } }


        /// <summary>
        /// Add an error message detected during parsing.  This will invalidate the command.
        /// </summary>
        /// <param name="errorMessage">The error message to add.  </param>
        protected void AddError(string errorMessage)
        {
            this.Errors.Add(errorMessage);
        }
    }
}