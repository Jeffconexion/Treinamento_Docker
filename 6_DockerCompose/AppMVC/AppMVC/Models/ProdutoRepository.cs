﻿using System.Collections.Generic;

namespace AppMVC.Models
{
  public class ProdutoRepository : IRepository
  {
    private AppDbContext context;
    public ProdutoRepository(AppDbContext ctx)
    {
      context = ctx;
    }
    public IEnumerable<Produto> Produtos => context.Produtos;

  }
}
