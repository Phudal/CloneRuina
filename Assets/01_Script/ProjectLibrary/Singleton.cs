using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    protected static T m_Instance = null;
    private static object _lock = new object();

    public static T Instance
    {
        get
        {
            lock (_lock)
            {
                if (null == m_Instance)
                {
                    GameObject obj = new GameObject(typeof(T).Name);
                    m_Instance = obj.AddComponent(typeof(T)) as T;
                }

                return m_Instance;
            }
        }
    }
    public SingletonMonoBehaviour()
    {
        if (m_Instance == null)
        {
            m_Instance = this as T;
        }
    }


    protected virtual void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    protected virtual void OnDestroy()
    {
        m_Instance = null;
    }

    protected virtual void OnApplicationQuit()
    {
        m_Instance = null;
    }
}