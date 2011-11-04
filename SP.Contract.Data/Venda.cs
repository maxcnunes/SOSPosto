using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;


namespace SP.Contract.Data
{
    [DataContract]
    public class Venda
    {
        [DataMember]
        public System.DateTime dataEmissao { get; set; }
        [DataMember]
        public System.DateTime dataSaida { get; set; }
        [DataMember]
        public string serie { get; set; }
        [DataMember]
        public decimal totalDesconto { get; set; }
        [DataMember]
        public int codigo_venda { get; set; }
        [DataMember]
        public int codigo_cliente { get; set; }
        [DataMember]
        public int codigo_funcionario { get; set; }
        [DataMember]
        public ItemVenda[] items { get; set; }
    }
}
