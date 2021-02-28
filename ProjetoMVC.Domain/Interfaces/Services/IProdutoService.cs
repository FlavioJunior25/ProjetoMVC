using ProjetoMVC.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoMVC.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
