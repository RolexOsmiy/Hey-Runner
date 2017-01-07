using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {

	public static string playerName = "default";
	public Text inputField;
	public int playLevel = 1;

	public void ExitGameButton()
	{
		Application.Quit();
	}

	public void Play()
	{
		MainMenuScript.playerName = inputField.text;
		Application.LoadLevel(playLevel);
		Debug.Log (playerName);
	}
}
