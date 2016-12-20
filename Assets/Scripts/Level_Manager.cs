using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour {

    public string level;
    int currentLevel = SceneManager.GetActiveScene().buildIndex;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(Win());
        }
    }

    IEnumerator Win()
    {
        yield return new WaitForSeconds(10);
        Application.LoadLevel(currentLevel + 1);
    }

}
