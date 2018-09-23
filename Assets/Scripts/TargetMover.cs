using UnityEngine;
using System.Collections;

public class TargetMover : MonoBehaviour {

	// define the possible states through an enumeration
	public enum motionDirections {Spin,Horizontal, Vertical};
	
	// store the state
	public motionDirections motionState = motionDirections.Horizontal;

	// motion parameters
	public float spinSpeed = 180.0f;
	public float motionMagnitude = 0.1f;
	//private Rigidbody rb;
	void start()
	{
		// rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		
		RaycastHit hit;
		int height = 5;
		Ray landingRay = new Ray (transform.position,Vector3.down);
		if (Physics.Raycast (landingRay, out hit, height)) {
			Physics.gravity = new Vector3 (0, 0, 0);
		} else {
			Physics.gravity = new Vector3 (0, -1, 0);
		}
		//Debug.DrawRay (transform.position,Vector3.down*height);
			
		//if (rb.useGravity) {
			
		//}
		// do the appropriate motion based on the motionState
		switch(motionState) {
			case motionDirections.Spin:
				// rotate around the up axix of the gameObject
				gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
				break;
			case motionDirections.Horizontal:
				// move up and down over time
				gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
				break;
			case motionDirections.Vertical:
				// move up and down over time
				gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
				break;
		}
	}
}
