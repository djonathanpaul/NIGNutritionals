using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NIGTechTest.Exceptions;
using NIGTechTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIGTechTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DayToDateLiteralController : ControllerBase
    {
        private readonly INextDayDateLiteralUtil _utilObj;

        public DayToDateLiteralController(INextDayDateLiteralUtil utilObj)
        {
            _utilObj = utilObj;
        }
        [HttpGet("{dayLiteral}")]
        public string GetDateLiteral(string dayLiteral)
        {
            try
            {
                DayOfWeek nextWeekDay = _utilObj.FetchDayofWeek(dayLiteral);
                DateTime nextWeekDate = _utilObj.FetchDateOfNextWeekDay(nextWeekDay);

                return nextWeekDate.ToString("dd MMMM yyyy");
            }
            catch (NotDayOfWeekException ex)
            {
                return ex.Message;
            }
            
        }
    }
}
