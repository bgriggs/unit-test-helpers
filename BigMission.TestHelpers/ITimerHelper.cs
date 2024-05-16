namespace BigMission.TestHelpers;

public interface ITimerHelper
{
    Timer Create(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period);
    void Dispose();
    ValueTask DisposeAsync();
}
