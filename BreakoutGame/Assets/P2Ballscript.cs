using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2Ballscript : MonoBehaviour
{
    void Start()
    {
        int RandX = Random.Range(-10, 10);
        int RandY = Random.Range(-10, 10);

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(RandX, RandY).normalized * 4;
    }

    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = rb.velocity.normalized * 5;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "TOPWALL")
        {
            GameObject.Find("GC").GetComponent<GameController>().P2Death++;
            Destroy(gameObject);
            if (GameObject.Find("GC").GetComponent<GameController>().P2Death == 3)
            {
                GameObject.Find("GC").GetComponent<GameController>().ShowResult();
            }
            else
            {
                GameObject.Find("GC").GetComponent<GameController>().SpwanP2ball();
            }
            GameObject.Find("P2life").GetComponent<Text>().text = GameObject.Find("GC").GetComponent<GameController>().P2Death.ToString();
        }
    }
}