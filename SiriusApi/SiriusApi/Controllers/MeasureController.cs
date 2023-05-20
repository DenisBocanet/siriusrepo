using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiriusApi.Models;
using SiriusApi.Database;
using Microsoft.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860



namespace SiriusApi.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
        public class MeasureController : ControllerBase
        {
            DBMeasure db = new DBMeasure();

            // GET: api/<DeviceController>
            [HttpGet]
            public List<TbMeasure> Get()
            {

                List<TbMeasure> tbMeasures = db.getMeasureName();

                return tbMeasures;
            }

            // GET api/<DeviceController>/5
            [HttpGet("{id}")]
            public string Get(int id)
            {
                return "value";
            }


        }

 }



