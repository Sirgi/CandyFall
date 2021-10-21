using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPanel : MonoBehaviour
{
    [SerializeField] private Color[] _colors;
    
    private Color _currentColor;
    private int _currentColorIndex = 0;
    public int CurrentColorIndex { get {return _currentColorIndex;} private set{_currentColorIndex=value;}}

    private Image _image;

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
