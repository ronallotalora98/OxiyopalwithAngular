using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CreApps.StarterKit.Models;
using CreApps.StarterKit.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreApps.StarterKit.WebApi.Controllers
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


        [Route("Get")]
        [ProducesResponseType(typeof(List<Cliente>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get()
        {
            var AllClientes = await _clienteService.GetAll();
            return Ok(AllClientes);
        }
    }
}