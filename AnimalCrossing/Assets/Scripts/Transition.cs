using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public GameObject blackScreen;
    public GameObject gameScreen;

    public GameObject playText;
    public bool canPlay = false;


    // Start is called before the first frame update
    void Start()
    {
        blackScreen.SetActive(false);  
    }

    private void Update()
    {
        if(canPlay)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                blackScreen.SetActive(true);
                gameScreen.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playText.SetActive(true);
            canPlay = true;
      
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playText.SetActive(false);
            canPlay = false;
        }
    }
}
