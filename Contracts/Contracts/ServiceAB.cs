using System;
using System.Runtime.Serialization;

namespace Contracts
{
	[DataContract]
    public class ServiceAB
    {
        [DataMember]
        public string Binding { get; set; }
        [DataMember]
        public string Adress { get; set; }
    }
}