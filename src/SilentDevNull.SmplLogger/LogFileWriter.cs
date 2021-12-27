namespace SilentDevNull.SmplLogger;
public class LogFileWriter
{
    public LogFileWriter()
    {
    }

    public void Log(String logMsg)
    {
        Console.WriteLine($"Log message: \n\t {logMsg}");
        string fileName = string.Format($"log-{DateTime.Now:yyyy-MM-dd}.log");
        
        //using (StreamWriter wr = new StreamWriter(LogName, true))
        using StreamWriter wr = new StreamWriter(fileName, true);
        wr.WriteLine(logMsg);
        wr.Close();
    }
}