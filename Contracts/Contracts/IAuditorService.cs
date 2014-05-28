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
        Audit GetLastAuditByAccount(string accountNumber)
        [OperationContract]
        IEnumerable<Audit> GetAllAuditsByAccount(string accountNumber)
        [OperationContract]
        IEnumerable<Audit> GetAllAudits()
        [OperationContract]
        bool AddAudit(String accountNumber, long Money);
    }
}
