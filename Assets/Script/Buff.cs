using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buff : MonoBehaviour
{
    private static Buff buff = null;
    public static Buff getInstance
	{
		get
        {
            return buff;
		}
	}

    private Buff() { }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnTriggerEnter(Collider other)
	{
        this.gameObject.SetActive(false);
	}
}
