using UnityEngine;
using System.Collections;

public class DamageObject : MonoBehaviour {

    public int damage = 30;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<HPobject>().TakeDamage(damage);
        Debug.Log(other.GetComponent<HPobject>().hp);
    }
}
