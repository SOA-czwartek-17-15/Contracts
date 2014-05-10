using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface IAccountRepository
    {
        [OperationContract]
        long CreateAccount(int clientId, Account details);

        [OperationContract]
        Account GetAccountInformation(string accountNumber);

        [OperationContract]
        Account GetAccountById(string accountId);

        // amount to kwota ktora ma zostac dodana/odjeta od konta (w zaleznosci od znaku)
        [OperationContract]
        bool ChangeAccountBalance(string accountNumber, long amount);
    }
}
