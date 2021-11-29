using NIGTechTest.Exceptions;
using NIGTechTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIGTechTest.Models
{
    public class NextDayDateLiteralUtil : INextDayDateLiteralUtil
    {
        public DayOfWeek FetchDayofWeek(string dayLiteral)
        {
            DayOfWeek dayOfWeekToFind;
            switch (dayLiteral.ToUpper())
            {
                case "MONDAY":
                    dayOfWeekToFind = DayOfWeek.Monday;
                    break;
                case "TUESDAY":
                    dayOfWeekToFind = DayOfWeek.Tuesday;
                    break;
                case "WEDNESDAY":
                    dayOfWeekToFind = DayOfWeek.Wednesday;
                    break;
                case "THURSDAY":
                    dayOfWeekToFind = DayOfWeek.Thursday;
                    break;
                case "FRIDAY":
                    dayOfWeekToFind = DayOfWeek.Friday;
                    break;
                case "SATURDAY":
                    dayOfWeekToFind = DayOfWeek.Saturday;
                    break;
                case "SUNDAY":
                    dayOfWeekToFind = DayOfWeek.Sunday;
                    break;
                default:
                    throw new NotDayOfWeekException("Please enter a valid day of the week.");                        
            }

            return dayOfWeekToFind;
        }

        public DateTime FetchDateOfNextWeekDay(DayOfWeek nextWeekDay)
        {
            DateTime result = DateTime.Now.AddDays(1);
            while (result.DayOfWeek != nextWeekDay)
                result = result.AddDays(1);
            return result;
        }
    }
}
