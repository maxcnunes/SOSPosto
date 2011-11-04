using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SP.Contract.Service;

namespace SP.Service
{
    class BombaService : IBombaService
    {
        public Contract.Data.Bomba Buscar(int numeroBomba)
        {
            throw new NotImplementedException();
        }

        public Contract.Data.Bomba LiberarAbastecimento(int numeroBomba, int qtde, int tipoCombustivel)
        {
            //Simula um delay da integração do sistema com o hardware da bomba
            throw new NotImplementedException();
        }
    }
}
