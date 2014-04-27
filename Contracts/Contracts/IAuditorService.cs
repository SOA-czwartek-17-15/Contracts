using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        int GetNumberOfTransfersByAccount(int accountId);
        [OperationContract]
        int GetTransferedMoneyByDate(DateTime date);
        [OperationContract]
        int GetTransferedMoneyByAccount(int accountId);
        [OperationContract]
        int GetNumberOfCredits();
        [OperationContract]
        IEnumerable<Audit> AuditAll();
        [OperationContract]
        IEnumerable<Audit> GetAuditsByDate(DateTime date);
        [OperationContract]
        IEnumerable<Audit> GetAuditsByAccount(int accountId);
        [OperationContract]
        bool AddAudit(int accountId, long Money);
    }
}
