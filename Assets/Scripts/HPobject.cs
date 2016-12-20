using UnityEngine;
using System.Collections;

public class HPobject : MonoBehaviour {

    public float hp = 100;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(hp < 1)
        {
            //Destroy(this.gameObject);
        }
	}

    public void TakeDamage (int damage)
    {
        hp -= damage;
    }
}
