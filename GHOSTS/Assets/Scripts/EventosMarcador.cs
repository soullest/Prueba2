using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EventosMarcador : MonoBehaviour {


	public Text text;

	bool detener = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (detener && Time.frameCount >= 2) {
			Time.timeScale =0.0f;
		} else {
			Time.timeScale =  1.0f;
		}

		if(Input.GetKeyDown(KeyCode.Q)){
			MarcadorEncontrado("Codigo Q");
		} else if(Input.GetKeyDown(KeyCode.W)){
			MarcadorPerdido("Codigo W");
		}

	}

	public void MarcadorEncontrado(string tipo){
		if (text != null) {
			text.text = "Dispara a los fantasmas";
		}
		Debug.Log ("Marcador Encontrado " +tipo);
		detener = false;
	}

	public void MarcadorPerdido(string tipo){
		if (text != null) {
			text.text = "Apunta al marcador";
		}
		Debug.Log ("Marcador Perdido "+tipo);
		detener = true;
	}


}
