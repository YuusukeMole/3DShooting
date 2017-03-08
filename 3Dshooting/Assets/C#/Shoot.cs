using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour 
{
	public Rigidbody BarretPrefub;
	public Transform RightArmTransForm;
	public Transform LeftArmTransForm;
	private  bool rightorleft=true; //trueならばright

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			Rigidbody barret;
			if (rightorleft) {
				barret = Instantiate (BarretPrefub, RightArmTransForm.position, RightArmTransForm.rotation)as Rigidbody;
				barret.AddForce (RightArmTransForm.forward * 1000);
				rightorleft = false;
			} else {
				barret = Instantiate (BarretPrefub, LeftArmTransForm.position, LeftArmTransForm.rotation)as Rigidbody;
				barret.AddForce (LeftArmTransForm.forward * 1000);
				rightorleft = true;
			}
		}
	}
}
