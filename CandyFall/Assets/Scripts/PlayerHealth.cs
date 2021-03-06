using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerHealth : MonoBehaviour
{
    public event Action<int> OnHealthChanged;
    public event Action OnLost;

    [SerializeField] private int _maxValue = 1;
    private int _value;

    public int Value
    {
        get
        {
            return _value;
        }
        set
        {
            value=Mathf.Max(0,value);
            if(_value!=value)
            {
                _value=value;
                OnHealthChanged?.Invoke(_value);
                if(_value==0)
                {
                    OnLost?.Invoke();
                }
            }
            
        }
    }

    private void Awake()
    {
        _value=_maxValue;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Bomb")
        {
            Value=0;
        }
    }
}
