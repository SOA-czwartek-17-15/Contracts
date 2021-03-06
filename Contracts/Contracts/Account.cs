﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Contracts
{
    [DataContract]
    public class Account
    {
        public Guid Id { get; set; }
        public string AccountNumber { get; set; }
        [DataMember]
        public Guid ClientId { get; set; }
        [DataMember]
        public long Money { get; set; }
        [DataMember]
        public AccountType Type { get; set; }
        [DataMember]
        public double Percentage { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
    }


    public enum AccountType
    {
        Normal,
        Deposit,
    }
}
