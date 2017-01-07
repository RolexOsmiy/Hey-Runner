using UnityEngine;
using System.Collections;

public class TeleportScript : MonoBehaviour {

	public float forcePower = 1;
	Rigidbody rb;
	GameObject player;
	// Use this for initialization
	void Start () 
	{
		player = GameObject.Find ("Player");
		rb = GetComponent<Rigidbody>();
		rb.AddForce(transform.forward * forcePower); 
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnCollisionEnter(Collision collision)
	{
		player.transform.position = transform.position;
		Destroy (gameObject);
	}
}
