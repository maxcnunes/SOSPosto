using System.Linq;
using SP.Contract.Data;
using SP.Contract.Service;
using SP.Entities;


namespace SP.Service
{
    public class TanqueService : ITanqueService
    {
        public Tanque Inserir(SP.Contract.Data.Tanque _tanque)
        {
            using (var ctx = new SOSPostoDataContext())
            {
                var tanque = Translator.Translate(_tanque);
                ctx.tanque.AddObject(tanque);
                ctx.SaveChanges();

                return Translator.Translate(tanque);
            }
        }

        public Tanque[] BuscarTodos()
        {
            using (var ctx = new SOSPostoDataContext())
            {
                return ctx.tanque.AsEnumerable().Select(i => Translator.Translate(i)).ToArray();
            }
        }
    }
}
