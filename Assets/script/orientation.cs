using UnityEngine;
using System.Collections;

public class orientation : MonoBehaviour {

	private Quaternion localRotation;
	private bool dirLeft = true;

	// Use this for initialization
	void Start () {
		localRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		
		if ((dirLeft == true && Input.acceleration.x > localRotation.z) || (dirLeft == false && Input.acceleration.x < localRotation.z))
		{
			localRotation.z = Input.acceleration.x;
			transform.rotation = localRotation;
		}
		else if ((dirLeft == true && Input.acceleration.x < localRotation.z - 0.05f) || (dirLeft == false && Input.acceleration.x > localRotation.z + 0.05f))
		{
			dirLeft = !dirLeft;
			localRotation.z = Input.acceleration.x;
			transform.rotation = localRotation;
		}	 
	}
}
