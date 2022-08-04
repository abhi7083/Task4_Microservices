using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PassengerManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        List<Passenger> PassengerList = new List<Passenger>()
        {
            new Passenger() {PassId = 101,PassName = "Ray",PassEmail = "Ray@gmail.com",PassPhno = "+162836827"},
            new Passenger() {PassId = 102,PassName = "Max",PassEmail = "Max@gmail.com",PassPhno = "+134336827"},
            new Passenger() {PassId = 103,PassName = "Levi",PassEmail = "Levi@gmail.com",PassPhno = "+166836827"},
            new Passenger() {PassId = 104, PassName = "Chris",PassEmail = "Chris@gmail.com",PassPhno = "+456836827"},
        };

        [HttpGet]

        public IEnumerable<Passenger> GetAllPassengers()
        {

            return PassengerList;
        }


        [HttpPost]

        public List<Passenger> AddPassenger(Passenger Obj)
        {
            PassengerList.Add(Obj);
            return PassengerList;
        }


        [HttpPut]

        public List<Passenger> UpadtePassenger(Passenger Obj)
        { 
            var del = PassengerList.Find(item => item.PassId == Obj.PassId);
            PassengerList.Remove(del);
            PassengerList.Add(Obj);
            return PassengerList;
        }
    }
}
