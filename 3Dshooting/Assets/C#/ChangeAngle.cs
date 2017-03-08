using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAngle : MonoBehaviour {
	private int changecount = 0;

	void Update () {
		
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			if (changecount <= 2) {
				changecount++;
			}
		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			if (changecount >= -2) {
				changecount--;
			}
		}
		transform.rotation = Quaternion.Euler (0, 30 * changecount, 0);
	}
}
