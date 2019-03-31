using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolidayService.Domain;
using HolidayService.Model;
using Microsoft.AspNetCore.Mvc;

namespace HolidayService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HolidayController : ControllerBase
    {
        List<Holiday> holidays;
        public HolidayController()
        {


            Holiday date = new Holiday
            {
                Date = new DateTime(2019, 01, 01)
            };

            Holiday date1 = new Holiday
            {
                Date = new DateTime(2019, 03, 21)
            };

            Holiday date2 = new Holiday
            {
                Date = new DateTime(2019, 04, 19)
            };
            Holiday date3 = new Holiday
            {
                Date = new DateTime(2019, 04, 27)
            };
            Holiday date4 = new Holiday
            {
                Date = new DateTime(2019, 05, 01)
            };
            Holiday date5 = new Holiday
            {
                Date = new DateTime(2019, 05, 08)
            };
            Holiday date6 = new Holiday
            {
                Date = new DateTime(2019, 06, 16)
            };
            Holiday date7 = new Holiday
            {
                Date = new DateTime(2019, 06, 17)
            };
            Holiday date8 = new Holiday
            {
                Date = new DateTime(2019, 08, 09)
            };
            Holiday date9 = new Holiday
            {
                Date = new DateTime(2019, 09, 01)
            };
            Holiday date10 = new Holiday
            {
                Date = new DateTime(2019, 09, 24)
            };
            Holiday date11 = new Holiday
            {
                Date = new DateTime(2019, 12, 16)
            };
            Holiday date12 = new Holiday
            {
                Date = new DateTime(2019, 12, 25)
            };

            Holiday date13 = new Holiday
            {
                Date = new DateTime(2019, 12, 26)
            };


            holidays = new List<Holiday> { date, date1, date2, date3, date4, date5, date6, date7, date8, date9, date10, date11, date12, date13 };
        }

        [HttpGet("{date}")]
        public HolidayResponse IsHoliday(DateTime? date)
        {

            var isHoliday = false;
            if (date.HasValue)
                isHoliday = this.holidays.Any(x => x.Date.Date == date.Value.Date);

            return new HolidayResponse { IsHoliday = isHoliday };
        }
    }
}
