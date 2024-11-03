namespace BigMission.TestHelpers.Delay;

public class TestAsyncDelay : IAsyncDelay
{
    public virtual Task Delay(TimeSpan delay, CancellationToken stoppingToken = default)
    {
        return Task.CompletedTask;
    }
}
