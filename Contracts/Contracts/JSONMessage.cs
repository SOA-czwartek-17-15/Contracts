using System;
using System.Runtime.Serialization;

namespace Contracts
{
	[DataContract]
    public class JSONMessage
    {
        [DataMember]
        public string Function { get; set; }
        [DataMember]
        public string[] Parameters { get; set; }
        [DataMember]
        public string Service { get; set; }
        [DataMember]
        public string ReponseString { get; set; }
    }
}