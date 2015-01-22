using UnityEngine;
using System.Collections;

public class controlador : MonoBehaviour {

	public Transform fantasma;
	public Transform centroRotacion;

	public float espera= 2.0f;
	public float tiempoEntreFantasmas = 2.0f;
	float sigFantasma =0.0f;

	// Use this for initialization
	void Start () {
		sigFantasma = Time.time + espera;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= sigFantasma) {
			sigFantasma=Time.time+tiempoEntreFantasmas;
			Transform fant = Instantiate(fantasma,centroRotacion.transform.position,centroRotacion.transform.rotation) as Transform;
			Rotar_fantasmas rot = fant.GetComponent<Rotar_fantasmas>();
			rot.centro = centroRotacion;
		}
	}
}
