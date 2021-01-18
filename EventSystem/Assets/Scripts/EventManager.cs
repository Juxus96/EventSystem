using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager instance;

    private Dictionary<string, Action> voidAction; 
    private Dictionary<string, Action<int>> intAction;

    // Func only returns the last answer in it but executes all the code in the other answers
    private Dictionary<string, Func<int, bool>> intFuncBool;
    private void Awake()
    {
        CreateSingleton();
        voidAction = new Dictionary<string, Action>();
        intAction  = new Dictionary<string, Action<int>>();
        intFuncBool = new Dictionary<string, Func<int, bool>>();
    }

    #region Void Action
    public void SuscribeToEvent(string key, Action answer)
    {
        if(!voidAction.ContainsKey(key))
        {
            voidAction.Add(key, answer);
        }
        else
            voidAction[key] += answer;

    }

    public void UnsuscribeFromEvent(string key, Action answer)
    {
        if (voidAction.ContainsKey(key))
            voidAction[key] -= answer;
    }

    public void RaiseEvent(string key)
    {
        voidAction[key]?.Invoke();
    }
    #endregion

    #region Int Action
    public void SuscribeToEvent(string key, Action<int> answer)
    {
        if (!intAction.ContainsKey(key))
        {
            intAction.Add(key, answer);
        }
        else
            intAction[key] += answer;

    }

    public void UnsuscribeFromEvent(string key, Action<int> answer)
    {
        if (intAction.ContainsKey(key))
            intAction[key] -= answer;
    }

    public void RaiseEvent(string key, int i)
    {
        intAction[key]?.Invoke(i);
    }
    #endregion

    #region Int Func Bool
    public void SuscribeToEvent(string key, Func<int, bool> answer)
    {
        if (!intFuncBool.ContainsKey(key))
        {
            intFuncBool.Add(key, answer);
        }
        else
            intFuncBool[key] += answer;

    }

    public void UnsuscribeFromFuncEvent(string key, Func<int, bool> answer)
    {
        if (intFuncBool.ContainsKey(key))
            intFuncBool[key] -= answer;
    }

    public bool RaiseFuncEvent(string key, int i)
    {
        if (intFuncBool[key] != null)
            return intFuncBool[key](i);
        else
            return false;
    }

    #endregion
    private void CreateSingleton()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
    }
}
