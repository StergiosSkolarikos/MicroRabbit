using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;
        public TransferController (ITransferService transferService)
        {
            _transferService = transferService;
        }
        //GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> Get()
        {
            
            return Ok(_transferService.GetTransferLogs());
        }
        //[HttpPost]
        //public IActionResult Post([FromBody] AccountTransfer accountTransfer)
        //{
        //    _accountService.Transfer(accountTransfer);
        //    return Ok(accountTransfer);
        //}
    }
}
