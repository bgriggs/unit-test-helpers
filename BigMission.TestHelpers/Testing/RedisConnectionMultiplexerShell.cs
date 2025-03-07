﻿#pragma warning disable CS0067

using StackExchange.Redis;
using StackExchange.Redis.Maintenance;
using StackExchange.Redis.Profiling;
using StackRedis.L1;
using System.Net;

namespace BigMission.TestHelpers.Testing;

public class RedisConnectionMultiplexerShell : IConnectionMultiplexer
{
    public string ClientName => throw new NotImplementedException();

    public string Configuration => throw new NotImplementedException();

    public int TimeoutMilliseconds => throw new NotImplementedException();

    public long OperationCount => throw new NotImplementedException();

    public bool PreserveAsyncOrder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public bool IsConnected => throw new NotImplementedException();

    public bool IsConnecting => throw new NotImplementedException();

    public bool IncludeDetailInExceptions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int StormLogThreshold { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public event EventHandler<RedisErrorEventArgs>? ErrorMessage;
    public event EventHandler<ConnectionFailedEventArgs>? ConnectionFailed;
    public event EventHandler<InternalErrorEventArgs>? InternalError;
    public event EventHandler<ConnectionFailedEventArgs>? ConnectionRestored;
    public event EventHandler<EndPointEventArgs>? ConfigurationChanged;
    public event EventHandler<EndPointEventArgs>? ConfigurationChangedBroadcast;
    public event EventHandler<ServerMaintenanceEvent>? ServerMaintenanceEvent;
    public event EventHandler<HashSlotMovedEventArgs>? HashSlotMoved;
    
    private RedisL1Database inMemoryDb;

    public RedisConnectionMultiplexerShell()
    {
        inMemoryDb = new RedisL1Database(Guid.NewGuid().ToString());
    }

    public void AddLibraryNameSuffix(string suffix)
    {
        throw new NotImplementedException();
    }

    public void Close(bool allowCommandsToComplete = true)
    {
        throw new NotImplementedException();
    }

    public Task CloseAsync(bool allowCommandsToComplete = true)
    {
        throw new NotImplementedException();
    }

    public bool Configure(TextWriter? log = null)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ConfigureAsync(TextWriter? log = null)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public ValueTask DisposeAsync()
    {
        throw new NotImplementedException();
    }

    public void ExportConfiguration(Stream destination, ExportOptions options = (ExportOptions)(-1))
    {
        throw new NotImplementedException();
    }

    public ServerCounters GetCounters()
    {
        throw new NotImplementedException();
    }

    public IDatabase GetDatabase(int db = -1, object? asyncState = null)
    {
        return inMemoryDb;
    }

    public EndPoint[] GetEndPoints(bool configuredOnly = false)
    {
        throw new NotImplementedException();
    }

    public int GetHashSlot(RedisKey key)
    {
        throw new NotImplementedException();
    }

    public IServer GetServer(string host, int port, object? asyncState = null)
    {
        throw new NotImplementedException();
    }

    public IServer GetServer(string hostAndPort, object? asyncState = null)
    {
        throw new NotImplementedException();
    }

    public IServer GetServer(IPAddress host, int port)
    {
        throw new NotImplementedException();
    }

    public IServer GetServer(EndPoint endpoint, object? asyncState = null)
    {
        throw new NotImplementedException();
    }

    public IServer[] GetServers()
    {
        throw new NotImplementedException();
    }

    public string GetStatus()
    {
        throw new NotImplementedException();
    }

    public void GetStatus(TextWriter log)
    {
        throw new NotImplementedException();
    }

    public string? GetStormLog()
    {
        throw new NotImplementedException();
    }

    public ISubscriber GetSubscriber(object? asyncState = null)
    {
        throw new NotImplementedException();
    }

    public int HashSlot(RedisKey key)
    {
        throw new NotImplementedException();
    }

    public long PublishReconfigure(CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public Task<long> PublishReconfigureAsync(CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public void RegisterProfiler(Func<ProfilingSession?> profilingSessionProvider)
    {
        throw new NotImplementedException();
    }

    public void ResetStormLog()
    {
        throw new NotImplementedException();
    }

    public void Wait(Task task)
    {
        throw new NotImplementedException();
    }

    public T Wait<T>(Task<T> task)
    {
        throw new NotImplementedException();
    }

    public void WaitAll(params Task[] tasks)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}
