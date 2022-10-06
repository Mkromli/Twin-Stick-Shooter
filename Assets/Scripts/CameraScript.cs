using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");

    }



    private void Update()
    {

        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 50, player.transform.position.z);
        transform.LookAt(player.transform.position);
    }

}
