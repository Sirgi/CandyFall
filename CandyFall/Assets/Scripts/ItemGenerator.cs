using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public event System.Action OnAchievedWinCounter;

    [SerializeField] private GameObject[] items;
    [SerializeField] private Vector2[] positions;
    [SerializeField] private int _counter=0;
    [SerializeField] private int _winCounter=0;
    [SerializeField] private float _time = 1f;
    private Vector2 _generatorPosition;
    [SerializeField] private Results _results;

    public int Counter
    {
        get
        {
            return _counter;
        }
        private set
        {
            _counter=value;
            if(_counter>=_winCounter)
            {
                OnAchievedWinCounter?.Invoke();
            }
        }
    }

    private void Awake()
    {
        _generatorPosition=GetComponent<Transform>().position;
        _results.OnGameEnded+=()=>Destroy(gameObject);
    }

    private void Start()
    {
        StartCoroutine(GenerateItems());
    }

    private IEnumerator GenerateItems()
    {
        while(true)
        {
            GenerateItem(items[Random.Range(0,items.Length)], _generatorPosition+positions[Random.Range(0,positions.Length)]);
            yield return new WaitForSecondsRealtime(_time);
        }
    }

    private void GenerateItem(GameObject gameObject, Vector2 position)
    {
        Instantiate(gameObject, position, Quaternion.identity);
    }
}
