using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SP.Service
{
    class ProdutoService : SP.Contract.Service.IProdutoService
    {

        public Contract.Data.Produto Inserir(Contract.Data.Produto _produto)
        {
            throw new NotImplementedException();
        }

        public Contract.Data.Produto[] BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Contract.Data.Produto BuscarPeloCodigo(int codigo)
        {
            throw new NotImplementedException();
        }


        public bool QtdeDisponivel(int codigo, int quantidade)
        {
            throw new NotImplementedException();
        }
    }
}
