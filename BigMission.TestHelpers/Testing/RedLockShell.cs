using RedLockNet;

namespace BigMission.TestHelpers.Testing;

public class RedLockShell : IRedLock
{
    public string Resource => throw new NotImplementedException();

    public string LockId => throw new NotImplementedException();

    public bool IsAcquired { get; set; }

    public RedLockStatus Status => throw new NotImplementedException();

    public RedLockInstanceSummary InstanceSummary => throw new NotImplementedException();

    public int ExtendCount => throw new NotImplementedException();

    public SemaphoreSlim Semaphore { get; }

    public RedLockShell(SemaphoreSlim semaphore)
    {
        Semaphore = semaphore;
    }

    public void Dispose()
    {
        Semaphore.Release();
    }

    public ValueTask DisposeAsync()
    {
        Dispose();
        return ValueTask.CompletedTask;
    }
}
