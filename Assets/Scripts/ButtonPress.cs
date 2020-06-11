using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Difference: " + (transform.rotation.eulerAngles - other.transform.rotation.eulerAngles));
        Debug.Log("player rotation: " + other.transform.rotation.eulerAngles);
        if (other.CompareTag("Player") && Input.GetKeyDown("E") && transform.rotation.eulerAngles - other.transform.rotation.eulerAngles == other.transform.rotation.eulerAngles)
        {
            Debug.Log("Guillotine activated");
        }
    }
}
