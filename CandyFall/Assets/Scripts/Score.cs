using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Score : MonoBehaviour
{
    public event Action OnValueChanged;
    public event Action OnAchievedMaxScore;

    private int _value =0;
    [SerializeField] private int _winValue = 0;

    public int Value
    {
        get
        {
            return _value;
        }
        set
        {
            _value=value;
            OnValueChanged?.Invoke();
            if(_value==_winValue)
            {
                OnAchievedMaxScore?.Invoke();
            }
        }
    }
    public int WinValue{get {return _winValue;}private set {_winValue=value;}}
}
