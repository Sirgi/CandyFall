using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "Player") || (collision.gameObject.tag == "Ground"))
        {
            Destroy(gameObject);
        }

    }
}
