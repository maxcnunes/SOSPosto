using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace SP.Contract.Data
{
    [DataContract]
    public class Tanque// : SP.Entities.Interfaces.ITanque
    {
        public Tanque()
        { }

        //public Tanque(SP.Entities.Interfaces.ITanque tanque)
        //{
        //    Tanque_ID = tanque.Tanque_ID;
        //    capacidade = tanque.capacidade;
        //    descricao = tanque.descricao;
        //    bombas = tanque.bombas.Select(i => new Bomba(i)).ToList();
        //}

        public int Tanque_ID { get; set; }
        [DataMember]
        public string descricao { get; set; }
        [DataMember]
        public int capacidade { get; set; }
        [DataMember]
        public List<Bomba> bombas { get; set; }

        //IEnumerable<Entities.Interfaces.IBomba> Entities.Interfaces.ITanque.bombas
        //{
        //    get { return bombas.Cast<Entities.Interfaces.IBomba>(); }
        //}
    }
}
