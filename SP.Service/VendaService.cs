using System;
using System.Linq;
using SP.Contract.Data;
using SP.Contract.Service;
using SP.Entities;


namespace SP.Service
{
    public class VendaService : SP.Contract.Service.IVendaService
    {
        ProdutoServiceHost.ProdutoServiceClient produtoClient = new ProdutoServiceHost.ProdutoServiceClient();

        //Abre conexao dos servicos relacionados
        VendaService()
        {
            produtoClient.Open();
        }
        

        public Contract.Data.Venda RealizarVendaCaixa(Contract.Data.ItemVenda[] requestItens, Contract.Data.Venda requestVenda)
        {
            #region Validacoes
            if (requestVenda == null)
            {
                throw new ArgumentNullException("requestVenda");
            }

            if (requestItens == null || requestItens.Count() == 0)
            {
                throw new ArgumentNullException("requestItens");
            }
            #endregion

            using (var ctx = new SOSPostoDataContext())
            {
                var venda = Translator.Translate(requestVenda);


                foreach (var item in requestItens)
                {
                    var itemVenda = Translator.Translate(item);

                    //Verifica se alguns produto da lista esta em falta no estoque
                    if (produtoClient.QtdeDisponivel(Translator.Translate(itemVenda.produto)) == false)
                    {
                        throw new ArgumentException("Quantidade solicitada, do produto {0}, excede a disponível no estoque.", itemVenda.produto.nome);
                    }

                    venda.itemvenda.Add(itemVenda);
                }
                

                ctx.venda.AddObject(venda);
                ctx.SaveChanges();

                return Translator.Translate(venda);
            }
        }

        public Venda RealizarVendaBombaAutomatica(Venda requestVenda)
        {
            throw new NotImplementedException();
        }

        public bool Cancelar()
        {
            throw new NotImplementedException();
        }


        //Fecha conexao dos servicos relacionados
        ~VendaService()
        {
            produtoClient.Close();
        }
    }
}
