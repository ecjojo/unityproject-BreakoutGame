using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2movescript : MonoBehaviour
{
    void Update()
    {
        float p2move = Input.GetAxis("Horizontal");
        Debug.Log(p2move);

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(p2move * 10, 0);

    }
}
