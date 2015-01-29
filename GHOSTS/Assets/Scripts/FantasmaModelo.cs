using UnityEngine;
using System.Collections;

public class FantasmaModelo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void FantasmaDesaparecido(){
		Debug.Log ("DESAPARECIDO");
		Destroy (gameObject.transform.parent.gameObject);
	}
}
