using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float damage;
    public float lifeSpawn;
    public float bulletSize;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Deletes bullet after lifespan time
        DestoryAfterSeconds();


    }

    //Gives out bullets a lifespan, this plus the velocity of our bullet effectivly sets our range
    private void DestoryAfterSeconds()
    {
        Destroy(gameObject, lifeSpawn);
    }
    //If we ever want to increase the size of our bullets for a powerup 
    public void SizeOfTheBullet()
    {
        gameObject.transform.localScale = gameObject.transform.localScale * bulletSize;
    }


    // Checks if the bullet collides with the anything tagged "Player", easy changed to make into "enemy"
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Checks if it has object it has colided with had the int "PlayerHealth" and then reduces the health by the damadge of the bullet
            //collision.gameObject.GetComponent<PlayerHealth>().health -= damage;
            //This destorys the bullet
            Destroy(gameObject);
        }
    }
}
