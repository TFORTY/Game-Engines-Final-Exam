using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody2D rb;
    Vector2 screenBounds;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-moveSpeed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        /*if (transform.position.x < screenBounds.x)
        {
            //Destroy(gameObject);
            //ObjectPool.Instance.AddToPool(gameObject);
        }*/
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}