using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Exceptions
{
    public class InvalidBirthDateException :Exception
    {
        public InvalidBirthDateException(string message) :base(message)
        {

        }
    }
}
