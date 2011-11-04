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
        public int codigo { get; set; }
        [DataMember]
        public decimal preco { get; set; }
        [DataMember]
        public int quantidade { get; set; }
        [DataMember]
        public int codigo_venda { get; set; }
        [DataMember]
        int codigo_produto { get; set; }
        [DataMember]
        public Nullable<int> codigo_bomba;
    }
}
