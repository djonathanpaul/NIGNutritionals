using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIGTechTest.Interfaces
{
    public interface INextDayDateLiteralUtil
    {
        public DayOfWeek FetchDayofWeek(string dayLiteral);
        public DateTime FetchDateOfNextWeekDay(DayOfWeek nextWeekDay);
    }
}
