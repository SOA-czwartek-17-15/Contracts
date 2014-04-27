using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Contracts
{
    [DataContract]
    public class Account
    {
        public Guid id { get; set; }
        public string accountNumber { get; set; }
        [DataMember]
        public int clientId { get; set; }
        [DataMember]
        public string firstName { get; set; }
        [DataMember]
        public string lastName { get; set; }
        [DataMember]
        public long money { get; set; }
        [DataMember]
        public string pesel { get; set; }
        [DataMember]
        public string address { get; set; }
        [DataMember]
        public string phoneNumber { get; set; }
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public double percentage { get; set; }
        [DataMember]
        public DateTime endDate { get; set; }
        [DataMember]
        public DateTime startDate { get; set; }
    }
}
