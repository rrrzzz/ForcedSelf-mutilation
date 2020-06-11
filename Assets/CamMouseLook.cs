using UnityEngine;

public class CamMouseLook : MonoBehaviour
{
    public float Sensitivity = 5;
    public float Smoothing = 2;
    
    private Vector2 _mouseLook;
    private Vector2 _smoothV;

    private GameObject _character;

	// Use this for initialization
	void Start ()
	{
	    _character = transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	    var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

	    md = Vector2.Scale(md, new Vector2(Sensitivity * Smoothing, Sensitivity * Smoothing));
	    _smoothV.x = Mathf.Lerp(_smoothV.x, md.x, 1f / Smoothing);
	    _smoothV.y = Mathf.Lerp(_smoothV.y, md.y, 1f / Smoothing);
	    _mouseLook += _smoothV;

	    _mouseLook.y = Mathf.Clamp(_mouseLook.y, -90f, 90f);

        transform.localRotation = Quaternion.AngleAxis(-_mouseLook.y, Vector3.right);
	    _character.transform.localRotation = Quaternion.AngleAxis(_mouseLook.x, _character.transform.up);
	}
}
