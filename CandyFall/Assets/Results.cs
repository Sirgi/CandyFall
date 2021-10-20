using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Results : MonoBehaviour
{
    [SerializeField] private Score _score;
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private ItemGenerator _itemGenerator;
    [SerializeField] private GameObject _resultPanel;
    [SerializeField] private Text _resultText;
    [SerializeField] private Text _scoreText;
    private string _loseText= "You Lost!";
    private string _winText="You Won!";
    public event Action OnGameEnded;

    private void Awake()
    {
        _score.OnAchievedMaxScore+=WinGame;
        _itemGenerator.OnAchievedWinCounter+=WinGame;
        _playerHealth.OnLost+=LoseGame;
    }

    private void WinGame()
    {
        _resultText.text=_winText;
        EndGame();
        OnGameEnded?.Invoke();
    }

    private void LoseGame()
    {
        _resultText.text=_loseText;
        EndGame();
        OnGameEnded?.Invoke();
    }

    private void EndGame()
    {
        _scoreText.text="Score: "+_score.Value.ToString();
        _resultPanel.SetActive(true);
    }
}
