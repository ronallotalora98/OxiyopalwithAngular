using System;
using System.Collections.Generic;
using System.Text;
using CreApps.StarterKit.Models;
using System.Threading.Tasks;

namespace CreApps.StarterKit.Services
{
     public interface IClienteService
    {
        Task Create(Cliente cliente);
        Task Update(Cliente cliente);
        Task Delete(int clienteId);
        Task<IList<Cliente>> GetAll();
        Task<Cliente> GetById(int id);
    }
}
