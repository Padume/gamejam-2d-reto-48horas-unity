using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObtenerLetra : MonoBehaviour
{
    public AudioClip itemObtenido;
    public TextMeshProUGUI letraObtenida1, letraObtenida2 = null, letraObtenida3 = null, letraObtenida4 = null;
    public int nroUso;

    public Animator oLetraAnimada;
    public TextMeshProUGUI textoInicio;
    public string textoIzquierda;
    public GameObject efectoParticula;
    public string fraseEscritor = "";
    public TextMeshProUGUI mensajeEscritor;

    public TextMeshProUGUI mensajeEscritorNombre;
    public TextMeshProUGUI mensajeInicialLetra;

    public string escritor;
    public string inicialEscritor;

    // Animaciones
    public Animator animator = null;
    public Animator animator1 = null;
    public Animator animator2 = null;

    // Update is called once per frame
    void Update(){

        // Cuando la animacion se Ejecuta hace que cambie el estado
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Efecto")){
            animator.SetBool("Activo", false);
        }

        // Cuando la animacion se Ejecuta hace que cambie el estado
        if (animator1.GetCurrentAnimatorStateInfo(0).IsName("Efecto"))
        {
            animator1.SetBool("Activo", false);
        }

        // Cuando la animacion se Ejecuta hace que cambie el estado
        if (animator2.GetCurrentAnimatorStateInfo(0).IsName("Efecto"))
        {
            animator2.SetBool("Activo", false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(itemObtenido, Camera.main.transform.position, 1f);
            GameObject efecto = Instantiate(efectoParticula, transform.position, Quaternion.identity);

            if (nroUso == 1)
                letraObtenida1.color = new Color32(0, 0, 0, 255);

            if (nroUso == 2) { 
                letraObtenida1.color = new Color32(0, 0, 0, 255);
                letraObtenida2.color = new Color32(0, 0, 0, 255);
            }

            if (nroUso == 3)
            {
                letraObtenida1.color = new Color32(0, 0, 0, 255);
                letraObtenida2.color = new Color32(0, 0, 0, 255);
                letraObtenida3.color = new Color32(0, 0, 0, 255);
            }

            if (nroUso == 4)
            {
                letraObtenida1.color = new Color32(0, 0, 0, 255);
                letraObtenida2.color = new Color32(0, 0, 0, 255);
                letraObtenida3.color = new Color32(0, 0, 0, 255);
                letraObtenida4.color = new Color32(0, 0, 0, 255);
            }

            oLetraAnimada.SetBool("Activo", true);

            mensajeEscritor.text = fraseEscritor;
            mensajeEscritorNombre.text = escritor;
            mensajeInicialLetra.text = inicialEscritor;

            animator.SetBool("Activo", true);
            animator1.SetBool("Activo", true);
            animator2.SetBool("Activo", true);

            NotificationCenter.DefaultCenter().PostNotification(this, "ObtenerPunto", inicialEscritor);

            Destroy(efecto, 1f);
            textoInicio.text = textoIzquierda;
            //NotificationCenter.DefaultCenter().PostNotification(this, "ActivarPowerUp", powerUp);
        }
    }
}
