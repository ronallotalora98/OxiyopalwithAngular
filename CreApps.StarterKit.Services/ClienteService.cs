using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CreApps.StarterKit.Models;
using CreApps.StarterKit.DataAccess;

namespace CreApps.StarterKit.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IRepository<Cliente, int> _clienteRepository;

        public ClienteService(IRepository<Cliente, int> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task Create(Cliente cliente)
        {
            _clienteRepository.Add(cliente);
            await _clienteRepository.SaveChangeAsync();
        }

        public async Task Delete(int clienteId)
        {
            var cliente = await _clienteRepository.Query()
               .FirstOrDefaultAsync(x => x.Id == clienteId);

            _clienteRepository.Remove(cliente);
            await _clienteRepository.SaveChangeAsync();
        }

        public async Task<IList<Cliente>> GetAll()
        {
            var cliente = await _clienteRepository.Query()
                                .ToListAsync();

            return cliente;
        }

        public async Task<Cliente> GetById(int id)
        {

            return await _clienteRepository.Query()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(Cliente cliente)
        {
            var oldCliete = await _clienteRepository.Query()
                    .FirstOrDefaultAsync(x => x.Id == cliente.Id);

            oldCliete.NombreCliente = cliente.NombreCliente;
            oldCliete.DocumentoCliente = cliente.DocumentoCliente;
            oldCliete.TelefonoCliente = cliente.TelefonoCliente;
            oldCliete.DireccionCliente = cliente.DireccionCliente;

            await _clienteRepository.SaveChangeAsync();
        }
    }
}
