using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using System . Collections;
using System.Collections.Generic;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerScript;
    public AudioSource audioSource;
    public AudioSource audioSource1;
#pragma warning disable CS0618 // Type or member is obsolete
    public Score score;
     public GameController gameController;
#pragma warning restore CS0618 // Type or member is obsolete
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("collectables"))
        {
            audioSource.Play();
            score.AddScore(1);
        //score.;
           Destroy(other.gameObject);
        }
    }    
    private void OnCollisionEnter(Collision other)
     {
        if(other.gameObject.CompareTag("obstacles"))
        {
            audioSource1.Play();
            gameController.GameOver();
            
          playerScript.enabled = false;
        } 
    }    
}
