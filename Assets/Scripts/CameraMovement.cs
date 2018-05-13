using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public GameObject bird;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xval = bird.transform.position.x;
        gameObject.transform.position = new Vector3(xval, transform.position.y, transform.position.z);
	}


}
