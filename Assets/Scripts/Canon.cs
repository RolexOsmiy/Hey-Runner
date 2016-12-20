using UnityEngine;
using System.Collections;

public class Canon : MonoBehaviour {

    public GameObject fireBall;
    public float waitTime = 3;

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("Spawn", waitTime, waitTime);
    }
	
	// Update is called once per frame
	void Spawn ()
    {
        Instantiate(fireBall, transform.position, transform.rotation);
    }
}
