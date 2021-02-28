using System.Collections.Generic;
using ProjetoMVC.Domain.Entities;

namespace ProjetoMVC.Domain.Interfaces.Services
{
    public interface IClienteService :IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClienteEspeciais(IEnumerable<Cliente> clientes);
    }
}
