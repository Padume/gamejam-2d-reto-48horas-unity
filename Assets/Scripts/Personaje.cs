using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    // Datos Basicos del Personaje
    public float velocidad_personaje = 10.0F;
    public float fuerzaSalto = 25f;
    public bool jump = false;

    // rigid2D
    Rigidbody2D rigid2D;

    // Compradores Del Suelo
    public bool enSuelo = true;
    public Transform comprobadorSuelo;
    public float comprobadorPersonaje = 0.07f;
    public LayerMask mascaraSuelo;


    // Animaciones
    private Animator animator = null;



    // Punto de CheckPoint
    public float posX = 0f, posY = -5.35f;



    // Iniciando las Animaciones
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Se Ejecuta Al Iniciar
    void Start()
    {

        //Initialize rigid2D
        rigid2D = GetComponent<Rigidbody2D>();

        // Señal de Muerte
        NotificationCenter.DefaultCenter().AddObserver(this, "nuevoCheckPoint");
        NotificationCenter.DefaultCenter().AddObserver(this, "GolpeRecibido");
    }


    void nuevoCheckPoint(Notification notification){

        // Activando CheckPoint
        string datosSeparar = (string)notification.data;
        string[] arregloSeparado;
        arregloSeparado = datosSeparar.Split(',');
        posX = float.Parse(arregloSeparado[0]);
        posY = float.Parse(arregloSeparado[1]);

    }

    void GolpeRecibido(Notification notification)
    {

        // Activando Poderes
        this.transform.position = new Vector3(posX, posY, -1f);
    }


    // Actualiza cada frame por segundo
    void Update()
    {

        // Animacion
        animator.SetFloat("Speed", Mathf.Abs(rigid2D.velocity.x));
        animator.SetBool("Grounded", enSuelo);

        if (Input.GetKeyDown(KeyCode.Space)){
            jump = true;
        }

    }

    // Se llama cada cierto tiempo costante
    void FixedUpdate(){

        float direccion_movimiento = Input.GetAxis("Horizontal");

        // Verificador de Suelo
        enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobadorPersonaje, mascaraSuelo);

        if (jump){
            
            if (enSuelo)
            {
                jump = false;
                rigid2D.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            }
        }

        //rigid2D.AddForce(Vector2.right * velocidad_personaje * direccion_movimiento);
        rigid2D.velocity = new Vector3(direccion_movimiento * velocidad_personaje, rigid2D.velocity.y);

        if (direccion_movimiento > 0.1f){
           transform.localScale = new Vector3(1.5f, 1.5f, 1f);
        }

        if (direccion_movimiento < -0.1f) {
           transform.localScale = new Vector3(-1.5f, 1.5f, 1f);
        }
    

    }


}
