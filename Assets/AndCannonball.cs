using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndCannonball : MonoBehaviour
{
    //This goes on the boat
    
    [Header("Cannonball")]
    public float firerate = 0.9f;
    public float cooldown = 1;
    public float setCooldown = 1;
    public float spread = 5f;
    public GameObject cannonballPrefab;

    public Transform point;
   

    // Update is called once per frame
    void Update()
    {

        cooldown -= Time.deltaTime;


        if (Input.GetButton("Fire1"))
        { 
           if (cooldown <= 0)          
           {
                Debug.Log("Yeuch");
                BoomBoom();
                cooldown = setCooldown;
           }
        }
    }
    private void BoomBoom()
    {
        Instantiate(cannonballPrefab, point.position, point.rotation);
    }
}
