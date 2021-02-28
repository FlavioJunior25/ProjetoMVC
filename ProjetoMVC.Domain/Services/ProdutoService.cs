using System.Collections.Generic;
using ProjetoMVC.Domain.Entities;
using ProjetoMVC.Domain.Interfaces.Repositories;
using ProjetoMVC.Domain.Interfaces.Services;

namespace ProjetoMVC.Domain.Services
{
   public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {

        private readonly IProdutoRepository _produtoRepository;

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome((nome));
        }

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    }
}
