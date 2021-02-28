using ProjetoMVC.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoMVC.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
