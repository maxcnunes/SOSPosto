

namespace SP.Contract.Data
{
    public static class Translator
    {
        #region Tanque Translation
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
        #endregion

        #region Produto Translation
        public static SP.Entities.produto Translate(SP.Contract.Data.Produto from)
        {
            var to = new SP.Entities.produto();
            to.Produto_ID = from.Produto_ID;
            to.un = from.un;
            to.unSecundaria = from.unSecundaria;
            to.valor = from.valor;
            to.nome = from.nome;
            to.tipo = from.tipo;

            return to;
        }

        public static SP.Contract.Data.Produto Translate(SP.Entities.produto from)
        {
            var to = new SP.Contract.Data.Produto();
            to.Produto_ID = from.Produto_ID;
            to.un = from.un;
            to.unSecundaria = from.unSecundaria;
            to.valor = from.valor;
            to.nome = from.nome;
            to.tipo = from.tipo;

            return to;
        }
        #endregion

        #region Venda Translation
        public static SP.Entities.venda Translate(SP.Contract.Data.Venda from)
        {
            var to = new SP.Entities.venda();
            to.Venda_ID = from.Venda_ID;
            to.dataEmissao = from.dataEmissao;
            to.dataSaida = from.dataSaida;
            to.serie = from.serie;
            to.totalDesconto = from.totalDesconto;
            to.Cliente_ID = from.Cliente_ID;
            to.Usuário_ID = from.Usuário_ID;

            return to;
        }

        public static SP.Contract.Data.Venda Translate(SP.Entities.venda from)
        {
            var to = new SP.Contract.Data.Venda();
            to.Venda_ID = from.Venda_ID;
            to.dataEmissao = from.dataEmissao;
            to.dataSaida = from.dataSaida;
            to.serie = from.serie;
            to.totalDesconto = from.totalDesconto;
            to.Cliente_ID = from.Cliente_ID;
            to.Usuário_ID = from.Usuário_ID;

            return to;
        }
        #endregion

        #region ItemVenda Translation
        public static SP.Entities.itemvenda Translate(SP.Contract.Data.ItemVenda from)
        {
            var to = new SP.Entities.itemvenda();
            to.preco = from.preco;

            return to;
        }

        public static SP.Contract.Data.ItemVenda Translate(SP.Entities.itemvenda from)
        {
            var to = new SP.Contract.Data.ItemVenda();

            return to;
        }
        #endregion
    }
}
