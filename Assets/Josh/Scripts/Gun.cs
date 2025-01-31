using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spawnpoint;
    public bool canShoot;
    public int ammo;
    public Timer time;

    private void Start()
    {
        
    }
    private void Update()
    {
        time = FindAnyObjectByType<Timer>();
        if(time.isRunning)
        {
            ammo = 10;
        }
        if(time!.isRunning)
        {
            ammo = 0;
        }

    }

    public void Shoot()
    {
        if (canShoot == true)
        ammo = 10;
        if(canShoot && ammo > 0)
        {
            Instantiate(bullet, spawnpoint.transform.position, spawnpoint.transform.rotation);
            ammo -= 1;
        }
    }
    public void DontShoot()
    {
        canShoot = false;
    }
    public void Reload()
    {
        ammo = 10;
    }
}
