namespace BigMission.TestHelpers;

public class TimerHelper : ITimerHelper
{
    private Timer? timer;

    public Timer Create(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period)
    {
        timer = new Timer(callback, state, dueTime, period);
        return timer;
    }

    public void Dispose()
    {
        timer?.Dispose();
    }

    public ValueTask DisposeAsync()
    {
        return timer?.DisposeAsync() ?? ValueTask.CompletedTask;
    }
}
