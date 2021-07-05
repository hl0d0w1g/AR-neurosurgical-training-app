using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolControl : MonoBehaviour
{

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Hello world");

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("a"))
        {
            rb.AddForce(2000 * Time.deltaTime, 0, 0);
        }

    }
}
