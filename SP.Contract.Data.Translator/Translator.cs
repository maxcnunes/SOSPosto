

namespace SP.Contract.Data
{
    public static class Translator
    {
        public static SP.Entities.tanque Translate(SP.Contract.Data.Tanque from)
        {
            SP.Entities.tanque to = new SP.Entities.tanque();
            to.Tanque_ID = from.Tanque_ID;
            to.capacidade = from.capacidade;
            to.descricao = from.descricao;

            return to;
        }

        public static SP.Contract.Data.Tanque Translate(SP.Entities.tanque from)
        {
            SP.Contract.Data.Tanque to = new SP.Contract.Data.Tanque();
            to.Tanque_ID = from.Tanque_ID;
            to.capacidade = from.capacidade;
            to.descricao = from.descricao;

            return to;
        }
    }
}
