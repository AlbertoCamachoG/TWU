using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        while (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        /*if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }*/
    }
    void Shoot()
    {
        //Shooting Logic
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}