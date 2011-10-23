using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;



namespace SP.Contract.Data
{
    [DataContract]
    public class ItemVenda
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public decimal preco { get; set; }
        [DataMember]
        public Nullable<int> quantidade { get; set; }
        [DataMember]
        public int Venda_ID { get; set; }
        [DataMember]
        int Produto_ID { get; set; }
        [DataMember]
        public Nullable<int> CodigoBomba;
    }
}
