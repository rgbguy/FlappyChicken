using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DieOnCollision : MonoBehaviour
{
    public AudioSource AudioFall;
    public AudioSource AudioHit;

    void OnTriggerEnter2D(Collider2D theCollision)
    {
        if (!gameObject.GetComponent<CharacterMovement>().dead && theCollision.gameObject.tag == "Obstacle")
        {
            //AudioHit.Play();
            gameObject.GetComponent<Animator>().SetBool("Dead", true);
            theCollision.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<CharacterMovement>().dead = true;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0.0f, 0.01f, 0.0f);
            StartCoroutine(ReloadLevel());
        }

    }
    IEnumerator ReloadLevel()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}