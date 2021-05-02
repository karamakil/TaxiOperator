using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxiOperator.BLL.DAL;
using TaxiOperator.BLL.Manager;

namespace TaxiOperator.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetRandom()
        {
            try
            {
                return Ok(CustomerManager.GetRandom());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("SetVip")]
        public IActionResult SetVip(int id)
        {
            try
            {
                CustomerManager.SetVip(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("GetCabDriverShifts")]
        public IActionResult GetCabDriverShifts()
        {
            try
            {
                return Ok(CabDriverManager.List());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


    }
}
