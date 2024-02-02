using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine;

public class Logger : MonoBehaviour
{
    public enum LOG
    {
        [Description("LOG")] eLC_None = 0,        // �⺻ �α�
        [Description("REQ")] eLC_Reqest = 1,      // ������ ���� ��Ŷ�α�
        [Description("RES")] eLC_Response = 2,    // �������� ���� ��Ŷ�α�
        [Description("PUSH")] eLC_Push = 3,        // Ǫ�� �α�
        [Description("ERR")] eLC_Error = 4,       // ���� �α�
        [Description("EMIT")] eLC_Emit = 5,        // Ǫ�� Emit
        [Description("DATA")] eLC_Highlight = 6,   // ���� �α�
        [Description("NET")] eLC_Network = 7,     // ��Ʈ��ũ �α�
        [Description("WAN")] eLC_Warning = 8,     // ��� �α�
        [Description("TIMER")] eLC_LoadTimer = 9,   // �ε� Ÿ�̸�
        [Description("INFO")] eLC_Infomation = 10, // ���� �α�
        [Description("SDK")] eLC_SDK = 11,        // SDK �α�

        eLC_MAX = 12,
    };

    // ��Ŷ �α��Ͽ� ���� �÷� ǥ�ÿ�
    public static string[] colors = new string[]
    {
            "FFFFFF", // white          (0)        �Ϲ� �α�
            "FF00FF", // magenta        (1)		   ������ ���� ��Ŷ�α�			
            "00DDDD", // cyan           (2)		   �������� ���� ��Ŷ�α�
            "ADD8E6", // lightblue      (3)	       Ǫ�� �α�
            "DD0000", // Dark red       (4)        ���� �α�
            "FFA500", // orange         (5)        Ǫ�� Emit
            "A09FF9", // Dark yellow    (6)        ���� �α�
            "589445", // lime           (7)        ��Ʈ��ũ �α�
            "FFFF00", // Yellow         (8)        ��� �α�
            "008000", // green          (9)        �ε� Ÿ�̸�
            "F15F5F", // teal           (10)       ���� �α�
            "FAE101", // yellow for kakao(11)      SDK �α�
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
