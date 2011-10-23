using System;
using System.Collections.Generic;
using System.Linq;

namespace SP.Entities.Interfaces
{
    public interface ITanque
    {
        int Tanque_ID { get; set; }
        string descricao { get; set; }
        int capacidade { get; set; }
        IEnumerable<IBomba> bombas { get; }
    }
}
