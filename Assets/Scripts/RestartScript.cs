using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    private GameObject player;

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player");
        PlayerHealth health = player.GetComponent<PlayerHealth>();

        if (health.health <= 0)
        {
            RestartGame();

        }



    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene

    }

}
