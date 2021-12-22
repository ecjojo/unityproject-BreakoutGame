using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int P1Death = 0;
    public int P2Death = 0;
    public int P1Score = 0;
    public int P2Score = 0;
    public int cubenum = 0;

    public GameObject P1ballPrefabs;
    public GameObject P2ballPrefabs;
    public GameObject ResultMenu;

    public void SpwanP1ball()
    {
        Instantiate(P1ballPrefabs, new Vector3(0, -2, 0), Quaternion.identity);
    }
    public void SpwanP2ball()
    {
        Instantiate(P2ballPrefabs, new Vector3(0, 2, 0), Quaternion.identity);
    }

    public void ShowResult()
    {
        ResultMenu.SetActive(true);
        if (P2Death == 3)
        {
            GameObject.Find("ResultText").GetComponent<Text>().text = "P1 Win !";
        }
        else if (P1Death == 3)
        {
            GameObject.Find("ResultText").GetComponent<Text>().text = "P2 Win !";
        }
        if (cubenum== 45 & P1Score > P2Score)
        {
            GameObject.Find("ResultText").GetComponent<Text>().text = "P1 Win !";
        }
        else if (cubenum == 45 & P2Score > P1Score)
        {
            GameObject.Find("ResultText").GetComponent<Text>().text = "P2 Win !";
        }
    }
}