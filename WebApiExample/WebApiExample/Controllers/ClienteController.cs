using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreApps.StarterKit.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CreApps.StarterKit.Models;
using Microsoft.AspNetCore.Cors;
using System.Net;

namespace WebApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        //api/cliente
        
        [HttpGet]
        public async Task <ActionResult<IEnumerable<string>>> Get()
        {
            var AllClientes = await _clienteService.GetAll();
            return Ok(AllClientes);
        }

        // GET api/cliente/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return  id.ToString();
        //}

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var onCliente = await _clienteService.GetById(id);
            return Ok(onCliente);
        }

        // POST: api/create
        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {

            await _clienteService.Create(cliente);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [Route("{id}")]
        [ProducesResponseType(typeof(Cliente), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Update(int id, Cliente cliente)
        {
            if(id != cliente.Id)
            {
                return BadRequest();
            }
            await _clienteService.Update(cliente);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _clienteService.Delete(id);
            return Ok();
        }
    }
}