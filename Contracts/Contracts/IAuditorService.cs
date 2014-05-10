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
        int GetNumberOfTransfersByAccount(Guid accountId);
        [OperationContract]
        int GetTransferedMoneyByDate(DateTime date);
        [OperationContract]
        int GetTransferedMoneyByAccount(Guid accountId);
        [OperationContract]
        int GetNumberOfCredits();
        [OperationContract]
        IEnumerable<Audit> AuditAll();
        [OperationContract]
        IEnumerable<Audit> GetAuditsByDate(DateTime date);
        [OperationContract]
        IEnumerable<Audit> GetAuditsByAccount(Guid accountId);
        [OperationContract]
        bool AddAudit(Guid accountId, long Money);
    }
}
