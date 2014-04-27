using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contracts
{
    [DataContract]
    public class Audit
    {
        public Guid Id { get; set; }
        [DataMember]
        public int AccountId { get; set; }
        [DataMember]
        public long Money { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
    }
}
