using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnNextObstacle : MonoBehaviour
{
    bool DoneOnce;
    public GameObject ObstacleToSpawn;
    public Text Scoretext;
    int score;
    //public AudioSource AudioScore;

    void OnTriggerEnter2D(Collider2D theCollision)
    {
        if (!gameObject.GetComponent<CharacterMovement>().dead && theCollision.gameObject.tag == "ObstacleMid")
        {
            score++;
            Scoretext.text = "SCORE: " + score.ToString();
            Debug.Log("Score");
            theCollision.GetComponent<AudioSource>().Play();
            GameObject SpawnedObstacle = GameObject.Instantiate(ObstacleToSpawn, new Vector3(gameObject.transform.position.x + 5.0f, Random.Range(0.59f,2.28f),0.0f),new Quaternion(0,0,-1,1)) as GameObject;

            //Transform SpawnTransform;

        }

    }
}
