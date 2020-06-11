using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsArmsOffset : MonoBehaviour
{

    public GameObject FpsController;
    private Vector3 _dif;

	// Use this for initialization
	void Start ()
	{
	    _dif = transform.position - FpsController.transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    if (_dif - (transform.position - FpsController.transform.position) != Vector3.zero)
	    {
	        transform.position = _dif - (transform.position - FpsController.transform.position);
        }
    }

    void LateUpdate()
    {
        
    }
}