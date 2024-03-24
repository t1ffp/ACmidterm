using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatDetector : MonoBehaviour
{
    public bool isHit;
    public AudioSource cameraShutter;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Note"))
        {
      
            if (Input.GetKeyDown(KeyCode.Q))
            {
                //Debug.Log("Hit");
                isHit = true;
                cameraShutter.Play();
            }
            else
            {
                isHit = false;
            }     
         
        }
    }
  
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Note"))
        {
            isHit = false;
        }
    }
    
}
