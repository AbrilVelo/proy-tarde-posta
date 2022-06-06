using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    private bool lastDir;
    private SpriteRenderer sr;
  
     void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
     void Update()
    {
        UpdateDirection();
    }

    private void UpdateDirection()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            sr.flipX = false;
            lastDir = false;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            sr.flipX = true;
            lastDir = true;
        }
        else sr.flipX = lastDir;
    }
}

   

