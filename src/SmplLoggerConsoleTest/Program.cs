using SilentDevNull.SmplLogger;
using Microsoft.Extensions.Logging;

using ILoggerFactory loggerFactory =
    LoggerFactory.Create(builder =>
        builder.AddSmplLogger());
ILogger<Program> logger = loggerFactory.CreateLogger<Program>();

logger.LogInformation("Test");
logger.LogDebug("test debug");
logger.LogError("Error");
logger.LogInformation("Test1");