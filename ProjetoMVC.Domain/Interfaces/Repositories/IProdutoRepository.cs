using ProjetoMVC.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoMVC.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
