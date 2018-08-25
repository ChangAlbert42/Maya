using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableparticle : MonoBehaviour {
	public ParticleSystem temp;
	bool active = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.B) )
		{
			if (active) {
				active = false;
				temp.Stop ();
			} else {
				active = true;
				temp.Play ();
			}

		}
	}
}
