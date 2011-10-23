using System;
using System.Collections.Generic;
using System.Linq;
using SP.Entities.Interfaces;

namespace SP.Entities
{
    partial class tanque : SP.Entities.Interfaces.ITanque
    {
        public IEnumerable<IBomba> bombas
        {
            get 
            { 
                return bombas.Cast<IBomba>(); 
            }
        }

        public static tanque CriarTanque(ITanque tanque)
        {
            return new tanque 
            { 
                Tanque_ID = tanque.Tanque_ID, 
                descricao = tanque.descricao, 
                capacidade = tanque.capacidade 
            };
        }
    }
}
