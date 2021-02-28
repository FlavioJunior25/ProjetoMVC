using System;
using System.Collections.Generic;
using ProjetoMVC.Application.Interface;
using ProjetoMVC.Domain.Entities;
using ProjetoMVC.Domain.Interfaces.Services;

namespace ProjetoMVC.Application
{
  public  class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;

        }

        IEnumerable<Produto> IProdutoAppService.BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
