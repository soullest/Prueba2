using UnityEngine;
using System.Collections;

public class scriptDisparo : MonoBehaviour {

	public float fuerza=1000;

	// Use this for initialization
	void Start () {
		rigidbody.AddForce (0.0f, 0.0f, -5000.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
