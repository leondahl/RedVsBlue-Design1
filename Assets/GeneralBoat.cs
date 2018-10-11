using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralBoat : MonoBehaviour
{
    [Header("General Boat Stats")]
    public int health;
    public float movementSpeed;

	void Update ()
    {
		if (health <= 0)
        {
            Destroy(gameObject);
        }
	}
}
