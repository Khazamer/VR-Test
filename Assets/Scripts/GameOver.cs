using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{   
    private void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "EnemyHitbox") {
			//string currentSceneName = SceneManager.GetActiveScene().name;
			//SceneManager.LoadScene(currentSceneName);
			SceneManager.LoadScene("Scenes/StartScene");
	  	}
	}
}
