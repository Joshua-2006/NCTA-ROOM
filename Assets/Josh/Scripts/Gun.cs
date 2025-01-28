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

    private void Start()
    {
        ammo = 0;
    }
    private void Update()
    {
    }

    public void Shoot()
    {
        canShoot = true;
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
}
