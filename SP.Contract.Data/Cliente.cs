using System.Runtime.Serialization;
using System;

namespace SP.Contract.Data
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public string cpf { get; set; }
        [DataMember]
        public virtual string endereco { get; set; }
        [DataMember]
        public virtual string cep { get; set; }
        [DataMember]
        public virtual string cidade { get; set; }
        [DataMember]
        public virtual Nullable<int> num { get; set; }
        [DataMember]
        public virtual string fonecelular { get; set; }
        [DataMember]
        public virtual string fonecomercial { get; set; }
        [DataMember]
        public virtual string foneresidencial { get; set; }
        [DataMember]
        public virtual string nome { get; set; }
        [DataMember]
        public virtual string rg { get; set; }
        [DataMember]
        public virtual bool ativo { get; set; }
        [DataMember]
        public virtual int Cliente_ID { get; set; }
    }
}
