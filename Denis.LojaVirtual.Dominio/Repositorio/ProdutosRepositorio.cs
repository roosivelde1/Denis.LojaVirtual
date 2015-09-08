﻿using System.Collections.Generic;
using Denis.LojaVirtual.Dominio.Entidade;

namespace Denis.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly  EfDbContext _context= new EfDbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }

        
    }
}
