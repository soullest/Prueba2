using UnityEngine;
using System.Collections;

public class MuereFantasma : MonoBehaviour {

	public float radioMuerte = 12.0f;

	private Rotar_fantasmas rotar;

	private EstadoJuego estado;

	private bool escape = false;

	// Use this for initialization
	void Start () {
		rotar = GetComponent<Rotar_fantasmas> ();
		estado = ControladorJuego.obtenerComponente<EstadoJuego>("Controlador");
	}
	
	// Update is called once per frame
	void Update () {
		if (escape)
			return;
		if(rotar.radio >= radioMuerte){
			escape=true;
			FantasmaEscapa();
		}
	}

	private void FantasmaEscapa(){
		SphereCollider collider = GetComponent<SphereCollider> ();
		collider.enabled = false;
		estado.PerderVida ();
		Animator anim = GetComponentInChildren<Animator> ();
		anim.SetBool ("escapar", true);
		//Destroy (gameObject);
	}
}
