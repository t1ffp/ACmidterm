using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatVFX : MonoBehaviour
{
    public Animator hitAnim;
    public GameObject hitVFX;
    public BeatDetector beatDetector;
   

    // Start is called before the first frame update
    void Start()
    {
        hitAnim = GetComponent<Animator>();
       
     
    }

    private void Update()
    {
        if (beatDetector.isHit )
        {
            hitAnim.SetBool("isPlaying", true);
        }
        else
        {
            hitAnim.SetBool("isPlaying", false);
        }
 
    }
}
