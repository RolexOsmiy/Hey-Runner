﻿using UnityEngine;
using System.Collections;

public class RotateSpellObject : MonoBehaviour {

	public float speed = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (0, speed * Time.deltaTime, 0);
	}
}
