using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject cube1;
    RaycastHit hit;
    public LayerMask layer;
    public Rigidbody rb;
    Vector3 cubePos;
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 1000))
            {
                Debug.DrawLine(ray.origin, hit.point);
                if (hit.collider.gameObject.tag == "Cube2")
                {
                    cube1.transform.position = hit.transform.position - cube1.transform.position;
                    //cube1.transform.Translate(hit.transform.position - cube1.transform.position);
                    //rb.MovePosition(hit.transform.position - cube1.transform.position);
                    //rb.velocity = (hit.transform.position - cube1.transform.position) * Time.deltaTime;
                }
                if (hit.collider.gameObject.tag == "Cube3")
                {
                    cube1.transform.position = hit.transform.position - cube1.transform.position;
                    //cube1.transform.Translate(hit.transform.position - cube1.transform.position);
                    //rb.MovePosition(hit.transform.position - cube1.transform.position);
                    //rb.velocity = (hit.transform.position - cube1.transform.position) * Time.deltaTime;
                }
            }

        }
    }
}
