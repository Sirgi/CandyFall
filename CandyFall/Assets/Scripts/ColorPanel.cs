using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPanel : MonoBehaviour
{
    [SerializeField] private Color[] _colors = {Color.blue,Color.green,Color.yellow,Color.red};
    private Color _activeColor;
    private int _activeColorIndex = 0;
    private Image _image;

    public Color ActiveColor
    {
        get
        {
            return _activeColor;
        }

        private set
        {
            _activeColor=value;
            _image.color=_activeColor;
        }
    }

    private void Awake()
    {   
        _image=GetComponent<Image>();
        _activeColorIndex=0;
        ActiveColor=_colors[_activeColorIndex];
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            _activeColorIndex--;
            if(_activeColorIndex<0)
            {
                _activeColorIndex=_colors.Length-1;
            }
            ActiveColor=_colors[_activeColorIndex];
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            _activeColorIndex++;
            if(_activeColorIndex>=_colors.Length)
            {
                _activeColorIndex=0;
            }
            ActiveColor=_colors[_activeColorIndex];
        }
    }


}
