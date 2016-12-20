using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {

    public Text hpBar;
    public Text timeBar;
    float time; 
    GameObject player;
    int currentLevel = Application.loadedLevel;
    void Start ()
    {
        player = GameObject.FindWithTag("Player");
	}
	
	void Update ()
    {
        time += Time.deltaTime;
        hpBar.text = "HP: "+(player.GetComponent<HPobject>().hp);
        timeBar.text = "Time: " + time.ToString("#.00");
        if (player.GetComponent<HPobject>().hp < 1)
        {
            player.GetComponent<HPobject>().hp = 0;
            StartCoroutine(Lose());
        }	
	}

    IEnumerator Lose()
    {
        yield return new WaitForSeconds(10);
        Application.LoadLevel(currentLevel + 1);
    }
}
