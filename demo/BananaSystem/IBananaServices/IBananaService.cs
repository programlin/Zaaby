﻿using Interfaces;
using System;

namespace IBananaServices
{
    public interface IBananaService : ITest
    {
        Guid GetGuid();
        string GetBananaMsg();
        BananaDto ThrowBack(BananaDto dto);
        void ThrowEx();
        void TestAppleEx();
        void ThrowFormatterEx();
    }
}