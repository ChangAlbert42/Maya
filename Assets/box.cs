using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour {


	// Use this for initialization
	void Start () {
		//gameObject.transform.position = new Vector3 (gameObject.transform.position.x + 20, gameObject.transform.position.y, gameObject.transform.position.z);
        //testing
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col)
	{
		gameObject.transform.position = new Vector3 (gameObject.transform.position.x + 20, gameObject.transform.position.y, gameObject.transform.position.z);
	}
}
