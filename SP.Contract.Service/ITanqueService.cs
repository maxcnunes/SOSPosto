using System.ServiceModel;
using SP.Contract.Data;

namespace SP.Contract.Service
{
    [ServiceContract]
    public interface ITanqueService
    {
        [OperationContract]
        Tanque Inserir(Tanque _tanque);

        [OperationContract]
        Tanque[] BuscarTodos();
    }
}
