using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] items;
    [SerializeField] private Vector2[] positions;
    [SerializeField] private float _time = 1f;
    private Vector2 _generatorPosition;

    private void Awake()
    {
        _generatorPosition=GetComponent<Transform>().position;
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
