using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiriusApi.Models;
using SiriusApi.Database;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SiriusApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        DBDevice dBDevice = new DBDevice();

        // GET: api/<DeviceController>
        [HttpGet]
        public List<TbDevice> Get()
        {

            List<TbDevice> tbDevices = dBDevice.getDevicesName();

            return tbDevices;
        }

        // GET api/<DeviceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

      
    }
}
