using UnityEngine;
using System.Collections;

public class ControladorJuego : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static Tipo obtenerComponente<Tipo>(string nombreGameObject) where Tipo : UnityEngine.Component
	{
		GameObject controlador = GameObject.Find (nombreGameObject);
		if (controlador != null) {
			return controlador.GetComponent<Tipo>();
		}else {
			Debug.LogError("No se ha encontrado el Game Object "+nombreGameObject);
			return null;
		}
	}
}
