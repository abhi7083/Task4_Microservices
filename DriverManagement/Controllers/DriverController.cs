using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DriverManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
      
        List<Drivers> Driverlist = new List<Drivers>
        {
            new Drivers() {DriversId = 201,DriversName = "David",DriversExp = "5 years",DriversPhno = "+24123123"},
            new Drivers() {DriversId = 202,DriversName = "Mark",DriversExp = "3 years",DriversPhno = "+23423123" },
            new Drivers() {DriversId = 203,DriversName = "David",DriversExp = "6 years",DriversPhno = "+26983123"},
        };

        [HttpGet]
        public IEnumerable<Drivers> GetAllDriverslist()
        {
            return Driverlist;
        }

        // POST api/<DriverController>
        [HttpPost]
        public List<Drivers> AddDrivers (Drivers obj)
        {
            Driverlist.Add(obj);
            return Driverlist;
        }

        public List<Drivers> UpdateDrivers(Drivers obj)
        {
            var del = Driverlist.Find(item => item.DriversId == obj.DriversId);
            Driverlist.Remove(del);
            Driverlist.Add(obj);
            return Driverlist;

        }

    }
}
