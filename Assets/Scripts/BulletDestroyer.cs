using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
    public float Delay = 2;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, Delay);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
