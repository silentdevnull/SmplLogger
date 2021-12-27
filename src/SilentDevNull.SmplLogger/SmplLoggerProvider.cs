namespace SilentDevNull.SmplLogger;

public class SmplLoggerProvider : ILoggerProvider
{
    private readonly ConcurrentDictionary<string, SmplLogger> _loggers = new();
    
    public SmplLoggerProvider()
    {
    }

    public SmplLoggerProvider(EventHandler onCreateLogger)
    {
        OnCreateLogger = onCreateLogger;
    }
    public event EventHandler OnCreateLogger = delegate { };
    
    public ILogger CreateLogger(string categoryName) =>
        _loggers.GetOrAdd(categoryName, name => new SmplLogger(name));

    public void Dispose()
    {
        _loggers.Clear();
    }
}