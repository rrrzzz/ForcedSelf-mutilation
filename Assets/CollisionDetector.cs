using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class CollisionDetector : MonoBehaviour
{

    private FirstPersonController _fpsScript;
	// Use this for initialization
	void Start ()
	{
	    _fpsScript = GetComponentInParent<FirstPersonController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collided!");
    }
}
