﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface IServiceRepository
    {
        [OperationContract(Name = "RegisterServiceWithBinding")]
        void RegisterService(String Name, String Address, String Binding);

        [OperationContract(Name = "RegisterServiceWithoutBinding")]
        void RegisterService(String Name, String Address);

        [OperationContract(Name = "GetServiceLocationWithBinding")]
        string GetServiceLocation(String Name, String Binding);

        [OperationContract(Name = "GetServiceLocationWithoutBinding")]
        string GetServiceLocation(String Name);

        [OperationContract(Name = "UnregisterWithBinding")]
        void Unregister(String Name, String Binding);

        [OperationContract(Name = "UnregisterWithoutBinding")]
        void Unregister(String Name);

        [OperationContract(Name = "AliveWithBinding")]
        void Alive(String Name, String Binding);

        [OperationContract(Name = "AliveWithoutBinding")]
        void Alive(String Name);
    }
}
