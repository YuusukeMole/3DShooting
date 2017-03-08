using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barret : MonoBehaviour 
{
	private float lifetime = 1.0f;

	void Update()
	{
		lifetime -= Time.deltaTime;
		if (lifetime < 0) {
			Destroy (gameObject);
		}
	}
}
