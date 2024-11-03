using Microsoft.Extensions.Logging;

namespace BigMission.TestHelpers.Testing;

public class TestLoggerFactory : ILoggerFactory
{
    public DebugLogger Logger { get; set; } = new DebugLogger();

    public void AddProvider(ILoggerProvider provider) { }

    public ILogger CreateLogger(string categoryName)
    {
        return Logger;
    }

    public void Dispose() { }
}
