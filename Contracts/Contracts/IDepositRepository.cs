using System.ServiceModel;
using System.Runtime.Serialization;
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

    [DataContract]
    public class Deposit
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public Guid ClientId { get; set; }
        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public double Interest { get; set; }
        [DataMember]
        public int CapitalizationPeriod { get; set; }
        [DataMember]
        public double Money { get; set; }
        [DataMember]
        public string OpeningDate { get; set; }
        [DataMember]
        public string Duration { get; set; }
    }
}