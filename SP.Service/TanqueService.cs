using System.Linq;
using SP.Contract.Data;
using SP.Contract.Service;
using SP.Entities;


namespace SP.Service
{
    public class TanqueService : ITanqueService
    {
        public Tanque InserirTanque(SP.Contract.Data.Tanque _tanque)
        {
            using (var ctx = new SOSPostoDataContext())
            {
                var tanque = new SP.Entities.tanque();
                _tanque.capacidade = 1000;
                ctx.tanque.AddObject(_tanque);
                ctx.SaveChanges();

                return tanque;
            }
        }

        public Tanque[] BuscarTodosTanques()
        {
            using (var ctx = new SOSPostoDataContext())
            {
                var _tanque = ctx.tanque.First();
                Console.WriteLine("Found {0}", _tanque.Tanque_ID);
            }
        }
    }
}
