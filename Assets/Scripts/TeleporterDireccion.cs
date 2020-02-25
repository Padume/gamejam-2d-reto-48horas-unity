using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterDireccion : MonoBehaviour
{
    public GameObject camara;
    public float posicion_camaraX = 0f;
    public float posicion_camaraY = 0f;

    public GameObject Canvas;

    //public string mundo = "";
    //public TextMeshProUGUI dialog;
    //public bool nombreMapa = false;

    // Animaciones
    //public Animator animator = null;

    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        // Cuando la animacion se Ejecuta hace que cambie el estado
        /*
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Efecto")){
            animator.SetBool("Activo", false);
        }

        // Obteniendo el estado de la animacion
        //Debug.Log("Estado:" + animator.GetCurrentAnimatorStateInfo(0).IsName("Efecto"));
        */
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Coordenadas bases de la camara
        // 20.835
        // 56.835

        /*
        // Activar Nombre de Mapa
        if (nombreMapa){
            dialog.text = mundo;
            animator.SetBool("Activo", true);
        }
        */

        if (posicion_camaraX == 0.0f && posicion_camaraY == 0.0f)
        {
            Canvas.SetActive(true);
        }
        else
        {
            Canvas.SetActive(false);
        }
        camara.transform.position = new Vector3(posicion_camaraX, posicion_camaraY, -4);
        //NotificationCenter.DefaultCenter().PostNotification(this, "CambiarColorFondo", mundo);
        //NotificationCenter.DefaultCenter().PostNotification(this, "CambioPosiciones");
    }
}
