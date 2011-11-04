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
        Produto BuscarPeloCodigo(int codigo);

        [OperationContract]
        Produto[] BuscarTodos();

        [OperationContract]
        bool QtdeDisponivel(int codigo, int quantidade);
    }
}
