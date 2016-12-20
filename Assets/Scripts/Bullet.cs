using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float timeToDie = 5;
    public float speed;

    // Use this for initialization
    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(timeToDie <= 0)
        {
            Destroy(this.gameObject);
        }
        timeToDie -= 1 * Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}
