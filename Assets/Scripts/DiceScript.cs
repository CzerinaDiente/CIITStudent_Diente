using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 initialPos;
    bool hasLanded;
    bool thrown;
    int diceValue;

    [SerializeField] DiceSide[] _ds;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPos = transform.position;
        _ds = GetComponentsInChildren<DiceSide>();

        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RollDice();
        }

    }

    void RollDice()
    {
        if (!thrown && !hasLanded)
        {
            thrown = true;
            rb.useGravity = true;

            rb.AddTorque(Random.Range(25, 100), Random.Range(25, 100), Random.Range(25, 100));
        }

        else if (thrown && hasLanded)
        {
            Reset();
        }
    }

    void Reset()
    {
        transform.position = initialPos;
        thrown = false;
        hasLanded = false;
        rb.useGravity = false;
        rb.isKinematic = false;
    }
}