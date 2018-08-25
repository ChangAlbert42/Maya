using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_chair : MonoBehaviour {
	bool chair_out = false; 

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void move_chair()
	{
		if (chair_out) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 5);
		} else {
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z - 5);
		}

	}

	void OnTriggerStay()
	{

		if (Input.GetKey (KeyCode.E)) {
			if (chair_out) {
				chair_out = false;
				move_chair ();
			} else {
				chair_out = true;
				move_chair ();
			}
		}


	}
}
