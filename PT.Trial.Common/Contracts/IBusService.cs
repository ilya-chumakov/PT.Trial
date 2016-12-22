﻿using System;
using EasyNetQ;

namespace PT.Trial.Common.Contracts
{
    public interface IBusService
    {
        void Publish(Number number, string calculationId);
        IBus CreateBus();
        void Subscribe(IBus bus, Calculation calculation, Action<Number> onMessage);
    }
}