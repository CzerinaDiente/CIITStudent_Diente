using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHop : MonoBehaviour
{
    public BoardTiles boardTiles;
    public BoardScript boardScript;

    public float speed;
    public int numberOfJump;
    public int currentIndex;

    public void GoToTile()
    {
        StartCoroutine(Jump());
    }

    public IEnumerator Jump()
    {
        int curJump = 0;
        while(curJump + 1 <= numberOfJump)
        {
            yield return new WaitForSeconds(0.5f);

            currentIndex++;
            if (currentIndex >= boardScript._bt.Length)
            {
                currentIndex = 0;
            }
            while (transform.position != boardScript._bt[currentIndex].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, boardScript._bt[currentIndex].transform.position, speed * Time.deltaTime);
                yield return null;
            }
        }
    }
}
