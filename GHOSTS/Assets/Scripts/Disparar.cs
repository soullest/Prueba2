using UnityEngine;
using System.Collections;

public class Disparar : MonoBehaviour {

	public Transform disparo;
	public float tiempoEntreDisparo =0.5f;
	float sigDisparo =0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1") || (Input.touchCount > 0)) {
			if(Time.time - tiempoEntreDisparo > sigDisparo){
				Ray r1=  camera.ScreenPointToRay(Input.mousePosition);
				Instantiate(disparo, r1.origin,transform.rotation);
				Debug.Log ("X "+r1.origin.x +"Y "+r1.origin.y +"Z "+r1.origin.z);
				sigDisparo=Time.time;
			}
		}
	}
}
