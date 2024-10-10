using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    //private int totalEnemies;
    // Start is called before the first frame update
    void Start()
    {
        //totalEnemies = GameObject.FindGameObjectsWithTag("EnemyHitbox").Length;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Debug.Log("Enemies left: " + GameObject.FindGameObjectsWithTag("EnemyHitbox").Length);
        if (GameObject.FindGameObjectsWithTag("EnemyHitbox").Length == 0) {
            Debug.Log("Done");
        }
        */
        //if (totalEnemies < 0.5) {
        //    SceneManager.LoadScene("Scenes/EndScene");
        //}
    }

    /*
    public void enemyDead() {
        totalEnemies -= 1;
    }
    */
    private void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "PlayerBullet") {
			SceneManager.LoadScene("Scenes/EndScene");
		}
	}
}
