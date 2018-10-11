using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootyCannonball : MonoBehaviour
{

    public Rigidbody2D cannonballBody;
    [Range(0.1f, 1f)]
    public float speed;
    [Range(0.1f, 10f)]
    public float constantSpeed = 10f;

    void Update()
    {
        cannonballBody.velocity = constantSpeed * transform.right; 
    }
}
