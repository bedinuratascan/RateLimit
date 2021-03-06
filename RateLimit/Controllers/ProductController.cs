﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RateLimit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok(new { Id=1,Name="Silgi",Price=20});
        }
        [HttpGet("{name}")]
        public IActionResult GetProduct(string name)
        {
            return Ok(name);
        }
        [HttpPost]
        public IActionResult SaveProduct()
        {
            return Ok(new { Status="Success" });
        }

        [HttpPut]
        public IActionResult UpdateProduct()
        {
            return Ok();
        }
    }
}
