using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float MovementSpeed = 2000f;
    public float Sideways = 200f;
    
    


    // Start is called before the first frame update
    /*
    void Start()
    {
    }
    */
    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(0, 0, MovementSpeed * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(Sideways * Time.deltaTime,0,0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-Sideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        /*
        if (rb.position.y < -0.5f)
        {
            FindObjectOfType<GameManager>().EndGame();

        }
        */
    }
    
}
