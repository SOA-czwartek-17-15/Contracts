using System;
using System.Runtime.Serialization;

namespace Contracts
{
	[DataContract]
	public class Deposit
	{
		[DataMember]
		virtual public Guid Id { get; set; }
		[DataMember]
        virtual public Guid ClientId { get; set; }
		[DataMember]
        virtual public string AccountNumber { get; set; }
		[DataMember]
        virtual public string Type { get; set; }
		[DataMember]
        virtual public double Interest { get; set; }
		[DataMember]
        virtual public int CapitalizationPeriod { get; set; }
		[DataMember]
        virtual public double Money { get; set; }
		[DataMember]
        virtual public string OpeningDate { get; set; }
		[DataMember]
        virtual public string Duration { get; set; }
	}
}