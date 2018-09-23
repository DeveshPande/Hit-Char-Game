using UnityEngine;
using System.Collections;

public class Targetmove : MonoBehaviour {

	public enum motionDirections {Forward,left, Vertical,Backward,up,down};
	public motionDirections motionState = motionDirections.Forward;
	// Use this for initialization
	public float motionMagnitude = 3.0f;
	public float spinSpeed = 180.0f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		switch (motionState) {
		case motionDirections.Forward:
			gameObject.transform.Translate(Vector3.back * motionMagnitude*Time.deltaTime);
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
			break;
		case  motionDirections.Backward:
			gameObject.transform.Translate (Vector3.forward * motionMagnitude*Time.deltaTime);
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
			break;
		case motionDirections.left:
			gameObject.transform.Translate (Vector3.right * motionMagnitude*Time.deltaTime);
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
			break;
		case motionDirections.Vertical:
			gameObject.transform.Translate (Vector3.left  * motionMagnitude*Time.deltaTime);
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
			break;
		case motionDirections.up:
			gameObject.transform.Translate (Vector3.down  * motionMagnitude*Time.deltaTime);
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
			break;
		case motionDirections.down:
			gameObject.transform.Translate (Vector3.up  * motionMagnitude*Time.deltaTime);
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
			break;
		}
	}
}
