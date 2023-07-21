using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rd;
    public float forwardForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rd.AddForce(0, 0, forwardForce* Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rd.AddForce(500*Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("a"))
        {
            rd.AddForce(-500 * Time.deltaTime, 0, 0);
        }
    }
}
