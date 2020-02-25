using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiraSierras : MonoBehaviour {

    public float turnSpeed = 50f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
    }
}
