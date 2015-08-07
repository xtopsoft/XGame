using UnityEngine;
using System.Collections;

public partial class XLog  {

    internal void InnerLog(XLogLevel level, string msg)
    {
        switch (level)
        {
            case XLogLevel.Debug:
            case XLogLevel.Info:
                UnityEngine.Debug.Log(msg);
                break;
            case XLogLevel.Warn:
                UnityEngine.Debug.LogWarning(msg);
                break;
            case XLogLevel.Error:
                UnityEngine.Debug.LogError(msg);
                break;
        }
    }
}
