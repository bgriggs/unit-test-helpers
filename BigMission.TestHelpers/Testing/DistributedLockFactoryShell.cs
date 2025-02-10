using RedLockNet;

namespace BigMission.TestHelpers.Testing;

public class DistributedLockFactoryShell : IDistributedLockFactory
{
    private Dictionary<string, SemaphoreSlim> locks = [];

    public IRedLock CreateLock(string resource, TimeSpan expiryTime)
    {
        var s = GetOrCreateLock(resource);
        if (s.Wait(1))
        {
            return new RedLockShell(s) { IsAcquired = true };
        }
        return new RedLockShell(s) { IsAcquired = false };
    }

    public IRedLock CreateLock(string resource, TimeSpan expiryTime, TimeSpan waitTime, TimeSpan retryTime, CancellationToken? cancellationToken = null)
    {
        var s = GetOrCreateLock(resource);
        if (s.Wait(waitTime.Milliseconds))
        {
            return new RedLockShell(s) { IsAcquired = true };
        }
        return new RedLockShell(s) { IsAcquired = false };
    }

    public async Task<IRedLock> CreateLockAsync(string resource, TimeSpan expiryTime)
    {
        var s = GetOrCreateLock(resource);
        if (await s.WaitAsync(1))
        {
            return new RedLockShell(s) { IsAcquired = true };
        }
        return new RedLockShell(s) { IsAcquired = false };
    }

    public async Task<IRedLock> CreateLockAsync(string resource, TimeSpan expiryTime, TimeSpan waitTime, TimeSpan retryTime, CancellationToken? cancellationToken = null)
    {
        var s = GetOrCreateLock(resource);
        if (await s.WaitAsync(waitTime.Milliseconds))
        {
            return new RedLockShell(s) { IsAcquired = true };
        }
        return new RedLockShell(s) { IsAcquired = false };
    }

    private SemaphoreSlim GetOrCreateLock(string resource)
    {
        if (!locks.TryGetValue(resource, out var semaphore))
        {
            semaphore = new SemaphoreSlim(1);
            locks.Add(resource, semaphore);
        }
        return semaphore;
    }
}
