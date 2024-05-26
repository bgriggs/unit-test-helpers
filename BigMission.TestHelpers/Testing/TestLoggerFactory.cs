﻿using Microsoft.Extensions.Logging;

namespace BigMission.TestHelpers.Testing;

public class TestLoggerFactory : ILoggerFactory
{
    public void AddProvider(ILoggerProvider provider)
    {

    }

    public ILogger CreateLogger(string categoryName)
    {
        return new DebugLogger();
    }

    public void Dispose()
    {
    }
}
