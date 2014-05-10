/*  SOA - Serwis zarządzania klientami dla banku
    created by Bartłomiej Hebda & Tomasz Bąba | 2014  */

using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel.Description;

namespace Contracts {

    [DataContract]
    public class ClientInformation {

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Street { get; set; }

        [DataMember]
        public string PostCode { get; set; }

        [DataMember]
        public string BirthPlace { get; set; }

        [DataMember]
        public DateTime BirthDate { get; set; }
    }
}
