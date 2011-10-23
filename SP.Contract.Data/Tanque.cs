using System.Runtime.Serialization;
using System.Collections.Generic;

namespace SP.Contract.Data
{
    [DataContract]
    public class Tanque : SP.Entities.Interfaces.ITanque
    {
        public int Tanque_ID { get; set; }
        [DataMember]
        public string descricao { get; set; }
        [DataMember]
        public int capacidade { get; set; }

        //[DataMember]
        //public List<bomba> Products { get; set; }

        //IEnumerable<EFEntitities.IProduct> EFEntitities.ICategory.Products
        //{
        //    get { return Products.Cast<EFEntitities.IProduct>(); }
        //}
    }
}
