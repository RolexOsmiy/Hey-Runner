using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class hp_object : MonoBehaviour {

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
			Application.LoadLevel(Application.loadedLevel);
        }
		if (transform.position.y <= -100)
			{
				hp = 0;
			}
	}

    public void TakeDamage (int damage)
    {
        hp -= damage;
    }
}
