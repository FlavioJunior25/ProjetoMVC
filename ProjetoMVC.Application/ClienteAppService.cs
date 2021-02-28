using System.Collections.Generic;
using ProjetoMVC.Application.Interface;
using ProjetoMVC.Domain.Entities;
using ProjetoMVC.Domain.Interfaces.Services;

namespace ProjetoMVC.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClienteEspeciais()
        {
            return _clienteService.ObterClienteEspeciais(_clienteService.GetAll());
        }
    }
}
