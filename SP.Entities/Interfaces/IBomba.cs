using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SP.Entities.Interfaces
{
    public interface IBomba
    {
        int numBomba { get; set; }
        int Bomba_ID { get; set; }
        int? Tanque_ID { get; set; }
    }
}
