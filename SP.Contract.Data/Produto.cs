using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace SP.Contract.Data
{
    [DataContract]
    public class Produto
    {
        [DataMember]
        public string descricao { get; set; }
        [DataMember]
        public string un { get; set; }
        [DataMember]
        public string unSecundaria { get; set; }
        [DataMember]
        public decimal valor { get; set; }
        [DataMember]
        public string nome { get; set; }
        [DataMember]
        public string tipo { get; set; }
        [DataMember]
        public int codigo_produto { get; set; }
        public int Fornecedor_ID { get; set; }

        enum TipoProduto { Combustivel, Conveniencia }
    }
}
