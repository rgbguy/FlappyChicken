using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PitOfDeath : MonoBehaviour {


    void OnTriggerExit2D(Collider2D theCollision)
    {
        if(theCollision.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }
}
