using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarMapas : MonoBehaviour
{
    public string mapaCargar;

    public void iniciarJuego(string mapaCargar)
    {
        this.mapaCargar = mapaCargar;
        // Deshabilitar El SOnido DE fONDO
        //Camera.main.audio.Stop();
        //audio.Play();

        Invoke("CargarNivelJuego",0);
    }

    void CargarNivelJuego(){
        Application.LoadLevel(mapaCargar);
    }

    public void CerrarJuego(){
        Application.Quit();
    }

}
