using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deparent : MonoBehaviour
{
    private Vector3 _localPos;
    private Quaternion _localRot;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	    if (Input.GetMouseButtonDown(0) && transform.parent != null)
	    {
	        _localPos = transform.localPosition;
	        _localRot = transform.localRotation;
	        var tempPos = transform.position;
	        var tempRot = transform.rotation;
	        transform.parent = null;
	        transform.position = tempPos;
	        transform.rotation = tempRot;
	    }

	    if (Input.GetMouseButtonDown(1) && transform.parent == null)
	    {
	        transform.parent = GameObject.Find("FirstPersonCharacter").transform;
	        transform.localPosition = _localPos;
	        transform.localRotation = _localRot;
	    }

    }
}
