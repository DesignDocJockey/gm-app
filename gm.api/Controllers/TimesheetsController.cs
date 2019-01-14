using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using gm.Data;
using Microsoft.AspNetCore.Mvc;

namespace gm.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesheetsController : ControllerBase
    {
        private readonly TimeSheetDBContext _TimeSheetContext;
        private readonly IMapper _AutoMapper;

        public TimesheetsController(TimeSheetDBContext ctx, IMapper mapper)
        {

            //_TimeSheetContext = booksRepository
            //   ?? throw new ArgumentNullException(nameof(booksRepository));
            //_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

            _TimeSheetContext = ctx;
            _AutoMapper = mapper;
        }

        // GET api/timesheets
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var tsheets = _TimeSheetContext.TimeSheets;

            return new string[] { "value1", "value2" };
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
        public void Post([FromBody] string value)
        {
        }

        // PUT api/timesheets/{guid}
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] string value)
        {
        }

    }
}
