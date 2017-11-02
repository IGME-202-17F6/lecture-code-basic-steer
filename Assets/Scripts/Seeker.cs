using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Look at how clean and simple this guy is!
// All the complexity is handled by Mover
// And we can focus on just what's different about our Seeker
public class Seeker : Mover {

	public GameObject target;

	protected override void Start () {
		base.Start ();
	}

	protected override void CalcSteering() {
		if (target) {
			// the next line is a fancy toggle comment ... make it read /* instead of //* and see what happens
			//*
			ApplyForce( Seek (target.transform.position));
			/*/
			velocity += Seek (target.transform.position);
			//*/
		}
	}
}
