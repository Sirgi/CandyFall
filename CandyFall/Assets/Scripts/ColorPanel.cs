using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPanel : MonoBehaviour
{
    [SerializeField] private Color[] _initialColors;
    private static Color[] _colors; 
    
    private Color _currentColor;
    private int _currentColorIndex = 0;

    private Image _image;

    public static Color GetRandomColor()
    {
        return _colors[Random.Range(0,_colors.Length-1)];
    }

    public Color ActiveColor
    {
        get
        {
            return _currentColor;
        }

        private set
        {
            _currentColor=value;
            _image.color=_currentColor;
        }
    }

    private void Awake()
    {   
        _colors=_initialColors;
        _image=GetComponent<Image>();
        _currentColorIndex=0;
        ActiveColor=_colors[_currentColorIndex];
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            _currentColorIndex--;
            if(_currentColorIndex<0)
            {
                _currentColorIndex=_colors.Length-1;
            }
            ActiveColor=_colors[_currentColorIndex];
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            _currentColorIndex++;
            if(_currentColorIndex>=_colors.Length)
            {
                _currentColorIndex=0;
            }
            ActiveColor=_colors[_currentColorIndex];
        }
    }


}
