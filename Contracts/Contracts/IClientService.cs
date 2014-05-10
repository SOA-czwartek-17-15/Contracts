using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface IClientRepository
    {
        [OperationContract]
        boolean logIn();

        [OperationContract]
        boolean logOut();

        [OperationContract]
        Account getAccountInformation(long accountNumber);
    }
}
