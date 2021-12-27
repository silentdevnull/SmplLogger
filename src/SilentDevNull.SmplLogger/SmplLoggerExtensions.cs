namespace SilentDevNull.SmplLogger;

public static class SmplLoggerExtensions
{
    public static ILoggingBuilder AddSmplLogger(this ILoggingBuilder builder)
    {
        builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<ILoggerProvider,SmplLoggerProvider>());
        return builder;
    }
}