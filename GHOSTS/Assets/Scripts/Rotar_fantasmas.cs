using UnityEngine;
using System.Collections;

public class Rotar_fantasmas : MonoBehaviour {

	public Transform  centro;
	public float rps =75.0f;
	public float radio = 0.1f;
	public float incr_radio = 0.5f;
	public float escala =0.5f;

	public bool enabled= false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.localScale = new Vector3 (escala, escala, escala);
		transform.position = new Vector3(centro.position.x, transform.position.y, centro.position.z);
		transform.Translate (-radio,0,0);
		transform.RotateAround (centro.position, Vector3.up, rps * Time.deltaTime);
		radio += incr_radio * Time.deltaTime;
		escala += 0.2f * Time.deltaTime;
	}

	void OnBecameVisible() {
		
		enabled = true;

		Debug.Log ("VISIBLE");
		
	}
	
	void OnBecameInvisible() {
		
		enabled = false;
		Debug.Log ("INVISIBLE");
		
	}
}
