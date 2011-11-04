using System;
using SP.Contract.Service;

namespace SP.Service
{
    class ClienteService : IClienteService
    {
        public Contract.Data.Cliente Inserir()
        {
            throw new NotImplementedException();
        }

        public Contract.Data.Cliente BuscarPeloCodigo(int codigo)
        {
            throw new NotImplementedException();
        }

        public Contract.Data.Cliente BuscarPeloCartaoESenha(string cartao, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
