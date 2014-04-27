﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface ICanTransferMoney
    {
        [OperationContract]
        bool TransferMoney(string idFrom, string idTo, long amount);
    }
}
