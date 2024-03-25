using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeatDetector : MonoBehaviour
{
    public bool isHit;
    public AudioSource cameraShutter;

    public int followCount = 0;
    public TextMeshProUGUI followers;

    private void Update()
    {
        followers.text = (followCount).ToString("0");
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Note"))
        {
      
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Debug.Log("Hit");
                isHit = true;
                cameraShutter.Play();
                followCount += 50;
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
