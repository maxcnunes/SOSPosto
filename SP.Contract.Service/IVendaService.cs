using System.ServiceModel;
using SP.Contract.Data;

namespace SP.Contract.Service
{
    [ServiceContract]
    public interface IVendaService
    {
        [OperationContract]
        Venda RealizarVendaCaixa(Venda requestVenda);

        [OperationContract]
        Venda RealizarVendaBombaAutomatica(Venda requestVenda);

        [OperationContract]
        bool Cancelar();
    }
}
