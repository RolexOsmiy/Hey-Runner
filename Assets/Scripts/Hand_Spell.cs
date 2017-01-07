using UnityEngine;
using System.Collections;

public class Hand_Spell : MonoBehaviour {

	public bool gravity;
	public bool teleport;
	public bool fireball = true;
	float shootCount;
	public float timeToShoot = 0.5f;
	public GameObject fireballPrefab;
	public GameObject teleportPrefab;
	public Transform spawn;
	// Use this for initialization
	void Start () 
	{
		shootCount = 0;
		timeToShoot = 0.5f;
	}

	void Update () 
	{
		shootCount += 1 * Time.deltaTime;
		if (Input.GetMouseButton (0) && gravity == true) 
		{
			Physics.gravity = new Vector3 (0, 1f, 0);
		} 
		else 
		{
			Physics.gravity = new Vector3 (0, -4f, 0);
		}

		if (Input.GetMouseButton (0) && fireball == true && shootCount >= timeToShoot) 
		{
			Instantiate(fireballPrefab, spawn.transform.position, spawn.transform.rotation);
			shootCount = 0;
		}

		if (Input.GetMouseButton (0) && teleport == true && shootCount >= timeToShoot) 
		{
			Instantiate(teleportPrefab, spawn.transform.position, spawn.transform.rotation);
			shootCount = 0;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "GravitySpell")
		{
			gravity = true;
			teleport = false;
			fireball = false;
		}
		if (other.gameObject.tag == "TeleportSpell")
		{
			gravity = false;
			teleport = true;
			fireball = false;
		}
		if (other.gameObject.tag == "FireBallSpell")
		{
			gravity = false;
			teleport = false;
			fireball = true;
		}
	}
}
