namespace BigMission.TestHelpers.Delay;

public class TestAsyncDelay : IAsyncDelay
{
    public virtual Task Delay(TimeSpan delay)
    {
        return Task.CompletedTask;
    }
}
