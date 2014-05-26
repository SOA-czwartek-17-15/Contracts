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
        boolean logIn(Guid clientID);

        [OperationContract]
        boolean logOut(Guid clientID);

        [OperationContract]
        boolean createClient();

        [OperationContract]
        boolean createAccount();
        
        [OperationContract]
        boolean deposit();
        
        [OperationContract]
        boolean internalTransfer();
        
        [OperationContract]
        boolean externalTransfer();
        
        [OperationContract]
        Account getAccountInformation(long accountNumber);
    }
}
