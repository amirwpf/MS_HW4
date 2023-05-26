using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Exceptions
{
    public class FileNotExcistException : Exception
    {
        public FileNotExcistException(string message):base(message)
        {

        }
    }
}
