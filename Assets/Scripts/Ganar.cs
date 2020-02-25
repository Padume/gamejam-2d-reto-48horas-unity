using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ganar : MonoBehaviour
{
    public int puntos = 0;
    public GameObject efectoParticula;
    public Transform posicionGanar;
    
    public TextMeshProUGUI textoInicio;
    public GameObject Player;
    public GameObject camara;
    public GameObject textoFinal;


    public Animator anim1;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;

    public bool A = false;
    public bool H = false;
    public bool L = false;
    public bool U = false;
    public bool R = false;
    public bool S = false;
    public bool O = false;
    public bool I = false;
    public bool E = false;
    public bool T = false;
    public bool M = false;
    public bool C = false;
    public bool W = false;
    public bool N = false;

    public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "ObtenerPunto");
    }

    void ObtenerPunto(Notification notification)
    {

        // Activando CheckPoint
        string datosSeparar = (string)notification.data;
       
           if(datosSeparar == "A")
            A = true;

        if (datosSeparar == "H")
            H = true;


        if (datosSeparar == "L")
            L = true;

        if (datosSeparar == "U")
            U = true;

        if (datosSeparar == "R")
            R = true;

        if (datosSeparar == "S")
            S = true;

        if (datosSeparar == "O")
            O = true;

        if (datosSeparar == "I")
            I = true;

        if (datosSeparar == "E")
            E = true;

        if (datosSeparar == "T")
            T = true;

        if (datosSeparar == "M")
            M = true;

        if (datosSeparar == "C")
            C = true;

        if (datosSeparar == "W")
            W = true;

        if (datosSeparar == "N")
            N = true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        if (A && H & L && U && R && S && O && I && E  && T && M && C && W && N){
            GameObject efecto = Instantiate(efectoParticula, posicionGanar.transform.position, Quaternion.identity);
            Destroy(efecto, 1f);
            Player.transform.position = new Vector3(0, -5, -1f);
            textoInicio.text = "FELICIDADES ESTE MUNDO ESTA VIVO, Gracias a Myriam,Tavo,Gloria,Jaime,Sara,Lore,Carmen y Janna. Tutores, GameJamTopia y EKVelika por la musica.";
            camara.transform.position = new Vector3(0, 0, -4);
            Canvas.SetActive(true);
            Destroy(textoFinal, 2f);
            anim1.SetBool("Ganar", true);
            anim2.SetBool("Ganar", true);
            anim3.SetBool("Ganar", true);
            anim4.SetBool("Ganar", true);
        }
    }
}
