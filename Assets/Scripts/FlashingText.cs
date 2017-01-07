﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FlashingText : MonoBehaviour {

	public float timer;
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;

		if(timer >= 0.5)
		{
			GetComponent<Text> ().enabled = true;
		}

		if(timer >= 1)
		{
			GetComponent<Text> ().enabled = false;
			timer = 0;
		}
	}
}