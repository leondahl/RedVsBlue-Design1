using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralBoat : MonoBehaviour
{
    [Header("General Boat Stats")]
    public int health;
    public float firerate;
    public float cooldown;
    public float setCooldown;
    public float spread;
    public float movementSpeed;

	void Update ()
    {
		if (health <= 0)
        {
            Destroy(gameObject);
        }
	}
}
