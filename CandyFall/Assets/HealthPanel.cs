using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPanel : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private float _offset = 1f;
    [SerializeField] private GameObject _image;
    [SerializeField] private GameObject[] sections = new GameObject[10];

    private void Start()
    {
        Transform transform = GetComponent<Transform>();
        for(int i=0;i<_playerHealth.Value;i++)
        {
            sections[i]=Instantiate(_image,i*_offset*Vector2.left,Quaternion.identity);
            sections[i].GetComponent<Transform>().SetParent(transform, false);
        }
    }
}
