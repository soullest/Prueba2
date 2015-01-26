using UnityEngine;
using System.Collections;

public class Rotar_fantasmas : MonoBehaviour {

	public Transform  centro;
	public float rps =75.0f;
	public float radio = 0.1f;
	public float incr_radio = 0.5f;
	public float escala =3.0f;
	public float incr_escala = 1.0f;

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
		if(escala<12.0f)
			escala += incr_escala * Time.deltaTime;
	}


}
