using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    private int _value =0;
    public int Value
    {
        get
        {
            return _value;
        }
        set
        {
            _value=value;
            _scoreText.text=_value.ToString();
        }
    }
}
