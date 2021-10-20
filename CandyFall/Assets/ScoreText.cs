using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private Score _score;
    [SerializeField] private Text _scoreText;

    private void Awake()
    {
        UpdateInfo();
        _score.OnValueChanged+=UpdateInfo;
    }
    private void UpdateInfo()
    {
        _scoreText.text=_score.Value.ToString()+"/"+_score.WinValue.ToString();
    }   
}
