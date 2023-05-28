using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Exceptions
{
    public class InvalidPhone : Exception
    {
        public InvalidPhone(string message):base(message)
        {

        }
    }
}
