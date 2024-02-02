using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ProjectUtil
{
    
}

public static class RandomUtil
{
    private static readonly System.Random _random = new System.Random(System.DateTime.Now.Millisecond);

    public static T GetRandomListItem<T>(List<T> list)
    {
        return list[_random.Next(0, list.Count)];
    }
}