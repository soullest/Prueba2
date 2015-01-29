using UnityEngine;
using System.Collections;

public class MuereFantasma : MonoBehaviour {

	public float radioMuerte = 12.0f;

	private Rotar_fantasmas rotar;

	private EstadoJuego estado;

	// Use this for initialization
	void Start () {
		rotar = GetComponent<Rotar_fantasmas> ();
		estado = ControladorJuego.obtenerComponente<EstadoJuego>("Controlador");
	}
	
	// Update is called once per frame
	void Update () {
		if(rotar.radio >= radioMuerte){
			FantasmaEscapa();
		}
	}

	private void FantasmaEscapa(){
		estado.PerderVida ();
		Destroy (gameObject);
	}
}
