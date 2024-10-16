using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReset : MonoBehaviour
{   
    private void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "PlayerBullet") {
			string currentSceneName = SceneManager.GetActiveScene().name;
			SceneManager.LoadScene(currentSceneName);
		}
	}
}