using System.ServiceModel;
using SP.Contract.Data;

namespace SP.Contract.Service
{
    [ServiceContract]
    public interface IBombaService
    {

        [OperationContract]
        Bomba Buscar(int numeroBomba);

        [OperationContract]
        Bomba LiberarAbastecimento(int numeroBomba, int qtde, int tipoCombustivel);
    }
}
