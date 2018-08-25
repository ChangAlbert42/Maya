using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bathroom_door : MonoBehaviour {
	public bool open = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void open_door()
	{

		if (open)
		{
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y + 90, transform.eulerAngles.z);	
			//transform.Rotate (0, -90, 0, Space.Self);
		} 
		else 
		{
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
			//transform.Rotate (0, 90, 0, Space.Self);
		}


	}

	void OnTriggerStay()
	{

		if (Input.GetKey (KeyCode.E)) {
			if (open) {
				open = false;
				open_door ();
			} else {
				open = true;
				open_door ();
			}
		}


	}

}
