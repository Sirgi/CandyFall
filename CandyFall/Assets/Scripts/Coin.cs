using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : Item
{
    [SerializeField] private int _colorIndex;
    public int ColorIndex{get {return _colorIndex;}private set{_colorIndex=value;}}

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
    }
}
