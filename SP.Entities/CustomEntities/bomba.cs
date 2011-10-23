using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SP.Entities
{
    partial class bomba : SP.Entities.Interfaces.IBomba
    {

        public static bomba CriarBomba(SP.Entities.Interfaces.IBomba bomba)
        {
            return new bomba()
            {
                
            };
        }
    }
}
