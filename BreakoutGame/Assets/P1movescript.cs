using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1movescript : MonoBehaviour
{
    void Update()
    {
        float p1move = Input.GetAxis("Horizontal2");
        Debug.Log(p1move);

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(p1move * 10,0);

    }
}

