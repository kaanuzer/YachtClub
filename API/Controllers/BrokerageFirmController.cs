using Application.BrokerageFirms;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BrokerageFirmController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<BrokerageFirm>>> GetBrokerages()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BrokerageFirm>> GetBrokerage(int id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrokageFirm([FromBody] BrokerageFirm brokerageFirm)
        {
            await Mediator.Send(new Create.Command { BrokerageFirm = brokerageFirm });
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrokageFirm([FromBody] BrokerageFirm brokerageFirm)
        {
            await Mediator.Send(new Edit.Command { BrokerageFirm = brokerageFirm });
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteBrokageFirm(int Id)
        {
            await Mediator.Send(new Delete.Command { Id = Id });
            return Ok();
        }
    }
}
