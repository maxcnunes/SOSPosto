using System;
using System.Linq;
using SP.Contract.Data;
using SP.Contract.Service;
using SP.Entities;
using System.Collections.Generic;


namespace SP.Service
{
    public class VendaService : SP.Contract.Service.IVendaService
    {
        #region Consumidores de outros Serviços
        //Cria objetos "cliente", que iram consumir algumas funcionalidades de outros Serviços

        //Serviço Produto
        ProdutoServiceHost.ProdutoServiceClient produtoClient = new ProdutoServiceHost.ProdutoServiceClient();
        //Serviço Cliente
        ClienteServiceHost.ClienteServiceClient clienteClient = new ClienteServiceHost.ClienteServiceClient();
        //Serviço Bomba
        BombaServiceHost.BombaServiceClient bombaClient = new BombaServiceHost.BombaServiceClient();
        //Serviço Bomba
        TanqueServiceHost.TanqueServiceClient tanqueClient = new TanqueServiceHost.TanqueServiceClient();
        #endregion

        //Abre conexao dos servicos relacionados
        VendaService()
        {
            produtoClient.Open();
            clienteClient.Open();
            bombaClient.Open();
            tanqueClient.Open();
        }

        public Venda RealizarVendaCaixa(Venda requestVenda)
        {
            #region Validacoes
            if (requestVenda == null)
            {
                throw new ArgumentNullException("requestVenda");
            }

            if (requestVenda.items == null || requestVenda.items.Count() == 0)
            {
                throw new ArgumentNullException("requestItens");
            }
            #endregion

            using (var ctx = new SOSPostoDataContext())
            {
                var venda = Translator.Translate(requestVenda);

                //Verifica se o cliente relacionado à venda existe
                if (clienteClient.BuscarPeloCodigo(requestVenda.codigo_cliente) == null)
                {
                    throw new ArgumentException(string.Format("Código {0} do cliente, relacionado à venda, não existe.", venda.Cliente_ID));
                }


                foreach (var item in requestVenda.items)
                {
                    var itemVenda = Translator.Translate(item);

                    //Recupera o produto do item da Venda
                    var itemProduto = produtoClient.BuscarPeloCodigo(itemVenda.Produto_ID);

                    if (itemProduto.tipo.Equals("combustivel"))
                    {

                        //Verifica se algum combustivel da lista esta em falta nos tanques
                        if (tanqueClient.QtdeDisponivel((int)itemVenda.Bomba_ID, (int)itemVenda.quantidade) == false)
                        {
                            throw new ArgumentException(string.Format("Quantidade solicitada, do combustível {0}, excede a disponível no estoque.", itemVenda.produto.nome));
                        }
                    }
                    else
                    {
                        //Verifica se o produto referente esta em falta no estoque
                        if (produtoClient.QtdeDisponivel(itemProduto) == false)
                        {
                            throw new ArgumentException(string.Format("Quantidade solicitada, do produto {0}, excede a disponível no estoque.", itemVenda.produto.nome));
                        }
                    }

                    venda.itemvenda.Add(itemVenda);
                }


                ctx.venda.AddObject(venda);
                ctx.SaveChanges();

                //Se existir algum combustivel adicionado à venda, é liberado o abastecimento na bomba
                foreach (var itemCombustivel in venda.itemvenda.Where(i => i.produto.tipo.Equals("combustivel")))
                {
                    //Libera o abastecimento
                    bombaClient.LiberarAbastecimento((int)itemCombustivel.Bomba_ID, (int)itemCombustivel.quantidade, itemCombustivel.Produto_ID);
                }



                return Translator.Translate(venda);
            }
        }

        public Venda RealizarVendaBombaAutomatica(Venda requestVenda)
        {
            #region Validacoes
            if (requestVenda == null)
            {
                throw new ArgumentNullException("requestVenda");
            }

            #endregion

            using (var ctx = new SOSPostoDataContext())
            {
                var venda = Translator.Translate(requestVenda);

                if (clienteClient.BuscarPeloCartaoESenha("", "") == null)
                {
                    throw new ArgumentException("Não foi encontrado nenhum cliente com este nº de cartão e senha!.");
                }

                foreach (var item in requestVenda.items)
                {
                    var itemVenda = Translator.Translate(item);

                    //Verifica se algum combustivel da lista esta em falta nos tanques
                    if (tanqueClient.QtdeDisponivel((int)itemVenda.Bomba_ID, (int)itemVenda.quantidade) == false)
                    {
                        throw new ArgumentException(string.Format("Quantidade solicitada, do combustível {0}, excede a disponível no estoque.", itemVenda.produto.nome));
                    }


                    venda.itemvenda.Add(itemVenda);
                }


                foreach (var itemCombustivel in venda.itemvenda.Where(i => i.produto.tipo.Equals("combustivel")))
                {
                    //É liberado o abastecimento
                    bombaClient.LiberarAbastecimento((int)itemCombustivel.Bomba_ID, (int)itemCombustivel.quantidade, itemCombustivel.Produto_ID);
                }

                //ctx.venda.AddObject(venda);
                //ctx.SaveChanges();

                return Translator.Translate(venda);
            }
        }

        public bool Cancelar()
        {
            throw new NotImplementedException();
        }


        //Fecha conexao dos servicos relacionados
        ~VendaService()
        {
            produtoClient.Close();
            clienteClient.Close();
            bombaClient.Close();
            tanqueClient.Open();
        }


    }
}
