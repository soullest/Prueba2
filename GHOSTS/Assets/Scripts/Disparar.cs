using UnityEngine;
using System.Collections;

public class Disparar : MonoBehaviour {

	public Transform disparo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") || (Input.touchCount > 0)) {
			Instantiate(disparo, transform.position,transform.rotation);
		}
	}
}
