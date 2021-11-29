using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIGTechTest.Exceptions
{
    public class NotDayOfWeekException:Exception
    {
        public NotDayOfWeekException()
        {
        }

        public NotDayOfWeekException(string message)
            : base(message)
        {
        }

        public NotDayOfWeekException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
