using UnityEngine;
using System.Collections;

public class PlayerMotion : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("up")) {
			transform.position += transform.forward * 0.3f;
		}
		if (Input.GetKey("right")) {
			transform.Rotate(0, 10, 0);
		}
		if (Input.GetKey ("left")) {
			transform.Rotate(0, -10, 0);
		}
		if (Input.GetKey ("down")) {
			transform.position -= transform.forward * 0.1f;
		}
	}
}
