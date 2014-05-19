using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Contracts
{
    [ServiceContract]
    public interface IAuditorService
    {
        [OperationContract]
        int GetNumberOfTransfersByDate(DateTime date);
        [OperationContract]
        int GetNumberOfTransfersByAccount(String accountNumber);
        [OperationContract]
        int GetTransferedMoneyByDate(DateTime date);
        [OperationContract]
        int GetTransferedMoneyByAccount(String accountNumber);
        [OperationContract]
        int GetNumberOfCredits();
        [OperationContract]
        IEnumerable<Audit> AuditAll();
        [OperationContract]
        IEnumerable<Audit> GetAuditsByDate(DateTime date);
        [OperationContract]
        IEnumerable<Audit> GetAuditsByAccount(String accountNumber);
        [OperationContract]
        bool AddAudit(String accountNumber, long Money);
    }
}
