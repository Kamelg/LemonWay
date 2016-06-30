using log4net;
using log4net.Config;
using System;

/// <summary>
/// Description résumée de Logger
/// </summary>
public class Logger
{
    // On définit une variable logger static qui référence l'instance du logger nommé Program
    private static readonly ILog log = LogManager.GetLogger(typeof(Logger));

    public Logger()
    {
        XmlConfigurator.Configure();
    }

    public static void Error(Exception ex)
    {
        log.Error(ex.Message, ex);
    }

    public static void Error(string message)
    {
        log.Error(message);
    }

    public static void Debug(Exception ex)
    {
        log.Debug(ex.Message, ex);
    }

    public static void Debug(string message)
    {
        log.Debug(message);
    }

    public static void Info(string message)
    {
        log.Info(message);
    }

    public static void Info(Exception ex)
    {
        log.Info(ex.Message, ex);
    }
}