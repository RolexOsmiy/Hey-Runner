using UnityEngine;
using System.Collections;

public class RotateCameraScript : MonoBehaviour {

	public float rotateSpeed = 20;
	public Vector3 target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.RotateAround(target, Vector3.up, rotateSpeed * Time.deltaTime);
	}
}
