using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBO.Core.BusinessService.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IBO.Core.BusinessService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        //static List<Quote> _quotes = new List<Quote>()
        //{
        //    new Quote(){ id=0, Author="Chetan bhagat", Description="Romance", Title ="One night at call center" },
        //    new Quote(){ id= 1,Author="prem chand", Description="Drama", Title ="Godan"},
        //    new Quote(){ id= 2,Author="Mahadevi verma", Description="poet", Title ="veerangana"}
        //};

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    return Ok(_quotes);
        //}

        //[HttpPost]
        //public void Post([FromBody]Quote quote)
        //{
        //    _quotes.Add(quote);
        //}
    }

    
}