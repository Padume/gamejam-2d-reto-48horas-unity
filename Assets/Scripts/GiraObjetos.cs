using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiraObjetos : MonoBehaviour {

    public float turnSpeed = 50f;
    public Transform pivot,bloques;
    public float posicionY = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
        bloques.transform.position = new Vector3(pivot.transform.position.x, pivot.transform.position.y  - posicionY, bloques.transform.position.z);
    }
}
