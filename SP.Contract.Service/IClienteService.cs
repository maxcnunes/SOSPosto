using System.ServiceModel;
using SP.Contract.Data;

namespace SP.Contract.Service
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        Cliente Inserir();
        [OperationContract]
        Cliente BuscarPeloCartaoESenha(string cartao, string senha);
    }
}
