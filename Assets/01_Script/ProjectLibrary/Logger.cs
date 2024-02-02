using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine;

public class Logger : MonoBehaviour
{
    public enum LOG
    {
        [Description("LOG")] eLC_None = 0,        // 기본 로그
        [Description("REQ")] eLC_Reqest = 1,      // 서버로 보낸 패킷로그
        [Description("RES")] eLC_Response = 2,    // 서버에서 받은 패킷로그
        [Description("PUSH")] eLC_Push = 3,        // 푸시 로그
        [Description("ERR")] eLC_Error = 4,       // 에러 로그
        [Description("EMIT")] eLC_Emit = 5,        // 푸시 Emit
        [Description("DATA")] eLC_Highlight = 6,   // 강조 로그
        [Description("NET")] eLC_Network = 7,     // 네트워크 로그
        [Description("WAN")] eLC_Warning = 8,     // 경고 로그
        [Description("TIMER")] eLC_LoadTimer = 9,   // 로딩 타이머
        [Description("INFO")] eLC_Infomation = 10, // 정보 로그
        [Description("SDK")] eLC_SDK = 11,        // SDK 로그

        eLC_MAX = 12,
    };

    // 패킷 로그켓에 따른 컬러 표시용
    public static string[] colors = new string[]
    {
            "FFFFFF", // white          (0)        일반 로그
            "FF00FF", // magenta        (1)		   서버로 보낸 패킷로그			
            "00DDDD", // cyan           (2)		   서버에서 받은 패킷로그
            "ADD8E6", // lightblue      (3)	       푸시 로그
            "DD0000", // Dark red       (4)        에러 로그
            "FFA500", // orange         (5)        푸시 Emit
            "A09FF9", // Dark yellow    (6)        강조 로그
            "589445", // lime           (7)        네트워크 로그
            "FFFF00", // Yellow         (8)        경고 로그
            "008000", // green          (9)        로딩 타이머
            "F15F5F", // teal           (10)       정보 로그
            "FAE101", // yellow for kakao(11)      SDK 로그
            "800080", // purple
    };

    public Logger() { }
    public static void LogBasic(object msg) { Log(msg, LOG.eLC_None); }
    public static void LogReqest(object msg) { Log(msg, LOG.eLC_Reqest); }
    public static void LogResponse(object msg) { Log(msg, LOG.eLC_Response); }
    public static void LogPush(object msg) { Log(msg, LOG.eLC_Push); }
    public static void LogError(object msg) { Log(msg, LOG.eLC_Error); }
    public static void LogEmit(object msg) { Log(msg, LOG.eLC_Emit); }
    public static void LogData(object msg) { Log(msg, LOG.eLC_Highlight); }
    public static void LogNetwork(object msg) { Log(msg, LOG.eLC_Network); }
    public static void LogWarning(object msg) { Log(msg, LOG.eLC_Warning); }
    public static void LogTimer(object msg) { Log(msg, LOG.eLC_LoadTimer); }
    public static void LogInfomation(object msg) { Log(msg, LOG.eLC_Infomation); }
    public static void LogSDK(object msg) { Log(msg, LOG.eLC_SDK); }

    [Conditional("TRACE_ON")]
    [Conditional("UNITY_EDITOR")]
    public static void Log(object msg, LOG logcat = LOG.eLC_None)
    {
        string hexColor = (logcat >= LOG.eLC_MAX || logcat < LOG.eLC_None) ? colors[0] : hexColor = colors[(int)logcat];
        // string str = $"{Time.realtimeSinceStartup}\t<color=#{hexColor}><b>[{EnumUtil.GetEnumDescription(logcat)}]</b></color><color=#{hexColor}><b>{msg}</b></color>";

        switch (logcat)
        {
            case LOG.eLC_Warning:
                //UnityEngine.Debug.LogWarning(str);
                UnityEngine.Debug.LogWarning(msg);
                break;
            case LOG.eLC_Error:
                //UnityEngine.Debug.LogError(str);
                UnityEngine.Debug.LogError(msg);
                break;
            default:
                //UnityEngine.Debug.Log(str);
                UnityEngine.Debug.Log(msg);
                break;
        }
    }
}
