using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject stick;
    public float speed = 1000;
    float horizontalInput;
    Vector3 velocity;
    Vector3 stick_initialposition;

    private void Start()
    {
        this.stick_initialposition = this.stick.transform.position;
        this.velocity = new Vector3();
    }
    void FixedUpdate()
    {
        this.velocity.Set(this.speed * Time.fixedDeltaTime * Input.GetAxis("Horizontal"), 0, 0);
        this.GetComponent<Rigidbody>().velocity = this.velocity;
        Debug.Log(this.GetComponent<Rigidbody>().velocity);

        if (this.stick.transform.position.y < -5)
        {
            this.stick.transform.position = this.stick_initialposition;
            this.stick.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }

	private void OnCollisionEnter(Collision collision)
	{
        Buff bff = Buff.getInstance;
        bff.gameObject.SetActive(false);
	}
}
