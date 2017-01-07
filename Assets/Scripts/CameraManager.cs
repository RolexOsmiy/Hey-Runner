using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraManager : MonoBehaviour {

	public GameObject interfaceBar;
	public GameObject winLoseBar;
	public GameObject rotateCamera;
	public GameObject player;
	public Text timeRecord;
	public GameObject uiManager;
	public GameObject hightScore;
	public GameObject crosshair;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			rotateCamera.SetActive (true);
			winLoseBar.SetActive (true);
			hightScore.SetActive (true);
			player.SetActive (false);
			interfaceBar.SetActive (false);
			crosshair.SetActive (false);
			timeRecord.text = "Time: " + UIScript.time;
			Screen.lockCursor = false;
			Cursor.visible = true;
		}
	}
}
