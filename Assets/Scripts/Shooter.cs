using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject LeftMuzzle;
    public GameObject RightMuzzle;
    public GameObject Bullet;
    public int ForceMultiplier = 1000;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if (Input.GetMouseButtonDown(0))
	    {
	        SendProjectile(RightMuzzle);
	    }

	    if (Input.GetMouseButtonDown(1))
	    {
	        SendProjectile(LeftMuzzle);
	    }
    }

    void SendProjectile(GameObject muzzle)
    {

        Rigidbody projectile = Instantiate(Bullet, muzzle.transform.position, muzzle.transform.rotation).GetComponent<Rigidbody>();
        projectile.AddForce(muzzle.transform.forward * ForceMultiplier);
    }
}
