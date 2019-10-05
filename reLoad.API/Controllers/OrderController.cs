using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Api;
using Entities.Api.Order;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<OrderResponse> Create(OrderRequest request)
        {

            return CreatedAtAction(nameof(Create), new OrderResponse());
        }
    }

   
}