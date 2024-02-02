using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct SODataTypeEnumComparer : IEqualityComparer<SODataType>
{
    public bool Equals(SODataType x, SODataType y)
    {
        return x == y;
    }
    public int GetHashCode(SODataType obj)
    {
        return (int)obj;
    }
}

public enum SIDE
{
    ALLY,
    ENEMY
}

public enum AnimState
{
    Idle,
    Move,
    Attack,
    Hit,
    Die
}