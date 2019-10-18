using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FosstechInvoice.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FosstechInvoice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : ControllerBase

    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetValues()
        {
            var values = _context.Values.ToList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<string>> GetValue(int id)
        {
            var values = _context.Values.FirstOrDefault(x => x.Id == id);
            return Ok(values);
        }
    }
}