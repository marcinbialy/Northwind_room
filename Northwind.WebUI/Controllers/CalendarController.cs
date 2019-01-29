using Microsoft.AspNetCore.Mvc;
using Northwind.Application.Rooms.Queries.GetRoomCalendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.WebUI.Controllers
{
    public class CalendarController : BaseController
    {
        // GET: api/calendar
        [HttpGet]
        public async Task<ActionResult<CalendarListViewModel>> GetAll()
        {
            return Ok(await Mediator.Send(new GetRoomCalendarQuery()));
        }
    }
}
