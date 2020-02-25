using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformasMoviles : MonoBehaviour {

    private Vector3 walkAmount;
    public float walkSpeed = 5.0f, walkingDirection = 1.0f;

    // Waypoints
    public Transform PuntoA, PuntoB;
    public Transform PuntoA_Borde, PuntoB_Borde;

    
    public bool posicionX = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (posicionX) {

            walkAmount.x = walkingDirection * walkSpeed * Time.deltaTime;

            if (walkingDirection > 0.0f && PuntoB_Borde.position.x >= PuntoB.position.x)
            {
                walkingDirection = -1f;
            }

            else if (walkingDirection <= 1.0f && PuntoA_Borde.position.x <= PuntoA.position.x)
            {
                walkingDirection = 1f;
            }
        }
        else
        {
            walkAmount.y = walkingDirection * walkSpeed * Time.deltaTime;

            if (walkingDirection > 0.0f && PuntoB_Borde.position.y >= PuntoB.position.y)
            {
                walkingDirection = -1f;
            }

            else if (walkingDirection <= 1.0f && PuntoA_Borde.position.y <= PuntoA.position.y)
            {
                walkingDirection = 1f;
            }
        }
        transform.Translate(walkAmount);

    }
}
