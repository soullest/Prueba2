using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EstadoJuego : MonoBehaviour {

	public int vidasActuales = 0;
	public int vidasIniciales = 3;

	public int puntuacion = 0;

	public Animator anim;
	public Text puntosText;

	// Use this for initialization
	void Start () {
		vidasActuales = vidasIniciales;
		puntuacion = 0;
		ActualizarPuntuacion ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void PerderVida(){
		if (vidasActuales > 0) {
			vidasActuales--;
			anim.SetInteger("Vidas",vidasActuales);
			Debug.Log("Vidas: "+vidasActuales);

			if(vidasActuales<=0){
				SendMessage("PartidaTerminada",SendMessageOptions.DontRequireReceiver);
			}
		}


	}

	public void IncrementarPuntuacion(int valorIncrementa){
		puntuacion += valorIncrementa;
		ActualizarPuntuacion ();
	}

	public void ActualizarPuntuacion(){
		puntosText.text = "Points: " + puntuacion.ToString ("D5");
		Debug.Log ("Puntuacion: "+puntuacion);
	}
}
