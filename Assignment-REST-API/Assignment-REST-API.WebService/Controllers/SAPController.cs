using Assignment_REST_API.Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_REST_API.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SAPController : ControllerBase
    {
        private readonly ISAPService sapService;

        public SAPController(ISAPService sapService)
        {
            this.sapService = sapService;
        }

        [HttpGet("{sapCode}")]
        public ActionResult GetDataBySapCode(int sapCode)
        {
            var response = sapService.GetDataBySapCode(sapCode);
            return Ok(response);
        }

        [HttpGet]
        public ActionResult GetSapCodes()
        {
            var response = sapService.GetSapCodes();
            return Ok(response);
        }
    }
}