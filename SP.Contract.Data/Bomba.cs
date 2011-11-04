using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SP.Contract.Data
{
    [DataContract]
    public class Bomba
    {
        public int numBomba { get; set; }
        public int Bomba_ID { get; set; }
        public int TipoCombustivel { get; set; }
        public int codigo_tanque { get; set; }

        public enum EnumTipoCombustivel { gasolina, alcool, diesel }
    }
}
