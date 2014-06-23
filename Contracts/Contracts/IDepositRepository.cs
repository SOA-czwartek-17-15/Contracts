using System.ServiceModel;
using System;

namespace Contracts
{
    // ogólna wiadomość dla serwisu DepositRepository

    public class DepositRepositoryMessage
    {
        public string Action { get; set; }
        public string Arguments { get; set; }
    }

    // argumenty dla wiadomości odpowiadającej metodzie CreateDeposit dla id klienta

    public class CreateDepositForClientMessage
    {
        public Guid ClientId { get; set; }
        public Deposit Deposit { get; set; }
    }

    // argumenty dla wiadomości odpowiadającej metodzie CreateDeposit dla numeru konta

    public class CreateDepositForAccountMessage
    {
        public String AccountNumber { get; set; }
        public Deposit Deposit { get; set; }
    }

    // argumenty dla wiadomości odpowiadającej metodzie GetDepositInformation

    public class GetDepositInformationMessage
    {
        public Guid DepositId { get; set; }
    }

    // argumenty dla wiadomości odpowiadającej metodzie RemoveDeposit

    public class RemoveDepositMessage
    {
        public Guid DepositId { get; set; }
    }

    [ServiceContract]
    public interface IDepositRepository
    {
		[OperationContract]
        Guid CreateDepositForClient(Guid clientId, Deposit deposit);

		[OperationContract]
        Guid CreateDepositForAccount(string accountNumber, Deposit deposit);

        [OperationContract]
        Deposit GetDepositInformation(Guid depositId);

        [OperationContract]
        void RemoveDeposit(Guid depositId);
    }
}