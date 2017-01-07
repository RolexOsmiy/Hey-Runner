using UnityEngine;
using System.Collections;

public class FireBallScript : MonoBehaviour {

	public float forcePower = 1;
	public float timeToDie = 5;
	Rigidbody rb;
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
		rb.AddForce(transform.forward * forcePower); 
	}
	
	// Update is called once per frame
	void Update () 
	{
		

		if(timeToDie <= 0)
		{
			Destroy(this.gameObject);
		}
		timeToDie -= 1 * Time.deltaTime;
	}
}
