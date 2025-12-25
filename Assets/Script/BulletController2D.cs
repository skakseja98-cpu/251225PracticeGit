using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController2D : MonoBehaviour
{

    public float speed = 10f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.linearVelocity = transform.right * speed;

        Destroy(gameObject, 2f);
    }

    void Update()
    {
        
    }
}
