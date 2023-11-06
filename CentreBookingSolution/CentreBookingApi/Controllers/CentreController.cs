using CentreBookingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CentreBookingApi.Controllers
{
    public class CentreController : ApiController
    {
        private static List<Centre> centreList = new List<Centre>{ new Centre { id = Guid.NewGuid(), Name = "YMCA" },
            new Centre { id = Guid.NewGuid(), Name = "YOUTH CLUB" } };
       
        
        //Return the Center list
        public IEnumerable<Centre> Get()
        {
            return centreList;



        }

        public IActionResult Post([FromBody] string value)
        {
            if (string.IsNullOrEmpty(value))
                return BadRequest("Name cannot be blank");
            centreList.Add(new Centre { id=Guid.NewGuid(), Name=value } );


        }
    }
}
