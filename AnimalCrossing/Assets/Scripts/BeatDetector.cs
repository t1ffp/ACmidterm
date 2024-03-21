using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatDetector : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Note"))
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log("Hit");
            }
         
        }
    }

   
    /*
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Note"))
        {
            Debug.Log("left");
        }
    }
    */

}
