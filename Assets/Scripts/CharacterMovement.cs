using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CharacterMovement : MonoBehaviour {

    bool start;
    public bool dead;
    public float speed;
    


    // Use this for initialization
    void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {

            Debug.Log(CrossPlatformInputManager.GetAxis("Horizontal"));


        if (!dead)
        {
            if (Input.GetKeyDown("space"))
            {
                gameObject.GetComponent<AudioSource>().Play();
                //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f,200.0f));
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0.0f, 3.0f, 0.0f);
                start = true;

            }
            if (start)
            {
                gameObject.transform.position = gameObject.transform.position + new Vector3(0.01f*speed, 0.0f, 0.0f);
            }
        }

    }
}
