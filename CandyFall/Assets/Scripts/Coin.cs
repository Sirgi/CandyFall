using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : Item
{
    private Color[] _colors ={Color.blue,Color.green,Color.yellow,Color.red};
    private Color _color;
    private SpriteRenderer _image;
    public Color Color{get {return _color;}private set{_color=value;}}

    private void Awake()
    {
        _image=GetComponent<SpriteRenderer>();
        _color=_colors[Random.Range(0,_colors.Length-1)];
        _image.color=_color;
    }

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
    }
}
