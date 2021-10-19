using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : Item
{
    private Color _color;
    public Color Color{get {return _color;}private set{_color=value;}}

    private void Awake()
    {
        _color=ColorPanel.GetRandomColor() ;
        GetComponent<SpriteRenderer>().color=_color;
    }

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
    }
}
