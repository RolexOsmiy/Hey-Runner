using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Level_Manager : MonoBehaviour {

	int nextScene = SceneManager.GetActiveScene().buildIndex + 1;

	public void NextLevelButton()
    {
		SceneManager.LoadScene(nextScene);
    }

	public void RestartLevelButton()
	{
		Application.LoadLevel(Application.loadedLevel);
	}

	public void ExitLevelButton()
	{
		Application.LoadLevel(0);
	}

}
