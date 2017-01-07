using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {

    public Text hpBar;
	public GameObject timeBar;
	public static float time; 
	public GameObject info;
    GameObject player;

	void Awake()
	{
		Time.timeScale = 0;

	}

    void Start ()
    {
		time = 0;
        player = GameObject.FindWithTag("Player");
	}
	
	void Update ()
    {
		if (Input.GetKey(KeyCode.E))
		{
			Time.timeScale = 1;
			info.SetActive (false);
			timeBar.SetActive (true);
		}

		if (Input.GetKey(KeyCode.R))
		{
			Application.LoadLevel(Application.loadedLevel);
		}

        UIScript.time += Time.deltaTime;
		hpBar.text = "HP: "+(player.GetComponent<hp_object>().hp);
		timeBar.GetComponent<Text>().text = "Time: " + time.ToString("#.00");

		if (player.GetComponent<hp_object>().hp < 1)
        {
			player.GetComponent<hp_object>().hp = 0;
        }
	}
}
