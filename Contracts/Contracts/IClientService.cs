using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface IClientService
    {
        [OperationContract]
        bool TransferMoney();

        [OperationContract]
        bool CreateClient();

        [OperationContract]
        bool GetClientInformation();

        [OperationContract]
        bool GetAccountInformation();

        [OperationContract]
        bool GetOperations();
    }
}
