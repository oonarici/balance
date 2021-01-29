using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    float speed = 1000;
    float horizontalInput;
    Vector3 velocity;

    private void Start()
    {
        this.velocity = new Vector3();
    }
    void FixedUpdate()
    {
        this.velocity.Set(this.speed * Time.fixedDeltaTime * Input.GetAxis("Horizontal"), 0, 0);
        this.GetComponent<Rigidbody>().velocity = this.velocity;
        Debug.Log(this.GetComponent<Rigidbody>().velocity);
    }
}
