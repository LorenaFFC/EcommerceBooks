﻿using System.Collections.Generic;

namespace EcommerceBooks.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<ProdutoRepository.Livro> livros);
    }
}