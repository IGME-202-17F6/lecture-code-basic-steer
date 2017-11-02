using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Look at how clean and simple this guy is!
// All the complexity is handled by Mover
// And we can focus on just what's different about our Arriver
public class Arriver : Mover {

	public GameObject target;
	public float threshold = 2f;

	protected override void Start () {
		base.Start ();
	}

	protected override void CalcSteering() {
		if (target) {
			// the next line is a fancy toggle comment ... make it read //* instead of /* and see what happens
			/*
			ApplyForce (Arrive (target.transform.position, threshold));
			/*/
			velocity += Arrive (target.transform.position, threshold, radius + 0.5f);
			//*/
		}
	}
}
