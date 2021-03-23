using BankSampleMary.Model;
using BankSampleMary.Model.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankSampleMary.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private ClienteRepository Repository = new ClienteRepository();
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await this.Repository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await this.Repository.Get(id));
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Cliente model)
        {
            await this.Repository.Save(model);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Cliente model)
        {
            await this.Repository.Update(id, model);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await this.Repository.Remove(id);
            return Ok();
        }
    }
}
