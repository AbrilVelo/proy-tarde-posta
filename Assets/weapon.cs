﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {
    public Transform firePoint;
    public GameObject bulletPrefab;

    private void Start()
    {
        
    }
    void Update ()
    {
      if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
	}
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}