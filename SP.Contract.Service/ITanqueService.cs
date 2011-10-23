using System.ServiceModel;
using SP.Contract.Data;

namespace SP.Contract.Service
{
    [ServiceContract]
    public interface ITanqueService
    {
        [OperationContract]
        Tanque InserirTanque(SP.Entities.Interfaces.ITanque _tanque);

        [OperationContract]
        Tanque[] BuscarTodosTanques();
    }
}
