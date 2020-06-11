using UnityEngine;

public class PullIn : MonoBehaviour
{
    public int Force;
    public GameObject ObjectToPull;
    public int SquareDistance;
    public bool Enabled;

    private Rigidbody _inputBody;

	// Use this for initialization
	void Start ()
	{
	    _inputBody = ObjectToPull.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
        var diffVector = transform.position - ObjectToPull.transform.position;
	    if (diffVector.sqrMagnitude < SquareDistance)
	    {
	        Debug.Log("Sucked in!");
	    }
	    _inputBody.AddForce(diffVector * Force);
	    
	}
}
