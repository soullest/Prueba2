using UnityEngine;
using System.Collections;

public class comportamientoFantasma : MonoBehaviour {

	public Transform explosion;



	private EstadoJuego estado;

	// Use this for initialization
	void Start () {
		estado = ControladorJuego.obtenerComponente<EstadoJuego> ("Controlador");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Muere(){
		//si quisieramos eliminar el padre hariamos: gameObject.transform.parent.gameObject
		Instantiate (explosion, transform.position, transform.rotation);
		Rotar_fantasmas rotar =  GetComponent<Rotar_fantasmas>();
		MuereFantasma muere = GetComponent<MuereFantasma>();

		int puntos = (int)((100 * rotar.radio) / muere.radioMuerte);


		estado.IncrementarPuntuacion (puntos);
		Destroy (gameObject);
	}
}
