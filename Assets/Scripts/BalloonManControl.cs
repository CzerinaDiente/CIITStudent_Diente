using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonManControl : MonoBehaviour
{
    private CharacterController controller;
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, moveSpeed);

        controller.Move(move * Time.deltaTime * moveSpeed);
    }
}
