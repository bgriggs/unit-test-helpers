namespace BigMission.TestHelpers.Delay;

public interface IAsyncDelay
{
    public Task Delay(TimeSpan delay, CancellationToken stoppingToken);
}
