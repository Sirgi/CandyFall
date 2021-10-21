using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private static GameObject _instance=null;
    private void Awake()
    {
        if(_instance==null)
        {
            _instance=gameObject;
        }
        else
        {
            if(_instance!=gameObject)
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
    }
}
