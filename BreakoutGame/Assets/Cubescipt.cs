using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cubescipt : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "P1ball")
        {
            Destroy(gameObject);
            GameObject.Find("GC").GetComponent<GameController>().cubenum++;
            if (GameObject.Find("GC").GetComponent<GameController>().cubenum == 45)
            {
                GameObject.Find("GC").GetComponent<GameController>().ShowResult();
            }
            else
            {
                GameObject.Find("GC").GetComponent<GameController>().P1Score++;
            }
            GameObject.Find("P1Text").GetComponent<Text>().text = GameObject.Find("GC").GetComponent<GameController>().P1Score.ToString();
        }
        if (collision.gameObject.name == "P1ball(Clone)")
        {
            Destroy(gameObject);
            GameObject.Find("GC").GetComponent<GameController>().cubenum++;
            if (GameObject.Find("GC").GetComponent<GameController>().cubenum == 45)
            {
                GameObject.Find("GC").GetComponent<GameController>().ShowResult();
            }
            else
            {
                GameObject.Find("GC").GetComponent<GameController>().P1Score++;
            }
            GameObject.Find("P1Text").GetComponent<Text>().text = GameObject.Find("GC").GetComponent<GameController>().P1Score.ToString();
        }
        if (collision.gameObject.name == "P2ball")
        {
            Destroy(gameObject);
            GameObject.Find("GC").GetComponent<GameController>().cubenum++;
            if (GameObject.Find("GC").GetComponent<GameController>().cubenum == 45)
            {
                GameObject.Find("GC").GetComponent<GameController>().ShowResult();
            }
            else
            {
                GameObject.Find("GC").GetComponent<GameController>().P2Score++;
            }
            GameObject.Find("P2Text").GetComponent<Text>().text = GameObject.Find("GC").GetComponent<GameController>().P2Score.ToString();
        }
        if (collision.gameObject.name == "P2ball(Clone)")
        {
            Destroy(gameObject);
            GameObject.Find("GC").GetComponent<GameController>().cubenum++;
            if (GameObject.Find("GC").GetComponent<GameController>().cubenum == 45)
            {
                GameObject.Find("GC").GetComponent<GameController>().ShowResult();
            }
            else
            {
                GameObject.Find("GC").GetComponent<GameController>().P2Score++;
            }
            GameObject.Find("P2Text").GetComponent<Text>().text = GameObject.Find("GC").GetComponent<GameController>().P2Score.ToString();
        }
    }
}
