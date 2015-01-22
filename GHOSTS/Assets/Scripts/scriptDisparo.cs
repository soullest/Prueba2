using UnityEngine;
using System.Collections;

public class scriptDisparo : MonoBehaviour {

	public float fuerza=1000;


	// Use this for initialization
	void Start () {
		rigidbody.AddForce (transform.forward*fuerza);
		Destroy (gameObject, 10.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "piso") {
			Destroy (gameObject,0.8f);
			GetComponentInChildren<ParticleSystem>().enableEmission = false;
		}
		else if (other.tag == "enemigo") {
			Destroy (gameObject,0.8f);
			GetComponentInChildren<ParticleSystem>().enableEmission = false;
			other.SendMessage("Muere",SendMessageOptions.DontRequireReceiver);
		}

	}
}
