using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResearchManagerNotebook
{
    class FullListException : ApplicationException
    {
        public FullListException()
        { }

        public FullListException(string message)
            : base(message)
        { }

        public FullListException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
