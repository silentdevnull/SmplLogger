namespace SilentDevNull.SmplLogger;
/// <summary>
/// 
/// </summary>
public class SmplLogger : ILogger
{
    private readonly string _name = String.Empty;
    /// <summary>
    /// 
    /// </summary>
    public SmplLogger()
    {
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    public SmplLogger(string name)
    {
        _name = name;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="state"></param>
    /// <typeparam name="TState"></typeparam>
    /// <returns></returns>
    public IDisposable BeginScope<TState>(TState state) => default!;
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="logLevel"></param>
    /// <returns></returns>
    public bool IsEnabled(LogLevel logLevel) => true;
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="logLevel"></param>
    /// <param name="eventId"></param>
    /// <param name="state"></param>
    /// <param name="exception"></param>
    /// <param name="formatter"></param>
    /// <typeparam name="TState"></typeparam>
    public void Log<TState>(
        LogLevel logLevel,
        EventId eventId,
        TState state,
        Exception? exception,
        Func<TState, Exception, string> formatter)
    {
        #if(DEBUG)
        Console.WriteLine(_name);
        Console.WriteLine($"LogLevel: {logLevel} EventId: {eventId} State: {state} exception: {exception}");
        #endif
        var log = string.Format($"{logLevel}\t{eventId}\t{state}\t{exception}");
        Console.WriteLine(log);
        LogFileWriter logFileWriter = new LogFileWriter();
        logFileWriter.Log(log);
        //logFileWriter.Log(logLevel,eventId,state,exception);
    }
}
