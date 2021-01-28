using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float speed = 0.3f;
    float horizontalInput;
    float acceleration;
    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {
        setAcceleration();
        speed = speed + this.acceleration * Time.deltaTime;
        Debug.Log(speed);
        this.horizontalInput = Input.GetAxis("Horizontal");        
        this.transform.Translate(Vector3.right * horizontalInput * speed);
    }

    void setAcceleration()
	{
        if (Input.GetKey("a") || Input.GetKey("d"))
        {
            this.acceleration = 2.0f;
        }        

        else
            this.speed = 0.3f;
	}
}
