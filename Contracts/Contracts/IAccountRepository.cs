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
        bool CreateAccount(Account details);

        [OperationContract]
        Account GetAccountInformation(string accountNumber);

        [OperationContract]
        Account GetAccountById(Guid accountId);

        // amount to kwota ktora ma zostac dodana/odjeta od konta (w zaleznosci od znaku)
        [OperationContract]
        bool ChangeAccountBalance(Guid accountId, long amount);
    }

    public class AccountRepositoryMessage
    {
        public string Action { get; set; }
        public string Arguments { get; set; }
    }

    public class CreateAccountMessage
    {
        public Account details { get; set; }
    }

    public class GetAccountInformationMessage
    {
        public string accountNumber { get; set; }
    }

    public class GetAccountsByIdMessage
    {
        public Guid accountID { get; set; }
    }

    public class ChangeAccountBalanceMessage
    {
        public Guid accountID { get; set; }
        public long money { get; set; }
    }
}
