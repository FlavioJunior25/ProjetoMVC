using ProjetoMVC.Domain.Entities;
using ProjetoMVC.Domain.Interfaces.Repositories;
using ProjetoMVC.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoMVC.Domain.Services
{
   public class ClienteService : ServiceBase<Cliente> , IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) 
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClienteEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial((c)));
        }
    }
}
