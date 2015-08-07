using System;
using UnityEngine;
using System.Collections;



public partial class XLog {
    public enum XLogLevel
    {
        Debug,
        Info,
        Warn,
        Error,
    }

    private XLogLevel LogLevel;

    public XLog(XLogLevel logLevel = XLogLevel.Warn)
    {
        LogLevel = logLevel;
    }

    public void Log(XLogLevel level, string msg, params object[] args)
    {
        if (level >= LogLevel)
        {
            var fmsg = string.Format("<{0}> {1}\n", DateTime.Now.ToString("HH:mm:ss"), string.Format(msg, args));
            InnerLog(level, fmsg);
        }
    }

    public void Debug(string msg, params object[] args)
    {
        Log(XLogLevel.Debug, msg, args);
    }

    public void Info(string msg, params object[] args)
    {
        Log(XLogLevel.Info, msg, args);
    }

    public void Warn(string msg, params object[] args)
    {
        Log(XLogLevel.Warn, msg, args);
    }

    public void Error(string msg, params object[] args)
    {
        Log(XLogLevel.Error, msg, args);
    }
}
