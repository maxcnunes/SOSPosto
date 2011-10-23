using System.ServiceModel;
using SP.Contract.Data;

namespace SP.Contract.Service
{
    [ServiceContract]
    public interface IProdutoService
    {
        [OperationContract]
        Produto Inserir(Produto _produto);

        [OperationContract]
        Produto[] BuscarTodos();

        [OperationContract]
        bool QtdeDisponivel(Produto _produto);
    }
}
