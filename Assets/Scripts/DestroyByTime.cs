using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {

	public int lifetime;

	void Start() {
		Destroy(gameObject, lifetime);
	}
}
