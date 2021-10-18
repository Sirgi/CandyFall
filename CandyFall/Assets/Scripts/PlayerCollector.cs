using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollector : MonoBehaviour
{
    [SerializeField] private Score _score;
    [SerializeField] private ColorPanel _colorPanel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if((collision.gameObject.tag=="Coin") && (collision.gameObject.GetComponent<SpriteRenderer>().color==_colorPanel.ActiveColor))
        {
            _score.Value+=1;
        }
    }
}
