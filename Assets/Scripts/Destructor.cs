using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destructor : MonoBehaviour {

    public string textoIzquierda;
    public TextMeshProUGUI textoInicio;

    // Reubicar Camara 
    private float posicion_camaraX = 0f;
    private float posicion_camaraY = 0f;
    public GameObject camara;

    public GameObject Canvas;

    // Use this for initialization
    void Start () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player"){
            camara.transform.position = new Vector3(posicion_camaraX, posicion_camaraY, -4);
            NotificationCenter.DefaultCenter().PostNotification(this, "GolpeRecibido");
            textoInicio.text = textoIzquierda;
            Canvas.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
