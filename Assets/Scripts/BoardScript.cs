using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScript : MonoBehaviour
{
    [SerializeField] public BoardTiles[] _bt;

    // Start is called before the first frame update
    void Start()
    {
        _bt = GetComponentsInChildren<BoardTiles>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
