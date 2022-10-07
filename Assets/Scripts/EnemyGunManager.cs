using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunManager : MonoBehaviour
{
    //Bullet
    public GameObject bullet;

    //Bullet Force
    public float shootForce;
    public float upwardForce;

    //Gun Stats
    public float timeBetweenShoting;
    public float spread;
    public float reloadTime;
    public float timeBetweenShots;

    public int maganizeSize;
    public int bulletPerTap;
    public bool allowButtonHold;

    private int bulletsLeft;
    private int bulletsShot;

    public bool shooting;
    private bool readyToShoot;
    private bool reloading;

    public Transform attackPoint;

    PlayerControls controls;

    private void Awake()
    {
        //Make sure magazine is full
        bulletsLeft = maganizeSize;
        readyToShoot = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (readyToShoot)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        readyToShoot = false; //OBS THIS ONE MIGHT BE NEEDED!

        //Creates some time between shots
        Invoke("ResetShot", timeBetweenShoting);

        //Spawns the bullet/projectile at the attackPoint
        GameObject currentBullet = Instantiate(bullet, attackPoint.transform.position, attackPoint.transform.rotation);

        //Adds forces to the bullet 
        currentBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce);
        currentBullet.GetComponent<Rigidbody>().AddForce(transform.up * upwardForce);

        bulletsLeft--;
        bulletsShot++;

        // If more that one bulletsPerTap then repeat the shoot function
        if (bulletsShot < bulletPerTap && bulletsLeft > 0)
            Invoke("Shoot", timeBetweenShots);


    }

    private void ResetShot()
    {
        readyToShoot = true;
    }
}
