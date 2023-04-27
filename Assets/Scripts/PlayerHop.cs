using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHop : MonoBehaviour
{
    public GameObject[] boardTiles;
    public GameObject Player;

    public float speed = 3;
    public static PlayerHop instance;

    //public int numberOfJump;
    //public int currentIndex;
    
    void Start()
    {
        boardTiles = GameObject.FindGameObjectsWithTag("Tiles");
    }

    private void Awake()
    {
        instance = this;
    }

    public void GoToTile(int num)
    {
        Debug.Log("Is now Processing");
        for (int i = 0; i < num; i++)
        {
            if (i< num)
            {
                StartCoroutine(Jump(num));
            }
        }
    }

    IEnumerator Jump(int numberOfJump)
    {
        Vector3 tileDestination = boardTiles[numberOfJump].transform.position;
        while (Vector3.Distance(Player.transform.position, tileDestination) > 0.1f)
        {
            Player.transform.position = Vector3.Lerp(Player.transform.position, tileDestination, speed * Time.deltaTime);
            yield return null;
        }
    }
}
