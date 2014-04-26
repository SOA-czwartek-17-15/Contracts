using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface IAccountRepository
    {
        [OperationContract]
        long createAccount(int clientId, Account details);

        [OperationContract]
        Account getAccountInformation(long accountNumber);
    }
}
