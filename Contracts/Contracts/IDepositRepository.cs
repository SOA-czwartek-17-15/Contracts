using System.ServiceModel;
using System;

namespace Contracts
{
    [ServiceContract]
    public interface IDepositRepository
    {
        [OperationContract]
        Guid CreateDeposit(Guid clientId, Deposit deposit);

        [OperationContract]
        Guid CreateDeposit(string accountNumber, Deposit deposit);

        [OperationContract]
        Deposit GetDepositInformation(Guid depositId);

        [OperationContract]
        void RemoveDeposit(Guid depositId);
    }
}