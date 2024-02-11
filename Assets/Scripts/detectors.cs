using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectors : MonoBehaviour
{

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        collision.gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 0, 255);
        Destroy(collision.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        collision.gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 0, 255);
        Destroy(collision.gameObject);

    }
}
