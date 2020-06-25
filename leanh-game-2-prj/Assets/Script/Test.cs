using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Moves the GameObject using it's transform.
        rb.isKinematic = true;
    }

    void FixedUpdate()
    {
        // Moves the GameObject to the left of the origin.
        if (transform.position.x > 3.0f)
        {
            transform.position = new Vector3(-3.0f, 0.0f, 0.0f);
        }

        rb.MovePosition(transform.position + transform.right * Time.fixedDeltaTime);
    }
}
