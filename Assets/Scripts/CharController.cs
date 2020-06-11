using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{

    public float Speed = 10;

	// Use this for initialization
	void Start ()
	{
	    Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float translation = Input.GetAxis("Vertical") * Speed;
	    float strafe = Input.GetAxis("Horizontal") * Speed;
	    translation *= Time.deltaTime;
	    strafe *= Time.deltaTime;

        transform.Translate(strafe, 0, translation);

	    if (Input.GetKeyDown("escape")) Cursor.lockState = CursorLockMode.None;
	}
}
