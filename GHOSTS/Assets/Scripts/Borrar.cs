using UnityEngine;
using System.Collections;

public class Borrar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnBecameVisible() {
		
		enabled = true;
		
		Debug.Log ("VISIBLE CUBO");
		
	}
	
	void OnBecameInvisible() {
		
		enabled = false;
		Debug.Log ("INVISIBLE CUBO");
		
	}
}
