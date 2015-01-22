using UnityEngine;
using System.Collections;

public class comportamientoFantasma : MonoBehaviour {

	public Transform explosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Muere(){
		//si quisieramos eliminar el padre hariamos: gameObject.transform.parent.gameObject
		Instantiate (explosion, transform.position, transform.rotation);
		Destroy (gameObject);
	}
}
