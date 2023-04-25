using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float smoothFollow = 0.125f;

    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 playerFollow = player.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 fixedDirection = player.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, fixedDirection, smoothFollow);
        transform.position = smoothedPos;

        transform.LookAt(player);
    }
}
