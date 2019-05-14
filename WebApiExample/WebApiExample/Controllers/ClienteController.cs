using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreApps.StarterKit.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CreApps.StarterKit.Models;
using Microsoft.AspNetCore.Cors;

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

        // POST: api/create
        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {

            await _clienteService.Create(cliente);
            return CreatedAtRoute("DefaultApi", new { id = cliente.Id }, cliente);
        }
    }
}