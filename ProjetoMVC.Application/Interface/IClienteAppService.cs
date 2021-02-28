using ProjetoMVC.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoMVC.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClienteEspeciais();
    }
}
