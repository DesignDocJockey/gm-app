using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using gm.api.Core.Repository;
using gm.Core.Models;
using gm.Data;
using Microsoft.AspNetCore.Mvc;

namespace gm.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesheetsController : ControllerBase
    {
        private readonly ITimesheetRepository _TimesheetRepository;
        private readonly IMapper _AutoMapper;

        public TimesheetsController(ITimesheetRepository timeSheetRepository, IMapper mapper)
        {
            _TimesheetRepository = timeSheetRepository ?? throw new ArgumentNullException(nameof(timeSheetRepository));
            _AutoMapper = mapper ?? throw new ArgumentNullException(nameof(mapper)); ;
        }

        // GET api/timesheets
        [HttpGet]
        public ActionResult<IEnumerable<TimesheetDto>> Get()
        {
            var tsheets = _TimesheetRepository.GetAllTimeSheets();
            var timeSheets = _AutoMapper.Map<IEnumerable<TimesheetDto>>(tsheets);
            return Ok(timeSheets);
        }

        // GET api/timesheets/{guid}
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            return "value";
        }

        //GET api/timesheets/client?name=Olith
        [HttpGet("[action]")]
        public ActionResult<string> client([FromQuery]string name)
        {
            //https://localhost:44385/api/timesheets/client?clientname=nfl
            return $"This is returned from the Route: the /client/{name}";
        }

        // POST api/timesheets
        [HttpPost]
        public IActionResult Post([FromBody] TimesheetDto newTimeSheet)
        {
            if (newTimeSheet == null)
            {
                return BadRequest();
            }

            //if (pointOfInterest.Description == pointOfInterest.Name)
            //{
            //    ModelState.AddModelError("Description", "The provided description should be different from the name.");
            //}

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }

        // PUT api/timesheets/{guid}
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] TimesheetDto timesheetToUpdate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok();
        }
    }
}
